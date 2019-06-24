using System;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Management;

using SysMedia = System.Windows.Media;
using SysDraw = System.Drawing;


using OpenHardwareMonitor.Hardware;


namespace SystemMonitor.NET
{
    public partial class UI : Form
    {
        internal static uint _total_ram = uint.Parse((Program.sysinfo.TOTAL_RAM / 1048576).ToString()); //broadcast total ram to all of this program in MB
        internal static uint _total_vram = Program.sysinfo.GPU_VRAM; //broadcast total vram to all of this program

        //OHM
        internal static Computer localhost = new Computer();

        //WMI
        internal static ManagementScope mScope = new ManagementScope("\\\\localhost\\root\\CIMV2");
        internal static ObjectQuery qRAM = new ObjectQuery("Select FreePhysicalMemory from Win32_OperatingSystem"); //in KB
        internal static ManagementObjectSearcher searcherRAM = new ManagementObjectSearcher(mScope,qRAM);
        

        internal struct DYNAMIC_SYS_INFO
        {
            //CPU
            internal uint CPU_FAN;
            internal uint CPU_LOAD;
            internal uint CPU_TEMP;

            //GPU
            internal uint GPU_FAN;
            internal uint GPU_LOAD;
            internal uint GPU_TEMP;
            internal float VRAM_FREE;
            internal float VRAM_USED;

            //RAM
            internal double RAM_FREE;
            internal double RAM_USED;
        };

        internal static DYNAMIC_SYS_INFO dsi;

        public UI()
        {
            InitializeComponent();

            FormClosing += Form_Closing;

            /* 
            
            Thread @this = Thread.CurrentThread;
            @this.Priority = ThreadPriority.Lowest;
            
            */

            localhost.CPUEnabled = true;
            localhost.GPUEnabled = true;
            localhost.MainboardEnabled = true;
            localhost.Open();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;

            MaximumSize = new SysDraw.Size(1200, 500);
            MinimumSize = new SysDraw.Size(1200, 500);

            //CPU FAN
            SG_CPU_FAN.From = 0;
            SG_CPU_FAN.To = 6800;
            SG_CPU_FAN.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            SG_CPU_FAN.FromColor = SysMedia.Color.FromRgb(171, 235, 198);
            SG_CPU_FAN.ToColor = SysMedia.Color.FromRgb(46, 204, 113);
            SG_CPU_FAN.Base.Foreground = SysMedia.Brushes.Aqua;
            SG_CPU_FAN.Base.GaugeBackground = (SysMedia.SolidColorBrush)(new SysMedia.BrushConverter().ConvertFrom("#455A64"));

            //CPU LOAD
            SG_CPU_LOAD.From = 0;
            SG_CPU_LOAD.To = 100;
            SG_CPU_LOAD.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            SG_CPU_LOAD.FromColor = SysMedia.Color.FromRgb(93, 173, 226);
            SG_CPU_LOAD.ToColor = SysMedia.Color.FromRgb(52, 152, 219);
            SG_CPU_LOAD.Base.Foreground = SysMedia.Brushes.Aqua;
            SG_CPU_LOAD.Base.GaugeBackground = (SysMedia.SolidColorBrush)(new SysMedia.BrushConverter().ConvertFrom("#455A64"));

            //CPU TEMP
            SG_CPU_TEMP.From = 0;
            SG_CPU_TEMP.To = 100;
            SG_CPU_TEMP.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            SG_CPU_TEMP.FromColor = SysMedia.Color.FromRgb(230, 176, 170);
            SG_CPU_TEMP.ToColor = SysMedia.Color.FromRgb(231, 76, 60);
            SG_CPU_TEMP.Base.Foreground = SysMedia.Brushes.Aqua;
            SG_CPU_TEMP.Base.GaugeBackground = (SysMedia.SolidColorBrush)(new SysMedia.BrushConverter().ConvertFrom("#455A64"));

            //GPU FAN
            SG_GPU_FAN.From = 0;
            SG_GPU_FAN.To = 5000;
            SG_GPU_FAN.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            SG_GPU_FAN.FromColor = SysMedia.Color.FromRgb(171, 235, 198);
            SG_GPU_FAN.ToColor = SysMedia.Color.FromRgb(46, 204, 113);
            SG_GPU_FAN.Base.Foreground = SysMedia.Brushes.Aqua;
            SG_GPU_FAN.Base.GaugeBackground = (SysMedia.SolidColorBrush)(new SysMedia.BrushConverter().ConvertFrom("#455A64"));

            //GPU LOAD
            SG_GPU_LOAD.From = 0;
            SG_GPU_LOAD.To = 100;
            SG_GPU_LOAD.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            SG_GPU_LOAD.FromColor = SysMedia.Color.FromRgb(93, 173, 226);
            SG_GPU_LOAD.ToColor = SysMedia.Color.FromRgb(52, 152, 219);
            SG_GPU_LOAD.Base.Foreground = SysMedia.Brushes.Aqua;
            SG_GPU_LOAD.Base.GaugeBackground = (SysMedia.SolidColorBrush)(new SysMedia.BrushConverter().ConvertFrom("#455A64"));

            //GPU TEMP
            SG_GPU_TEMP.From = 0;
            SG_GPU_TEMP.To = 100;
            SG_GPU_TEMP.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            SG_GPU_TEMP.FromColor = SysMedia.Color.FromRgb(230, 176, 170);
            SG_GPU_TEMP.ToColor = SysMedia.Color.FromRgb(231, 76, 60);
            SG_GPU_TEMP.Base.Foreground = SysMedia.Brushes.Aqua;
            SG_GPU_TEMP.Base.GaugeBackground = (SysMedia.SolidColorBrush)(new SysMedia.BrushConverter().ConvertFrom("#455A64"));

            //RAM
            PBAR_RAM.Minimum = 0;
            PBAR_RAM.Maximum = 100;

            //VRAM
            PBAR_VRAM.Minimum = 0;
            PBAR_VRAM.Maximum = (int)Program.sysinfo.GPU_VRAM;
        }

        private void UI_Load(object sender, EventArgs e)
        {
            //CPU
            LABEL_CPU_STRING.Text = ((Program.sysinfo.CPU_STRING).Trim()) + " @ " + (Program.sysinfo.CPU_MAX_SPEED) + "GHz, On " + Program.sysinfo.MOBO_MODEL;
            LABEL_CPU_CORES_THREADS.Text = Program.sysinfo.CPU_CORES + " Core(s), " + Program.sysinfo.CPU_THREADS + " Thread(s)";
            if (Program.sysinfo.CPU_VENDOR.Contains("Intel"))
            {
                LABEL_CPU_VENDOR.Text = Program.sysinfo.CPU_VENDOR;
                LABEL_CPU_VENDOR.ForeColor = SysDraw.Color.FromArgb(0, 44, 77);
            }
            if (Program.sysinfo.CPU_VENDOR.Contains("AMD"))
            {
                LABEL_CPU_VENDOR.Text = Program.sysinfo.CPU_VENDOR;
                LABEL_CPU_VENDOR.ForeColor = SysDraw.Color.Crimson;
            }
            else
            {
                LABEL_CPU_VENDOR.Text = Program.sysinfo.CPU_VENDOR;
            }


            //RAM
            if (_total_ram < 1024)
            {
                LABEL_RAM_STRING.Text = _total_ram.ToString() + " MB @ " + Program.sysinfo.RAM_SPEED.ToString() + "MHz";
            }
            else
            {
                LABEL_RAM_STRING.Text = ((float)_total_ram / 1024).ToString() + " GB @ " + Program.sysinfo.RAM_SPEED.ToString() + "MHz";
            }


            //GPU
            if (Program.sysinfo.nv)
            {
                LABEL_GPU_STRING.ForeColor = SysDraw.Color.LimeGreen;
                LABEL_GPU_STRING.Text = (Program.sysinfo.GPU_STRING).Trim() + "        Total VRAM " + (Program.sysinfo.GPU_VRAM).ToString() + " MB";
            }
            if (Program.sysinfo.amd)
            {
                LABEL_GPU_STRING.ForeColor = SysDraw.Color.Crimson;
                LABEL_GPU_STRING.Text = (Program.sysinfo.GPU_STRING).Trim() + "        Total VRAM " + (Program.sysinfo.GPU_VRAM).ToString() + " MB";
            }

            //Background Worker
            backgroundWorker1.RunWorkerAsync();
        }


        //BACKGROUND WORKER
        internal void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                foreach (var hardW in localhost.Hardware)
                {
                    hardW.Update(); //Costly operation

                    if (hardW.HardwareType == HardwareType.CPU)
                    {
                        foreach (var sensr in hardW.Sensors)
                        {
                            if (sensr.SensorType == SensorType.Temperature)
                            {
                                dsi.CPU_TEMP = (uint)sensr.Value.Value; //CPU TEMP
                            }
                            if (sensr.SensorType == SensorType.Load)
                            {
                                dsi.CPU_LOAD = (uint)sensr.Value; //CPU LOAD
                            }
                            Thread.Sleep(5);
                        }
                    }
                    foreach(var subhardW in hardW.SubHardware)
                    {
                        subhardW.Update(); //costly operation
                        foreach (var snsr in subhardW.Sensors)
                        {
                            if (snsr.SensorType == SensorType.Fan && snsr.Name.Equals("Fan #1", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.CPU_FAN = (uint)snsr.Value; //CPU FAN
                            }
                            Thread.Sleep(5);
                        }
                        Thread.Sleep(5);
                    }
                    if (hardW.HardwareType==HardwareType.GpuNvidia)
                    {
                        foreach(var snsr in hardW.Sensors)
                        {
                            if (snsr.SensorType == SensorType.Load && snsr.Name.Equals("GPU Core", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.GPU_LOAD = (uint)snsr.Value; //GPU LOAD
                            }
                            if (snsr.SensorType == SensorType.Temperature && snsr.Name.Equals("GPU Core", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.GPU_TEMP = (uint)snsr.Value; //GPU TEMP
                            }
                            if (snsr.SensorType == SensorType.Fan)
                            {
                                dsi.GPU_FAN = (uint)snsr.Value; //GPU FAN
                            }
                            if (snsr.SensorType == SensorType.SmallData && snsr.Name.Equals("GPU Memory Used", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.VRAM_USED = (uint)snsr.Value; //GPU VRAM USED
                                dsi.VRAM_FREE = _total_vram - dsi.VRAM_USED; //GPU VRAM FREE
                            }
                            Thread.Sleep(5);
                        }
                    }
                    if (hardW.HardwareType == HardwareType.GpuAti)
                    {
                        foreach (var snsr in hardW.Sensors)
                        {
                            if (snsr.SensorType == SensorType.Load && snsr.Name.Equals("GPU Core", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.GPU_LOAD = (uint)snsr.Value;
                            }
                            if (snsr.SensorType == SensorType.Temperature && snsr.Name.Equals("GPU Core", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.GPU_TEMP = (uint)snsr.Value;
                            }
                            if (snsr.SensorType == SensorType.Fan)
                            {
                                dsi.GPU_FAN = (uint)snsr.Value;
                            }
                            if (snsr.SensorType == SensorType.SmallData && snsr.Name.Equals("GPU Memory Used", StringComparison.OrdinalIgnoreCase))
                            {
                                dsi.VRAM_USED = (uint)snsr.Value;
                                dsi.VRAM_FREE = _total_vram - dsi.VRAM_USED;
                            }
                            Thread.Sleep(5);
                        }
                    }
                    foreach(var x in searcherRAM.Get())
                    {
                        dsi.RAM_FREE = (float.Parse(x["FreePhysicalMemory"].ToString()))/1024; //in MB
                        dsi.RAM_USED = _total_ram - dsi.RAM_FREE;
                        Thread.Sleep(1);
                    }

                    Thread.Sleep(5);
                }

                Thread.Sleep(700);
                backgroundWorker1.ReportProgress(1);
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //CPU
            SG_CPU_LOAD.Value = dsi.CPU_LOAD;
            SG_CPU_FAN.Value = dsi.CPU_FAN;
            SG_CPU_TEMP.Value = dsi.CPU_TEMP;

            //GPU
            SG_GPU_FAN.Value = dsi.GPU_FAN;
            SG_GPU_TEMP.Value = dsi.GPU_TEMP;
            SG_GPU_LOAD.Value = dsi.GPU_LOAD;
            PBAR_VRAM.Value = (int)dsi.VRAM_USED;
            LABEL_VRAM_USED.Text = "Using " + dsi.VRAM_USED.ToString() + " MB";
            LABEL_VRAM_FREE.Text = (_total_vram - dsi.VRAM_USED).ToString() + " MB Free";
            LABEL_VRAM_USED_PERC.Text = ((uint)((dsi.VRAM_USED / _total_vram) * 100)).ToString() + " %";

            //RAM
            PBAR_RAM.Value = (int)Math.Round((dsi.RAM_USED / _total_ram) * 100, 0);
            LABEL_RAM_USE_PERC.Text = (Math.Round(((dsi.RAM_USED / _total_ram) * 100),0)).ToString() + " %";
            if (dsi.RAM_FREE < 1024)
            {
                LABEL_RAM_FREE.Text = (dsi.RAM_FREE).ToString() + " MB Free";
                LABEL_RAM_USED.Text = "Using " + (_total_ram - (dsi.RAM_FREE)).ToString() + " MB";
            }
            else
            {
                LABEL_RAM_FREE.Text = (Math.Round(dsi.RAM_FREE/1024,1)).ToString() + " GB Free";
                LABEL_RAM_USED.Text = "Using " + Math.Round(((_total_ram / 1024) - (dsi.RAM_FREE / 1024)), 1).ToString() + " GB"; 
            }
        }










        //DRAG N MOVE
        protected override void WndProc(ref Message msg)
        {
            //https://docs.microsoft.com/en-us/windows/desktop/inputdev/wm-nchittest
            //0x1 = client area
            //0x2 = title bar (caption)
            switch (msg.Msg)
            {
                case 0x0084:
                    base.WndProc(ref msg);
                    if ((int)msg.Result == 0x1)
                    {
                        msg.Result = (IntPtr)0x2;
                        return;
                    }
                    break;
            }

            base.WndProc(ref msg);
        }


        private void LABEL_EXIT_Click(object sender, EventArgs e)
        {
            //Abort all threads
            backgroundWorker1.CancelAsync();
            //Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        private void Form_Closing (object sender, FormClosingEventArgs e)
        {
            //Abort all threads
            backgroundWorker1.CancelAsync();
            //Process.GetCurrentProcess().Kill();
            Application.Exit();
        }







//*******************************************************************************************************************//

        private void LABEL_GPU_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_RAM_Click(object sender, EventArgs e)
        {

        }

        private void SolidGauge1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void SG_CPU_LOAD_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void SG_CPU_TEMP_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void LABEL_CPU_VENDOR_Click(object sender, EventArgs e)
        {

        }

        private void SG_GPU_TEMP_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void SG_GPU_FAN_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void SG_GPU_LOAD_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void LABEL_CPU_STRING_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_CPU_CORES_THREADS_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_GPU_STRING_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_CPU_FAN_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_CPU_LOAD_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_CPU_RPM_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_CPU_PERC_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_CPU_DEG_C_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_GPU_LOAD_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_GPU_LOAD_PERC_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_GPU_RPM_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_GPU_FAN_SPEED_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_GPU_DEG_C_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_RAM_STRING_Click(object sender, EventArgs e)
        {

        }

        private void PBAR_VRAM_Click(object sender, EventArgs e)
        {

        }

        private void PBAR_RAM_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_VRAM_USED_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_VRAM_FREE_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_VRAM_USED_PERC_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_RAM_USED_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_RAM_USE_PERC_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_RAM_FREE_Click(object sender, EventArgs e)
        {

        }
    }
}
