
namespace GanttChart
{
    partial class StartMenu
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
            this.startMenuButton = new System.Windows.Forms.Button();
            this.vremeKrajnje = new System.Windows.Forms.DateTimePicker();
            this.vremePocetno = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startMenuButton
            // 
            this.startMenuButton.Location = new System.Drawing.Point(142, 237);
            this.startMenuButton.Name = "startMenuButton";
            this.startMenuButton.Size = new System.Drawing.Size(127, 42);
            this.startMenuButton.TabIndex = 0;
            this.startMenuButton.Text = "Chart";
            this.startMenuButton.UseVisualStyleBackColor = true;
            this.startMenuButton.Click += new System.EventHandler(this.startMenuButton_Click);
            // 
            // vremeKrajnje
            // 
            this.vremeKrajnje.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vremeKrajnje.Location = new System.Drawing.Point(169, 158);
            this.vremeKrajnje.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.vremeKrajnje.Name = "vremeKrajnje";
            this.vremeKrajnje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vremeKrajnje.Size = new System.Drawing.Size(100, 20);
            this.vremeKrajnje.TabIndex = 1;
            // 
            // vremePocetno
            // 
            this.vremePocetno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vremePocetno.Location = new System.Drawing.Point(169, 102);
            this.vremePocetno.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.vremePocetno.Name = "vremePocetno";
            this.vremePocetno.Size = new System.Drawing.Size(100, 20);
            this.vremePocetno.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flieToolStripMenuItem
            // 
            this.flieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.flieToolStripMenuItem.Name = "flieToolStripMenuItem";
            this.flieToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.flieToolStripMenuItem.Text = "Flie";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // startDropDown
            // 
            this.startDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startDropDown.FormattingEnabled = true;
            this.startDropDown.Location = new System.Drawing.Point(169, 52);
            this.startDropDown.Name = "startDropDown";
            this.startDropDown.Size = new System.Drawing.Size(100, 21);
            this.startDropDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izaberite stanicu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pocetno vreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(62, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Krajnje vreme:";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDropDown);
            this.Controls.Add(this.vremePocetno);
            this.Controls.Add(this.vremeKrajnje);
            this.Controls.Add(this.startMenuButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMenuButton;
        private System.Windows.Forms.DateTimePicker vremeKrajnje;
        private System.Windows.Forms.DateTimePicker vremePocetno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox startDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}