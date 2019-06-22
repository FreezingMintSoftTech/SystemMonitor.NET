using System;
using System.Management;
using System.Windows.Forms;

using OpenHardwareMonitor.Hardware;

namespace SystemMonitor.NET
{
    public struct SYS_INFO
    {
        //CPU
        public string CPU_STRING;
        public uint CPU_CORES;
        public uint CPU_THREADS;
        public double CPU_MAX_SPEED;
        public string CPU_VENDOR;
        public string MOBO_MODEL;

        //RAM
        public ulong TOTAL_RAM;
        public string RAM_SPEED;

        //GPU
        public string GPU_STRING;
        public uint GPU_VRAM;
        public bool nv;
        public bool amd;
    };

    public class Program
    {
        //Data Definitions
            //WMI
                //Scope
        internal static ManagementScope mScope = new ManagementScope("\\\\localhost\\root\\CIMV2");

                //CPU
        internal static ObjectQuery qCPU = new ObjectQuery("Select * from Win32_Processor");
        internal static ManagementObjectSearcher searcherCPU = new ManagementObjectSearcher(mScope, qCPU);
        internal static ObjectQuery qMB = new ObjectQuery("Select Product from Win32_BaseBoard");
        internal static ManagementObjectSearcher searcherMB = new ManagementObjectSearcher(mScope, qMB);
                //RAM
        internal static ObjectQuery qRAM = new ObjectQuery("Select * from Win32_PhysicalMemory"); //RAM data WQL query string
        internal static ManagementObjectSearcher searcherRAM = new ManagementObjectSearcher(mScope, qRAM);
                //NORMAL
        public static Program prog = new Program();
        public static SYS_INFO sysinfo;
            //OpenHardwareMonitor
        internal static Computer localhost = new Computer();


        /*       E    N    T    R    Y       */

        [STAThread]
        static void Main()
        {
                //prep
            mScope.Connect();
            localhost.CPUEnabled = true;
            localhost.GPUEnabled = true;
            localhost.MainboardEnabled = true;
            localhost.Open();
            GET_GPU_STATICS();
            GET_RAM_STATICS();
            GET_MB_VENDOR();
            GET_CPU_STATICS();

                //Run the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI());
        }



            //CPU STATICS
        internal static void GET_CPU_STATICS()
        {
            foreach (var x in searcherCPU.Get())
            {
                sysinfo.CPU_STRING = x["Name"].ToString();
                sysinfo.CPU_MAX_SPEED = Double.Parse(x["MaxClockSpeed"].ToString()) / 1000;
                sysinfo.CPU_CORES = uint.Parse(x["NumberOfCores"].ToString());
                sysinfo.CPU_THREADS = uint.Parse(x["NumberOfLogicalProcessors"].ToString()) - sysinfo.CPU_CORES;
                sysinfo.CPU_VENDOR = x["Manufacturer"].ToString();
            }
        }
        internal static void GET_MB_VENDOR()
        {
            foreach (var m in searcherMB.Get())
            {
                sysinfo.MOBO_MODEL = m["Product"].ToString();

            }
        }


            //RAM STATICS
        internal static void GET_RAM_STATICS()
        {
            foreach (var r in searcherRAM.Get())
            {
                sysinfo.TOTAL_RAM += ulong.Parse(r["Capacity"].ToString());
                sysinfo.RAM_SPEED = r["Speed"].ToString();
            }
        }


            //GPU STATICS
        internal static void GET_GPU_STATICS()
        {
            foreach (var hard in localhost.Hardware)
            {
                if (hard.HardwareType == HardwareType.GpuNvidia)
                {
                    hard.Update();

                    sysinfo.GPU_STRING = hard.Name;
                    sysinfo.nv = true;
                    sysinfo.amd = false;

                    foreach (var snsr in hard.Sensors)
                    {
                        if (snsr.SensorType == SensorType.SmallData && snsr.Name.Equals("GPU Memory Total", StringComparison.OrdinalIgnoreCase))
                        {
                            sysinfo.GPU_VRAM = (uint)snsr.Value;
                        }
                    }
                }
                if (hard.HardwareType == HardwareType.GpuAti)
                {
                    hard.Update();

                    sysinfo.GPU_STRING = hard.Name;
                    sysinfo.nv = false;
                    sysinfo.amd = true;

                    foreach (var snsr in hard.Sensors)
                    {
                        if (snsr.SensorType == SensorType.SmallData && snsr.Name.Equals("GPU Memory Total", StringComparison.OrdinalIgnoreCase))
                        {
                            sysinfo.GPU_VRAM = (uint)snsr.Value;
                        }
                    }
                }
            }
        }
    }

}
