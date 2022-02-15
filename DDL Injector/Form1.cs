using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DDL_Injector
{
    public partial class Form1 : Form
    {
        public string FilePath;
        private List<Process> global_processes;
        int pid = -1;
        public Form1()
        {
            InitializeComponent();
            global_processes = new List<Process>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(!openFileDialog1.CheckFileExists || !openFileDialog1.CheckPathExists)
            {
                openFileDialog1.ShowDialog();
                return;
            }
            FilePath = openFileDialog1.FileName;
            file_path.Text = FilePath;
            //file_path_label.Text = $"File path:{FilePath}";
        }

        private void pid_label_Click(object sender, EventArgs e)
        {

        }
        private bool lockByPid(int pid)
        {
            Process hw = Process.GetProcessById(pid);
            if (hw == null)
                return false;
            return true;
        }
        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MysterJacob/DDL_Injector/blob/master/README.md");
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void openByPIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pid_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            if(selected != null)
            {
                pid = global_processes[comboBox1.SelectedIndex].Id;
                pid_box.Text = pid.ToString();
            }
        }
        private void RefreshList()
        {
            Process[] processes = Process.GetProcesses();
            global_processes.Clear();
            comboBox1.Items.Clear();
            global_processes.AddRange(processes);
            for (int i = 0; i < processes.Length; i++)
            {
                comboBox1.Items.Add($"{processes[i].ProcessName}({processes[i].Id})");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void lock_on_pid_Click(object sender, EventArgs e)
        {
            RefreshList();
            if (int.TryParse(pid_box.Text, out pid))
            {
                try
                {
                    Process hw = Process.GetProcessById(pid);
                    comboBox1.SelectedIndex = comboBox1.Items.IndexOf($"{hw.ProcessName}({hw.Id})");
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid pid has been provided","INVALID PID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
        
        internal static class kernel32
        {
            [Flags]
            public enum ProcessAccessFlags : uint
            {
                All = 0x001F0FFF,
                Terminate = 0x00000001,
                CreateThread = 0x00000002,
                VMOperation = 0x00000008,
                VMRead = 0x00000010,
                VMWrite = 0x00000020,
                DupHandle = 0x00000040,
                SetInformation = 0x00000200,
                QueryInformation = 0x00000400,
                Synchronize = 0x00100000
            }
            [Flags]
            public enum AllocationType
            {
                Commit = 0x1000,
                Reserve = 0x2000,
                Decommit = 0x4000,
                Release = 0x8000,
                Reset = 0x80000,
                Physical = 0x400000,
                TopDown = 0x100000,
                WriteWatch = 0x200000,
                LargePages = 0x20000000
            }
            [Flags]
            public enum MemoryProtection
            {
                Execute = 0x10,
                ExecuteRead = 0x20,
                ExecuteReadWrite = 0x40,
                ExecuteWriteCopy = 0x80,
                NoAccess = 0x01,
                ReadOnly = 0x02,
                ReadWrite = 0x04,
                WriteCopy = 0x08,
                GuardModifierflag = 0x100,
                NoCacheModifierflag = 0x200,
                WriteCombineModifierflag = 0x400
            }
            [DllImport("kernel32.dll")]
            public static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

            [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
            public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

            [DllImport("kernel32.dll")]
            public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocationType freeType);

            [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
            public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] in string lpModuleName);

            [DllImport("kernel32.dll")]
            public static extern IntPtr CreateRemoteThread(IntPtr hProcess,IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
            [DllImport("kernel32.dll")]
            public static extern Int32 CloseHandle(IntPtr hProcess);
        }


        private void Inject()
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("No file has been selected", "INVALID PATH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(pid == -1)
            {
                MessageBox.Show("No process has been selected", "INVALID PID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Process hw = Process.GetProcessById(pid);
            IntPtr hw = kernel32.OpenProcess(kernel32.ProcessAccessFlags.All, false, pid);
            IntPtr addr = kernel32.VirtualAllocEx(hw, IntPtr.Zero, 0x1000, kernel32.AllocationType.Commit | kernel32.AllocationType.Reserve, kernel32.MemoryProtection.ExecuteReadWrite);
            if(addr == null)
            {
                MessageBox.Show("VirtualAllocEx failed.", "Operation failed.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                kernel32.CloseHandle(hw);
                return;
            }
            byte[] path = Encoding.ASCII.GetBytes(FilePath);
            int written;
            bool ret = kernel32.WriteProcessMemory(hw, addr, path, (uint)path.Length, out written);
            if (!ret)
            {
                MessageBox.Show("WriteProcessMemory failed.", "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kernel32.VirtualFreeEx(hw, addr, 0x1000, (kernel32.AllocationType)0x8000);
                kernel32.CloseHandle(hw);
                return;
            }
            IntPtr kernelAddres = kernel32.GetModuleHandle("kernel32.dll");
            if(kernelAddres == IntPtr.Zero)
            {
                MessageBox.Show("Target has no kernel32.dll loaded.", "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kernel32.VirtualFreeEx(hw, addr, 0x1000, (kernel32.AllocationType)0x8000);
                kernel32.CloseHandle(hw);
                return;
            }
            IntPtr LoadLibralyA_adress= kernel32.GetProcAddress(
                kernelAddres,
                "LoadLibraryA"
             );


            IntPtr thread = kernel32.CreateRemoteThread(hw, IntPtr.Zero, 0, LoadLibralyA_adress, addr ,0, IntPtr.Zero);
            if(thread == IntPtr.Zero)
            {
                MessageBox.Show("Failed to create remote thread.", "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kernel32.VirtualFreeEx(hw, addr, 0x1000, (kernel32.AllocationType)0x8000);
                kernel32.CloseHandle(hw);
                return;
            }
            kernel32.CloseHandle(thread);

        }
        private void inject_button_Click(object sender, EventArgs e)
        {
            Inject();
        }

        private void injectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inject();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void choose_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
