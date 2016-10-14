using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace SAMP_Ex
{
    class GTAUtils
    {
        #region WinAPI Wrapper

        const uint DETACHED_PROCESS = 0x00000008;
        const uint CREATE_SUSPENDED = 0x00000004;

        const uint MEM_RELEASE = 0x8000;

        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        public struct SECURITY_ATTRIBUTES
        {
            public int length;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        internal static class NativeMethods /* provides all the wrappers to the WINAPI */
        {

            [Flags()]
            public enum ProcessAccess : int
            {
                /// <summary>Specifies all possible access flags for the process object.</summary>
                AllAccess = CreateThread | DuplicateHandle | QueryInformation | SetInformation | Terminate | VMOperation | VMRead | VMWrite | Synchronize,
                /// <summary>Enables usage of the process handle in the CreateRemoteThread function to create a thread in the process.</summary>
                CreateThread = 0x2,
                /// <summary>Enables usage of the process handle as either the source or target process in the DuplicateHandle function to duplicate a handle.</summary>
                DuplicateHandle = 0x40,
                /// <summary>Enables usage of the process handle in the GetExitCodeProcess and GetPriorityClass functions to read information from the process object.</summary>
                QueryInformation = 0x400,
                /// <summary>Enables usage of the process handle in the SetPriorityClass function to set the priority class of the process.</summary>
                SetInformation = 0x200,
                /// <summary>Enables usage of the process handle in the TerminateProcess function to terminate the process.</summary>
                Terminate = 0x1,
                /// <summary>Enables usage of the process handle in the VirtualProtectEx and WriteProcessMemory functions to modify the virtual memory of the process.</summary>
                VMOperation = 0x8,
                /// <summary>Enables usage of the process handle in the ReadProcessMemory function to' read from the virtual memory of the process.</summary>
                VMRead = 0x10,
                /// <summary>Enables usage of the process handle in the WriteProcessMemory function to write to the virtual memory of the process.</summary>
                VMWrite = 0x20,
                /// <summary>Enables usage of the process handle in any of the wait functions to wait for the process to terminate.</summary>
                Synchronize = 0x100000
            }

            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
            internal static extern IntPtr LoadLibraryA(string lpFileName);

            [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
            internal static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool FreeLibrary(IntPtr hModule);

            [DllImport("kernel32.dll")]
            internal static extern IntPtr OpenProcess(ProcessAccess dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

            [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
            internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
               uint dwSize, UInt32 flAllocationType, UInt32 flProtect);

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

            [DllImport("kernel32.dll")]
            internal static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, UIntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

            [DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
            internal static extern Int32 WaitForSingleObject(IntPtr handle, Int32 milliseconds);

            [DllImport("kernel32.dll")]
            internal static extern Int32 CloseHandle(IntPtr hObject);

            [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
            internal static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

            [DllImport("kernel32.dll")]
            internal static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
                bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment,
                string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

            [DllImport("kernel32.dll")]
            internal static extern int ResumeThread(IntPtr hThread);

        }
        #endregion

        /// <summary>
        /// DIrectly launch GTA SAMP and connect to a Server object.
        /// </summary>
        /// <param name="server">Servr object</param>
        /// <param name="nickname">Player nickname</param>
        /// <param name="debug">Debugmode</param>
        /// <returns></returns>
        public static bool ConnectClientTo(Server server, string nickname, bool debug=false)
        {
            Debug.WriteLine(@"\SAMP_Versions\" + ConfigFile.GetSAMPDllNameForVersion(server.GetVersion()) + ".dll");
            if(ConfigFile.IsSAMPDllVersionAvalaible(server.GetVersion()))
                return LaunchGTAInjected(server.Ip.ToString(), server.Port, nickname, server.Password, debug, @"\SAMP_Versions\" + ConfigFile.GetSAMPDllNameForVersion(server.GetVersion()) + ".dll");
            else
                return LaunchGTAInjected(server.Ip.ToString(), server.Port, nickname, server.Password, debug);
        }

        public static bool ConnectClientTo(Server server, bool debug = false)
        {
            return ConnectClientTo(server, server.Nickname, debug);
        }

        /// <summary>
        /// Get the GTA directory from the SAMP registry key
        /// </summary>
        /// <returns>GTA directory address</returns>
        public static string GetGTADir()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SAMP"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("gta_sa_exe");
                        if (o != null)
                        {
                            return System.IO.Path.GetDirectoryName(o.ToString());
                        }
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        /// <summary>
        /// Set the SAMP gta installation registry key to another location
        /// </summary>
        /// <param name="dir">New directory of the GTA installation</param>
        /// <returns></returns>
        public static bool SetGTADir(string dir)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SAMP"))
                {
                    if (key != null)
                    {
                        Object o = dir;
                        key.SetValue("gta_sa_exe", o);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // 
        /// <summary>
        /// Launch GTA program with SAMP injected inside with some parameters
        /// 
        /// It is a conversion of https://github.com/Whitetigerswt/samp_launcher main code in C#
        /// </summary>
        /// <param name="ip">Server IP</param>
        /// <param name="port">Server port</param>
        /// <param name="nickname">Player nickname</param>
        /// <param name="password">Server password</param>
        /// <param name="debug">Debug mode</param>
        /// <returns>True if injection was successfull, false if not</returns>
        public static bool LaunchGTAInjected(string ip, string port, string nickname, string password = "", bool debug = false, string sampdll = @"\samp.dll")
        {

            string gtaExeLocation = ConfigFile.GetUserConfig("gtapath") + @"\gta_sa.exe";
            if(gtaExeLocation.Length == 0)
                gtaExeLocation = GetGTADir() + @"\gta_sa.exe";

            string gtaExeArgs;

            PROCESS_INFORMATION ProcessInfo = new PROCESS_INFORMATION();
            STARTUPINFO StartupInfo = new STARTUPINFO();

            if (debug == false)
                gtaExeArgs = "-c -h " + ip + " -p " + port + " -n " + nickname;
            else
                gtaExeArgs = "-d -h " + ip + " -p " + port + " -n " + nickname;

            if (password.Length != 0)
                gtaExeArgs += " -z " + password;

            Console.WriteLine(gtaExeLocation + " " + gtaExeArgs);

            if (NativeMethods.CreateProcess(gtaExeLocation, gtaExeArgs, IntPtr.Zero, IntPtr.Zero, false, DETACHED_PROCESS | CREATE_SUSPENDED, IntPtr.Zero, GetGTADir(), ref StartupInfo, out ProcessInfo))
            {
                UIntPtr bWritten;
                IntPtr hThread;

                byte[] DLLName = new ASCIIEncoding().GetBytes(GetGTADir() + sampdll); 
                Console.WriteLine(GetGTADir() + sampdll);

                IntPtr hKernel = NativeMethods.LoadLibraryA("kernel32.dll"); 
                UIntPtr LoadLib = NativeMethods.GetProcAddress(hKernel, "LoadLibraryA"); 
                NativeMethods.FreeLibrary(hKernel);

                if (LoadLib == UIntPtr.Zero)
                    return false;

                IntPtr ProcHandle = ProcessInfo.hProcess;

                if (ProcHandle == IntPtr.Zero)
                    return false;

                IntPtr arg = NativeMethods.VirtualAllocEx(ProcHandle, (IntPtr)0, (uint)DLLName.Length, 0x1000 | 0x2000, 0x04); 
                if (arg == IntPtr.Zero)
                    return false;

                Boolean WPM = NativeMethods.WriteProcessMemory(ProcHandle, arg, DLLName, (uint)DLLName.Length, out bWritten);
                if (WPM == false)
                    return false;

                IntPtr hThr = NativeMethods.CreateRemoteThread(ProcHandle, (IntPtr)0, (uint)0, LoadLib, arg, CREATE_SUSPENDED, out hThread);

                if (hThr == IntPtr.Zero)
                    return false;

                NativeMethods.ResumeThread(hThr);

                NativeMethods.WaitForSingleObject(hThr, int.MaxValue);

                NativeMethods.VirtualFreeEx(ProcessInfo.hProcess, arg, UIntPtr.Zero, MEM_RELEASE);

                NativeMethods.ResumeThread(ProcessInfo.hThread);

                NativeMethods.CloseHandle(ProcessInfo.hProcess);
            }

            return true;
        }
    }
}
