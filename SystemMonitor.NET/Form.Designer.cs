namespace SystemMonitor.NET
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.LABEL_EXIT = new System.Windows.Forms.Label();
            this.LABEL_CPU = new System.Windows.Forms.Label();
            this.LABEL_GPU = new System.Windows.Forms.Label();
            this.LABEL_RAM = new System.Windows.Forms.Label();
            this.SG_CPU_FAN = new LiveCharts.WinForms.SolidGauge();
            this.SG_CPU_LOAD = new LiveCharts.WinForms.SolidGauge();
            this.SG_CPU_TEMP = new LiveCharts.WinForms.SolidGauge();
            this.SG_GPU_LOAD = new LiveCharts.WinForms.SolidGauge();
            this.SG_GPU_FAN = new LiveCharts.WinForms.SolidGauge();
            this.SG_GPU_TEMP = new LiveCharts.WinForms.SolidGauge();
            this.LABEL_CPU_VENDOR = new System.Windows.Forms.Label();
            this.LABEL_CPU_STRING = new System.Windows.Forms.Label();
            this.LABEL_CPU_CORES_THREADS = new System.Windows.Forms.Label();
            this.LABEL_GPU_STRING = new System.Windows.Forms.Label();
            this.LABEL_CPU_FAN = new System.Windows.Forms.Label();
            this.LABEL_CPU_LOAD = new System.Windows.Forms.Label();
            this.LABEL_CPU_TEMP = new System.Windows.Forms.Label();
            this.LABEL_CPU_RPM = new System.Windows.Forms.Label();
            this.LABEL_CPU_PERC = new System.Windows.Forms.Label();
            this.LABEL_CPU_DEG_C = new System.Windows.Forms.Label();
            this.LABEL_GPU_LOAD = new System.Windows.Forms.Label();
            this.LABEL_GPU_LOAD_PERC = new System.Windows.Forms.Label();
            this.LABEL_GPU_RPM = new System.Windows.Forms.Label();
            this.LABEL_GPU_FAN_SPEED = new System.Windows.Forms.Label();
            this.LABEL_GPU_DEG_C = new System.Windows.Forms.Label();
            this.LABEL_RAM_STRING = new System.Windows.Forms.Label();
            this.LABEl_GPU_TEMP = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PBAR_VRAM = new MetroFramework.Controls.MetroProgressBar();
            this.PBAR_RAM = new MetroFramework.Controls.MetroProgressBar();
            this.LABEL_VRAM_USED = new System.Windows.Forms.Label();
            this.LABEL_VRAM_FREE = new System.Windows.Forms.Label();
            this.LABEL_VRAM_USED_PERC = new System.Windows.Forms.Label();
            this.LABEL_RAM_USED = new System.Windows.Forms.Label();
            this.LABEL_RAM_USE_PERC = new System.Windows.Forms.Label();
            this.LABEL_RAM_FREE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LABEL_EXIT
            // 
            this.LABEL_EXIT.AutoSize = true;
            this.LABEL_EXIT.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_EXIT.ForeColor = System.Drawing.Color.Crimson;
            this.LABEL_EXIT.Location = new System.Drawing.Point(1152, -2);
            this.LABEL_EXIT.Name = "LABEL_EXIT";
            this.LABEL_EXIT.Size = new System.Drawing.Size(45, 20);
            this.LABEL_EXIT.TabIndex = 0;
            this.LABEL_EXIT.Text = "EXIT";
            this.LABEL_EXIT.Click += new System.EventHandler(this.LABEL_EXIT_Click);
            // 
            // LABEL_CPU
            // 
            this.LABEL_CPU.AutoSize = true;
            this.LABEL_CPU.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU.ForeColor = System.Drawing.Color.HotPink;
            this.LABEL_CPU.Location = new System.Drawing.Point(12, 17);
            this.LABEL_CPU.Name = "LABEL_CPU";
            this.LABEL_CPU.Size = new System.Drawing.Size(91, 52);
            this.LABEL_CPU.TabIndex = 2;
            this.LABEL_CPU.Text = "CPU";
            // 
            // LABEL_GPU
            // 
            this.LABEL_GPU.AutoSize = true;
            this.LABEL_GPU.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_GPU.ForeColor = System.Drawing.Color.HotPink;
            this.LABEL_GPU.Location = new System.Drawing.Point(12, 230);
            this.LABEL_GPU.Name = "LABEL_GPU";
            this.LABEL_GPU.Size = new System.Drawing.Size(94, 52);
            this.LABEL_GPU.TabIndex = 3;
            this.LABEL_GPU.Text = "GPU";
            this.LABEL_GPU.Click += new System.EventHandler(this.LABEL_GPU_Click);
            // 
            // LABEL_RAM
            // 
            this.LABEL_RAM.AutoSize = true;
            this.LABEL_RAM.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_RAM.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_RAM.ForeColor = System.Drawing.Color.HotPink;
            this.LABEL_RAM.Location = new System.Drawing.Point(12, 394);
            this.LABEL_RAM.Name = "LABEL_RAM";
            this.LABEL_RAM.Size = new System.Drawing.Size(104, 52);
            this.LABEL_RAM.TabIndex = 4;
            this.LABEL_RAM.Text = "RAM";
            this.LABEL_RAM.Click += new System.EventHandler(this.LABEL_RAM_Click);
            // 
            // SG_CPU_FAN
            // 
            this.SG_CPU_FAN.BackColor = System.Drawing.Color.Transparent;
            this.SG_CPU_FAN.Location = new System.Drawing.Point(102, 89);
            this.SG_CPU_FAN.Name = "SG_CPU_FAN";
            this.SG_CPU_FAN.Size = new System.Drawing.Size(200, 100);
            this.SG_CPU_FAN.TabIndex = 5;
            this.SG_CPU_FAN.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SolidGauge1_ChildChanged);
            // 
            // SG_CPU_LOAD
            // 
            this.SG_CPU_LOAD.BackColor = System.Drawing.Color.Transparent;
            this.SG_CPU_LOAD.Location = new System.Drawing.Point(409, 89);
            this.SG_CPU_LOAD.Name = "SG_CPU_LOAD";
            this.SG_CPU_LOAD.Size = new System.Drawing.Size(200, 100);
            this.SG_CPU_LOAD.TabIndex = 6;
            this.SG_CPU_LOAD.Text = "solidGauge2";
            this.SG_CPU_LOAD.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SG_CPU_LOAD_ChildChanged);
            // 
            // SG_CPU_TEMP
            // 
            this.SG_CPU_TEMP.BackColor = System.Drawing.Color.Transparent;
            this.SG_CPU_TEMP.Location = new System.Drawing.Point(709, 89);
            this.SG_CPU_TEMP.Name = "SG_CPU_TEMP";
            this.SG_CPU_TEMP.Size = new System.Drawing.Size(200, 100);
            this.SG_CPU_TEMP.TabIndex = 7;
            this.SG_CPU_TEMP.Text = "solidGauge3";
            this.SG_CPU_TEMP.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SG_CPU_TEMP_ChildChanged);
            // 
            // SG_GPU_LOAD
            // 
            this.SG_GPU_LOAD.BackColor = System.Drawing.Color.Transparent;
            this.SG_GPU_LOAD.Location = new System.Drawing.Point(102, 277);
            this.SG_GPU_LOAD.Name = "SG_GPU_LOAD";
            this.SG_GPU_LOAD.Size = new System.Drawing.Size(175, 89);
            this.SG_GPU_LOAD.TabIndex = 8;
            this.SG_GPU_LOAD.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SG_GPU_LOAD_ChildChanged);
            // 
            // SG_GPU_FAN
            // 
            this.SG_GPU_FAN.BackColor = System.Drawing.Color.Transparent;
            this.SG_GPU_FAN.Location = new System.Drawing.Point(311, 277);
            this.SG_GPU_FAN.Name = "SG_GPU_FAN";
            this.SG_GPU_FAN.Size = new System.Drawing.Size(175, 89);
            this.SG_GPU_FAN.TabIndex = 9;
            this.SG_GPU_FAN.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SG_GPU_FAN_ChildChanged);
            // 
            // SG_GPU_TEMP
            // 
            this.SG_GPU_TEMP.BackColor = System.Drawing.Color.Transparent;
            this.SG_GPU_TEMP.Location = new System.Drawing.Point(527, 277);
            this.SG_GPU_TEMP.Name = "SG_GPU_TEMP";
            this.SG_GPU_TEMP.Size = new System.Drawing.Size(175, 89);
            this.SG_GPU_TEMP.TabIndex = 10;
            this.SG_GPU_TEMP.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.SG_GPU_TEMP_ChildChanged);
            // 
            // LABEL_CPU_VENDOR
            // 
            this.LABEL_CPU_VENDOR.AutoSize = true;
            this.LABEL_CPU_VENDOR.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_VENDOR.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_VENDOR.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LABEL_CPU_VENDOR.Location = new System.Drawing.Point(912, 64);
            this.LABEL_CPU_VENDOR.Name = "LABEL_CPU_VENDOR";
            this.LABEL_CPU_VENDOR.Size = new System.Drawing.Size(285, 52);
            this.LABEL_CPU_VENDOR.TabIndex = 11;
            this.LABEL_CPU_VENDOR.Text = "PLACEHOLDER";
            this.LABEL_CPU_VENDOR.Click += new System.EventHandler(this.LABEL_CPU_VENDOR_Click);
            // 
            // LABEL_CPU_STRING
            // 
            this.LABEL_CPU_STRING.AutoSize = true;
            this.LABEL_CPU_STRING.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_STRING.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_STRING.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LABEL_CPU_STRING.Location = new System.Drawing.Point(109, 23);
            this.LABEL_CPU_STRING.Name = "LABEL_CPU_STRING";
            this.LABEL_CPU_STRING.Size = new System.Drawing.Size(174, 33);
            this.LABEL_CPU_STRING.TabIndex = 12;
            this.LABEL_CPU_STRING.Text = "PLACEHOLDER";
            this.LABEL_CPU_STRING.Click += new System.EventHandler(this.LABEL_CPU_STRING_Click);
            // 
            // LABEL_CPU_CORES_THREADS
            // 
            this.LABEL_CPU_CORES_THREADS.AutoSize = true;
            this.LABEL_CPU_CORES_THREADS.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_CORES_THREADS.Font = new System.Drawing.Font("Calibri", 18F);
            this.LABEL_CPU_CORES_THREADS.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LABEL_CPU_CORES_THREADS.Location = new System.Drawing.Point(109, 56);
            this.LABEL_CPU_CORES_THREADS.Name = "LABEL_CPU_CORES_THREADS";
            this.LABEL_CPU_CORES_THREADS.Size = new System.Drawing.Size(155, 29);
            this.LABEL_CPU_CORES_THREADS.TabIndex = 13;
            this.LABEL_CPU_CORES_THREADS.Text = "PLACEHOLDER";
            this.LABEL_CPU_CORES_THREADS.Click += new System.EventHandler(this.LABEL_CPU_CORES_THREADS_Click);
            // 
            // LABEL_GPU_STRING
            // 
            this.LABEL_GPU_STRING.AutoSize = true;
            this.LABEL_GPU_STRING.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU_STRING.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_GPU_STRING.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LABEL_GPU_STRING.Location = new System.Drawing.Point(109, 243);
            this.LABEL_GPU_STRING.Name = "LABEL_GPU_STRING";
            this.LABEL_GPU_STRING.Size = new System.Drawing.Size(91, 33);
            this.LABEL_GPU_STRING.TabIndex = 14;
            this.LABEL_GPU_STRING.Text = "ERROR";
            this.LABEL_GPU_STRING.Click += new System.EventHandler(this.LABEL_GPU_STRING_Click);
            // 
            // LABEL_CPU_FAN
            // 
            this.LABEL_CPU_FAN.AutoSize = true;
            this.LABEL_CPU_FAN.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_FAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_FAN.ForeColor = System.Drawing.Color.Aqua;
            this.LABEL_CPU_FAN.Location = new System.Drawing.Point(153, 189);
            this.LABEL_CPU_FAN.Name = "LABEL_CPU_FAN";
            this.LABEL_CPU_FAN.Size = new System.Drawing.Size(106, 16);
            this.LABEL_CPU_FAN.TabIndex = 15;
            this.LABEL_CPU_FAN.Text = "CPU Fan Speed";
            this.LABEL_CPU_FAN.Click += new System.EventHandler(this.LABEL_CPU_FAN_Click);
            // 
            // LABEL_CPU_LOAD
            // 
            this.LABEL_CPU_LOAD.AutoSize = true;
            this.LABEL_CPU_LOAD.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_LOAD.ForeColor = System.Drawing.Color.Aqua;
            this.LABEL_CPU_LOAD.Location = new System.Drawing.Point(476, 189);
            this.LABEL_CPU_LOAD.Name = "LABEL_CPU_LOAD";
            this.LABEL_CPU_LOAD.Size = new System.Drawing.Size(70, 16);
            this.LABEL_CPU_LOAD.TabIndex = 16;
            this.LABEL_CPU_LOAD.Text = "CPU Load";
            this.LABEL_CPU_LOAD.Click += new System.EventHandler(this.LABEL_CPU_LOAD_Click);
            // 
            // LABEL_CPU_TEMP
            // 
            this.LABEL_CPU_TEMP.AutoSize = true;
            this.LABEL_CPU_TEMP.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_TEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_TEMP.ForeColor = System.Drawing.Color.Aqua;
            this.LABEL_CPU_TEMP.Location = new System.Drawing.Point(752, 192);
            this.LABEL_CPU_TEMP.Name = "LABEL_CPU_TEMP";
            this.LABEL_CPU_TEMP.Size = new System.Drawing.Size(117, 16);
            this.LABEL_CPU_TEMP.TabIndex = 17;
            this.LABEL_CPU_TEMP.Text = "CPU Temperature";
            // 
            // LABEL_CPU_RPM
            // 
            this.LABEL_CPU_RPM.AutoSize = true;
            this.LABEL_CPU_RPM.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_RPM.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LABEL_CPU_RPM.Location = new System.Drawing.Point(230, 179);
            this.LABEL_CPU_RPM.Name = "LABEL_CPU_RPM";
            this.LABEL_CPU_RPM.Size = new System.Drawing.Size(27, 12);
            this.LABEL_CPU_RPM.TabIndex = 18;
            this.LABEL_CPU_RPM.Text = "RPM";
            this.LABEL_CPU_RPM.Click += new System.EventHandler(this.LABEL_CPU_RPM_Click);
            // 
            // LABEL_CPU_PERC
            // 
            this.LABEL_CPU_PERC.AutoSize = true;
            this.LABEL_CPU_PERC.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_PERC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_PERC.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LABEL_CPU_PERC.Location = new System.Drawing.Point(533, 171);
            this.LABEL_CPU_PERC.Name = "LABEL_CPU_PERC";
            this.LABEL_CPU_PERC.Size = new System.Drawing.Size(20, 16);
            this.LABEL_CPU_PERC.TabIndex = 19;
            this.LABEL_CPU_PERC.Text = "%";
            this.LABEL_CPU_PERC.Click += new System.EventHandler(this.LABEL_CPU_PERC_Click);
            // 
            // LABEL_CPU_DEG_C
            // 
            this.LABEL_CPU_DEG_C.AutoSize = true;
            this.LABEL_CPU_DEG_C.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CPU_DEG_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPU_DEG_C.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LABEL_CPU_DEG_C.Location = new System.Drawing.Point(836, 159);
            this.LABEL_CPU_DEG_C.Name = "LABEL_CPU_DEG_C";
            this.LABEL_CPU_DEG_C.Size = new System.Drawing.Size(20, 15);
            this.LABEL_CPU_DEG_C.TabIndex = 20;
            this.LABEL_CPU_DEG_C.Text = "°C";
            this.LABEL_CPU_DEG_C.Click += new System.EventHandler(this.LABEL_CPU_DEG_C_Click);
            // 
            // LABEL_GPU_LOAD
            // 
            this.LABEL_GPU_LOAD.AutoSize = true;
            this.LABEL_GPU_LOAD.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_GPU_LOAD.ForeColor = System.Drawing.Color.Aqua;
            this.LABEL_GPU_LOAD.Location = new System.Drawing.Point(153, 366);
            this.LABEL_GPU_LOAD.Name = "LABEL_GPU_LOAD";
            this.LABEL_GPU_LOAD.Size = new System.Drawing.Size(71, 16);
            this.LABEL_GPU_LOAD.TabIndex = 21;
            this.LABEL_GPU_LOAD.Text = "GPU Load";
            this.LABEL_GPU_LOAD.Click += new System.EventHandler(this.LABEL_GPU_LOAD_Click);
            // 
            // LABEL_GPU_LOAD_PERC
            // 
            this.LABEL_GPU_LOAD_PERC.AutoSize = true;
            this.LABEL_GPU_LOAD_PERC.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU_LOAD_PERC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_GPU_LOAD_PERC.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LABEL_GPU_LOAD_PERC.Location = new System.Drawing.Point(210, 347);
            this.LABEL_GPU_LOAD_PERC.Name = "LABEL_GPU_LOAD_PERC";
            this.LABEL_GPU_LOAD_PERC.Size = new System.Drawing.Size(20, 16);
            this.LABEL_GPU_LOAD_PERC.TabIndex = 22;
            this.LABEL_GPU_LOAD_PERC.Text = "%";
            this.LABEL_GPU_LOAD_PERC.Click += new System.EventHandler(this.LABEL_GPU_LOAD_PERC_Click);
            // 
            // LABEL_GPU_RPM
            // 
            this.LABEL_GPU_RPM.AutoSize = true;
            this.LABEL_GPU_RPM.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LABEL_GPU_RPM.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LABEL_GPU_RPM.Location = new System.Drawing.Point(422, 355);
            this.LABEL_GPU_RPM.Name = "LABEL_GPU_RPM";
            this.LABEL_GPU_RPM.Size = new System.Drawing.Size(27, 12);
            this.LABEL_GPU_RPM.TabIndex = 23;
            this.LABEL_GPU_RPM.Text = "RPM";
            this.LABEL_GPU_RPM.Click += new System.EventHandler(this.LABEL_GPU_RPM_Click);
            // 
            // LABEL_GPU_FAN_SPEED
            // 
            this.LABEL_GPU_FAN_SPEED.AutoSize = true;
            this.LABEL_GPU_FAN_SPEED.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU_FAN_SPEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_GPU_FAN_SPEED.ForeColor = System.Drawing.Color.Aqua;
            this.LABEL_GPU_FAN_SPEED.Location = new System.Drawing.Point(344, 365);
            this.LABEL_GPU_FAN_SPEED.Name = "LABEL_GPU_FAN_SPEED";
            this.LABEL_GPU_FAN_SPEED.Size = new System.Drawing.Size(107, 16);
            this.LABEL_GPU_FAN_SPEED.TabIndex = 24;
            this.LABEL_GPU_FAN_SPEED.Text = "GPU Fan Speed";
            this.LABEL_GPU_FAN_SPEED.Click += new System.EventHandler(this.LABEL_GPU_FAN_SPEED_Click);
            // 
            // LABEL_GPU_DEG_C
            // 
            this.LABEL_GPU_DEG_C.AutoSize = true;
            this.LABEL_GPU_DEG_C.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GPU_DEG_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_GPU_DEG_C.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LABEL_GPU_DEG_C.Location = new System.Drawing.Point(637, 340);
            this.LABEL_GPU_DEG_C.Name = "LABEL_GPU_DEG_C";
            this.LABEL_GPU_DEG_C.Size = new System.Drawing.Size(20, 15);
            this.LABEL_GPU_DEG_C.TabIndex = 25;
            this.LABEL_GPU_DEG_C.Text = "°C";
            this.LABEL_GPU_DEG_C.Click += new System.EventHandler(this.LABEL_GPU_DEG_C_Click);
            // 
            // LABEL_RAM_STRING
            // 
            this.LABEL_RAM_STRING.AutoSize = true;
            this.LABEL_RAM_STRING.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_RAM_STRING.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_RAM_STRING.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LABEL_RAM_STRING.Location = new System.Drawing.Point(109, 413);
            this.LABEL_RAM_STRING.Name = "LABEL_RAM_STRING";
            this.LABEL_RAM_STRING.Size = new System.Drawing.Size(174, 33);
            this.LABEL_RAM_STRING.TabIndex = 26;
            this.LABEL_RAM_STRING.Text = "PLACEHOLDER";
            this.LABEL_RAM_STRING.Click += new System.EventHandler(this.LABEL_RAM_STRING_Click);
            // 
            // LABEl_GPU_TEMP
            // 
            this.LABEl_GPU_TEMP.AutoSize = true;
            this.LABEl_GPU_TEMP.BackColor = System.Drawing.Color.Transparent;
            this.LABEl_GPU_TEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEl_GPU_TEMP.ForeColor = System.Drawing.Color.Aqua;
            this.LABEl_GPU_TEMP.Location = new System.Drawing.Point(557, 365);
            this.LABEl_GPU_TEMP.Name = "LABEl_GPU_TEMP";
            this.LABEl_GPU_TEMP.Size = new System.Drawing.Size(118, 16);
            this.LABEl_GPU_TEMP.TabIndex = 27;
            this.LABEl_GPU_TEMP.Text = "GPU Temperature";
            // 
            // PBAR_VRAM
            // 
            this.PBAR_VRAM.Location = new System.Drawing.Point(734, 354);
            this.PBAR_VRAM.Name = "PBAR_VRAM";
            this.PBAR_VRAM.Size = new System.Drawing.Size(445, 11);
            this.PBAR_VRAM.Style = MetroFramework.MetroColorStyle.Pink;
            this.PBAR_VRAM.TabIndex = 28;
            this.PBAR_VRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PBAR_VRAM.Value = 10;
            this.PBAR_VRAM.Click += new System.EventHandler(this.PBAR_VRAM_Click);
            // 
            // PBAR_RAM
            // 
            this.PBAR_RAM.Location = new System.Drawing.Point(417, 468);
            this.PBAR_RAM.Name = "PBAR_RAM";
            this.PBAR_RAM.Size = new System.Drawing.Size(762, 10);
            this.PBAR_RAM.Style = MetroFramework.MetroColorStyle.Pink;
            this.PBAR_RAM.TabIndex = 29;
            this.PBAR_RAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PBAR_RAM.Value = 10;
            this.PBAR_RAM.Click += new System.EventHandler(this.PBAR_RAM_Click);
            // 
            // LABEL_VRAM_USED
            // 
            this.LABEL_VRAM_USED.AutoSize = true;
            this.LABEL_VRAM_USED.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_VRAM_USED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_VRAM_USED.ForeColor = System.Drawing.Color.Turquoise;
            this.LABEL_VRAM_USED.Location = new System.Drawing.Point(738, 331);
            this.LABEL_VRAM_USED.Name = "LABEL_VRAM_USED";
            this.LABEL_VRAM_USED.Size = new System.Drawing.Size(129, 20);
            this.LABEL_VRAM_USED.TabIndex = 30;
            this.LABEL_VRAM_USED.Text = "PLACEHOLDER";
            this.LABEL_VRAM_USED.Click += new System.EventHandler(this.LABEL_VRAM_USED_Click);
            // 
            // LABEL_VRAM_FREE
            // 
            this.LABEL_VRAM_FREE.AutoSize = true;
            this.LABEL_VRAM_FREE.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_VRAM_FREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_VRAM_FREE.ForeColor = System.Drawing.Color.Turquoise;
            this.LABEL_VRAM_FREE.Location = new System.Drawing.Point(1058, 331);
            this.LABEL_VRAM_FREE.Name = "LABEL_VRAM_FREE";
            this.LABEL_VRAM_FREE.Size = new System.Drawing.Size(129, 20);
            this.LABEL_VRAM_FREE.TabIndex = 31;
            this.LABEL_VRAM_FREE.Text = "PLACEHOLDER";
            this.LABEL_VRAM_FREE.Click += new System.EventHandler(this.LABEL_VRAM_FREE_Click);
            // 
            // LABEL_VRAM_USED_PERC
            // 
            this.LABEL_VRAM_USED_PERC.AutoSize = true;
            this.LABEL_VRAM_USED_PERC.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_VRAM_USED_PERC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_VRAM_USED_PERC.ForeColor = System.Drawing.Color.Turquoise;
            this.LABEL_VRAM_USED_PERC.Location = new System.Drawing.Point(923, 331);
            this.LABEL_VRAM_USED_PERC.Name = "LABEL_VRAM_USED_PERC";
            this.LABEL_VRAM_USED_PERC.Size = new System.Drawing.Size(129, 20);
            this.LABEL_VRAM_USED_PERC.TabIndex = 32;
            this.LABEL_VRAM_USED_PERC.Text = "PLACEHOLDER";
            this.LABEL_VRAM_USED_PERC.Click += new System.EventHandler(this.LABEL_VRAM_USED_PERC_Click);
            // 
            // LABEL_RAM_USED
            // 
            this.LABEL_RAM_USED.AutoSize = true;
            this.LABEL_RAM_USED.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_RAM_USED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_RAM_USED.ForeColor = System.Drawing.Color.Turquoise;
            this.LABEL_RAM_USED.Location = new System.Drawing.Point(430, 444);
            this.LABEL_RAM_USED.Name = "LABEL_RAM_USED";
            this.LABEL_RAM_USED.Size = new System.Drawing.Size(129, 20);
            this.LABEL_RAM_USED.TabIndex = 33;
            this.LABEL_RAM_USED.Text = "PLACEHOLDER";
            this.LABEL_RAM_USED.Click += new System.EventHandler(this.LABEL_RAM_USED_Click);
            // 
            // LABEL_RAM_USE_PERC
            // 
            this.LABEL_RAM_USE_PERC.AutoSize = true;
            this.LABEL_RAM_USE_PERC.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_RAM_USE_PERC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_RAM_USE_PERC.ForeColor = System.Drawing.Color.Turquoise;
            this.LABEL_RAM_USE_PERC.Location = new System.Drawing.Point(760, 444);
            this.LABEL_RAM_USE_PERC.Name = "LABEL_RAM_USE_PERC";
            this.LABEL_RAM_USE_PERC.Size = new System.Drawing.Size(245, 20);
            this.LABEL_RAM_USE_PERC.TabIndex = 34;
            this.LABEL_RAM_USE_PERC.Text = "PLEASE WAIT FOR IT TO LOAD";
            this.LABEL_RAM_USE_PERC.Click += new System.EventHandler(this.LABEL_RAM_USE_PERC_Click);
            // 
            // LABEL_RAM_FREE
            // 
            this.LABEL_RAM_FREE.AutoSize = true;
            this.LABEL_RAM_FREE.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_RAM_FREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_RAM_FREE.ForeColor = System.Drawing.Color.Turquoise;
            this.LABEL_RAM_FREE.Location = new System.Drawing.Point(1061, 444);
            this.LABEL_RAM_FREE.Name = "LABEL_RAM_FREE";
            this.LABEL_RAM_FREE.Size = new System.Drawing.Size(129, 20);
            this.LABEL_RAM_FREE.TabIndex = 35;
            this.LABEL_RAM_FREE.Text = "PLACEHOLDER";
            this.LABEL_RAM_FREE.Click += new System.EventHandler(this.LABEL_RAM_FREE_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.LABEL_RAM_FREE);
            this.Controls.Add(this.LABEL_RAM_USE_PERC);
            this.Controls.Add(this.LABEL_RAM_USED);
            this.Controls.Add(this.LABEL_VRAM_USED_PERC);
            this.Controls.Add(this.LABEL_VRAM_FREE);
            this.Controls.Add(this.LABEL_VRAM_USED);
            this.Controls.Add(this.PBAR_RAM);
            this.Controls.Add(this.PBAR_VRAM);
            this.Controls.Add(this.LABEl_GPU_TEMP);
            this.Controls.Add(this.LABEL_RAM_STRING);
            this.Controls.Add(this.LABEL_GPU_DEG_C);
            this.Controls.Add(this.LABEL_GPU_FAN_SPEED);
            this.Controls.Add(this.LABEL_GPU_RPM);
            this.Controls.Add(this.LABEL_GPU_LOAD_PERC);
            this.Controls.Add(this.LABEL_GPU_LOAD);
            this.Controls.Add(this.LABEL_CPU_DEG_C);
            this.Controls.Add(this.LABEL_CPU_PERC);
            this.Controls.Add(this.LABEL_CPU_RPM);
            this.Controls.Add(this.LABEL_CPU_TEMP);
            this.Controls.Add(this.LABEL_CPU_LOAD);
            this.Controls.Add(this.LABEL_CPU_FAN);
            this.Controls.Add(this.LABEL_GPU_STRING);
            this.Controls.Add(this.LABEL_CPU_CORES_THREADS);
            this.Controls.Add(this.LABEL_CPU_STRING);
            this.Controls.Add(this.LABEL_CPU_VENDOR);
            this.Controls.Add(this.SG_GPU_TEMP);
            this.Controls.Add(this.SG_GPU_FAN);
            this.Controls.Add(this.SG_GPU_LOAD);
            this.Controls.Add(this.SG_CPU_TEMP);
            this.Controls.Add(this.SG_CPU_LOAD);
            this.Controls.Add(this.SG_CPU_FAN);
            this.Controls.Add(this.LABEL_RAM);
            this.Controls.Add(this.LABEL_GPU);
            this.Controls.Add(this.LABEL_CPU);
            this.Controls.Add(this.LABEL_EXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysMon.NET";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_EXIT;
        private System.Windows.Forms.Label LABEL_CPU;
        private System.Windows.Forms.Label LABEL_GPU;
        private System.Windows.Forms.Label LABEL_RAM;
        private LiveCharts.WinForms.SolidGauge SG_CPU_FAN;
        private LiveCharts.WinForms.SolidGauge SG_CPU_LOAD;
        private LiveCharts.WinForms.SolidGauge SG_CPU_TEMP;
        private LiveCharts.WinForms.SolidGauge SG_GPU_LOAD;
        private LiveCharts.WinForms.SolidGauge SG_GPU_FAN;
        private LiveCharts.WinForms.SolidGauge SG_GPU_TEMP;
        private System.Windows.Forms.Label LABEL_CPU_VENDOR;
        private System.Windows.Forms.Label LABEL_CPU_STRING;
        private System.Windows.Forms.Label LABEL_CPU_CORES_THREADS;
        private System.Windows.Forms.Label LABEL_GPU_STRING;
        private System.Windows.Forms.Label LABEL_CPU_FAN;
        private System.Windows.Forms.Label LABEL_CPU_LOAD;
        private System.Windows.Forms.Label LABEL_CPU_TEMP;
        private System.Windows.Forms.Label LABEL_CPU_RPM;
        private System.Windows.Forms.Label LABEL_CPU_PERC;
        private System.Windows.Forms.Label LABEL_CPU_DEG_C;
        private System.Windows.Forms.Label LABEL_GPU_LOAD;
        private System.Windows.Forms.Label LABEL_GPU_LOAD_PERC;
        private System.Windows.Forms.Label LABEL_GPU_RPM;
        private System.Windows.Forms.Label LABEL_GPU_FAN_SPEED;
        private System.Windows.Forms.Label LABEL_GPU_DEG_C;
        private System.Windows.Forms.Label LABEL_RAM_STRING;
        private System.Windows.Forms.Label LABEl_GPU_TEMP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroProgressBar PBAR_VRAM;
        private MetroFramework.Controls.MetroProgressBar PBAR_RAM;
        private System.Windows.Forms.Label LABEL_VRAM_USED;
        private System.Windows.Forms.Label LABEL_VRAM_FREE;
        private System.Windows.Forms.Label LABEL_VRAM_USED_PERC;
        private System.Windows.Forms.Label LABEL_RAM_USED;
        private System.Windows.Forms.Label LABEL_RAM_USE_PERC;
        private System.Windows.Forms.Label LABEL_RAM_FREE;
    }
}

