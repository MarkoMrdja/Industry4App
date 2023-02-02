
namespace GanttChart
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.pnlSide = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.txtCurrDateEnd = new System.Windows.Forms.Label();
            this.txtCurrDateStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.dtpStart = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.btnTimePeriod = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnStanica4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnStanica3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnStanica2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnStanica1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pnlTop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.pnlWorking = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.station11 = new Station1();
            this.station41 = new Station4();
            this.station31 = new Station3();
            this.station21 = new Station2();
            this.pnlSide.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlWorking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.White;
            this.pnlSide.Controls.Add(this.txtCurrDateEnd);
            this.pnlSide.Controls.Add(this.txtCurrDateStart);
            this.pnlSide.Controls.Add(this.label2);
            this.pnlSide.Controls.Add(this.label1);
            this.pnlSide.Controls.Add(this.dtpEnd);
            this.pnlSide.Controls.Add(this.dtpStart);
            this.pnlSide.Controls.Add(this.btnTimePeriod);
            this.pnlSide.Controls.Add(this.btnStanica4);
            this.pnlSide.Controls.Add(this.btnStanica3);
            this.pnlSide.Controls.Add(this.btnStanica2);
            this.pnlSide.Controls.Add(this.btnStanica1);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.ShadowDecoration.Depth = 5;
            this.pnlSide.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.pnlSide.Size = new System.Drawing.Size(190, 800);
            this.pnlSide.TabIndex = 0;
            // 
            // txtCurrDateEnd
            // 
            this.txtCurrDateEnd.AutoSize = true;
            this.txtCurrDateEnd.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Italic);
            this.txtCurrDateEnd.Location = new System.Drawing.Point(50, 508);
            this.txtCurrDateEnd.Name = "txtCurrDateEnd";
            this.txtCurrDateEnd.Size = new System.Drawing.Size(46, 20);
            this.txtCurrDateEnd.TabIndex = 8;
            this.txtCurrDateEnd.Text = "time2";
            this.txtCurrDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrDateStart
            // 
            this.txtCurrDateStart.AutoSize = true;
            this.txtCurrDateStart.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Italic);
            this.txtCurrDateStart.Location = new System.Drawing.Point(50, 392);
            this.txtCurrDateStart.Name = "txtCurrDateStart";
            this.txtCurrDateStart.Size = new System.Drawing.Size(46, 20);
            this.txtCurrDateStart.TabIndex = 7;
            this.txtCurrDateStart.Text = "time1";
            this.txtCurrDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.label2.Location = new System.Drawing.Point(30, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Krajnje vreme:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.label1.Location = new System.Drawing.Point(30, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Početno vreme:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = true;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(148)))), ((int)(((byte)(232)))));
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(12, 469);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(165, 36);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.Value = new System.DateTime(2023, 1, 28, 11, 33, 33, 459);
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(12, 353);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(165, 36);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.Value = new System.DateTime(2023, 1, 28, 11, 33, 33, 459);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // btnTimePeriod
            // 
            this.btnTimePeriod.BackColor = System.Drawing.Color.Transparent;
            this.btnTimePeriod.BorderRadius = 3;
            this.btnTimePeriod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimePeriod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimePeriod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimePeriod.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimePeriod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimePeriod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTimePeriod.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(225)))));
            this.btnTimePeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimePeriod.ForeColor = System.Drawing.Color.White;
            this.btnTimePeriod.Location = new System.Drawing.Point(23, 691);
            this.btnTimePeriod.Name = "btnTimePeriod";
            this.btnTimePeriod.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTimePeriod.ShadowDecoration.Enabled = true;
            this.btnTimePeriod.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnTimePeriod.Size = new System.Drawing.Size(144, 35);
            this.btnTimePeriod.TabIndex = 2;
            this.btnTimePeriod.Text = "Odaberi vreme";
            this.btnTimePeriod.Click += new System.EventHandler(this.btnTimePeriod_Click);
            // 
            // btnStanica4
            // 
            this.btnStanica4.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStanica4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnStanica4.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStanica4.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStanica4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStanica4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStanica4.FillColor = System.Drawing.Color.White;
            this.btnStanica4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanica4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnStanica4.Location = new System.Drawing.Point(0, 229);
            this.btnStanica4.Name = "btnStanica4";
            this.btnStanica4.PressedDepth = 0;
            this.btnStanica4.Size = new System.Drawing.Size(190, 45);
            this.btnStanica4.TabIndex = 2;
            this.btnStanica4.Text = "STANICA 4";
            this.btnStanica4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStanica4.TextOffset = new System.Drawing.Point(15, 0);
            this.btnStanica4.CheckedChanged += new System.EventHandler(this.btnStanica4_CheckedChanged);
            // 
            // btnStanica3
            // 
            this.btnStanica3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStanica3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnStanica3.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStanica3.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStanica3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStanica3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStanica3.FillColor = System.Drawing.Color.White;
            this.btnStanica3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanica3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnStanica3.Location = new System.Drawing.Point(0, 184);
            this.btnStanica3.Name = "btnStanica3";
            this.btnStanica3.PressedDepth = 0;
            this.btnStanica3.Size = new System.Drawing.Size(190, 45);
            this.btnStanica3.TabIndex = 1;
            this.btnStanica3.Text = "STANICA 3";
            this.btnStanica3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStanica3.TextOffset = new System.Drawing.Point(15, 0);
            this.btnStanica3.CheckedChanged += new System.EventHandler(this.btnStanica3_CheckedChanged);
            // 
            // btnStanica2
            // 
            this.btnStanica2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStanica2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnStanica2.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStanica2.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStanica2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStanica2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStanica2.FillColor = System.Drawing.Color.White;
            this.btnStanica2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanica2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnStanica2.Location = new System.Drawing.Point(0, 139);
            this.btnStanica2.Name = "btnStanica2";
            this.btnStanica2.PressedDepth = 0;
            this.btnStanica2.Size = new System.Drawing.Size(190, 45);
            this.btnStanica2.TabIndex = 1;
            this.btnStanica2.Text = "STANICA 2";
            this.btnStanica2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStanica2.TextOffset = new System.Drawing.Point(15, 0);
            this.btnStanica2.CheckedChanged += new System.EventHandler(this.btnStanica2_CheckedChanged);
            // 
            // btnStanica1
            // 
            this.btnStanica1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStanica1.Checked = true;
            this.btnStanica1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnStanica1.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStanica1.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStanica1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStanica1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStanica1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStanica1.FillColor = System.Drawing.Color.White;
            this.btnStanica1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanica1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnStanica1.Location = new System.Drawing.Point(0, 94);
            this.btnStanica1.Name = "btnStanica1";
            this.btnStanica1.PressedDepth = 0;
            this.btnStanica1.Size = new System.Drawing.Size(190, 45);
            this.btnStanica1.TabIndex = 0;
            this.btnStanica1.Text = "STANICA 1";
            this.btnStanica1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStanica1.TextOffset = new System.Drawing.Point(15, 0);
            this.btnStanica1.CheckedChanged += new System.EventHandler(this.btnStanica1_CheckedChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlTop.Controls.Add(this.siticoneControlBox2);
            this.pnlTop.Controls.Add(this.siticoneControlBox1);
            this.pnlTop.Location = new System.Drawing.Point(196, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1205, 40);
            this.pnlTop.TabIndex = 1;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.siticoneControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox2.Location = new System.Drawing.Point(1115, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.Location = new System.Drawing.Point(1160, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.DragStartTransparencyValue = 1D;
            this.siticoneDragControl1.TargetControl = this.pnlTop;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // pnlWorking
            // 
            this.pnlWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorking.Controls.Add(this.station11);
            this.pnlWorking.Controls.Add(this.station41);
            this.pnlWorking.Controls.Add(this.station31);
            this.pnlWorking.Controls.Add(this.station21);
            this.pnlWorking.Location = new System.Drawing.Point(196, 43);
            this.pnlWorking.Name = "pnlWorking";
            this.pnlWorking.Size = new System.Drawing.Size(1205, 757);
            this.pnlWorking.TabIndex = 2;
            // 
            // station11
            // 
            this.station11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.station11.Location = new System.Drawing.Point(0, 0);
            this.station11.Name = "station11";
            this.station11.Size = new System.Drawing.Size(1205, 757);
            this.station11.TabIndex = 3;
            // 
            // station41
            // 
            this.station41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.station41.Location = new System.Drawing.Point(0, 0);
            this.station41.Name = "station41";
            this.station41.Size = new System.Drawing.Size(1205, 757);
            this.station41.TabIndex = 6;
            // 
            // station31
            // 
            this.station31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.station31.Location = new System.Drawing.Point(0, 0);
            this.station31.Name = "station31";
            this.station31.Size = new System.Drawing.Size(1205, 757);
            this.station31.TabIndex = 5;
            // 
            // station21
            // 
            this.station21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.station21.Location = new System.Drawing.Point(0, 0);
            this.station21.Name = "station21";
            this.station21.Size = new System.Drawing.Size(1205, 757);
            this.station21.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlWorking);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlWorking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlSide;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStanica4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStanica3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStanica2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStanica1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlTop;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnTimePeriod;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnlWorking;
        private Station1 station11;
        private Station2 station21;
        private Station3 station31;
        private Station4 station41;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpEnd;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpStart;
        private System.Windows.Forms.Label txtCurrDateEnd;
        private System.Windows.Forms.Label txtCurrDateStart;
    }
}