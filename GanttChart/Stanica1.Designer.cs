
namespace GanttChart
{
    partial class Stanica1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.grpbxAktuatori = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbAktuatori = new System.Windows.Forms.ProgressBar();
            this.grpbxVazduh = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbVazuh = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVakumStan1 = new System.Windows.Forms.Label();
            this.lblVakumStan2 = new System.Windows.Forms.Label();
            this.lblPotrosnjaVazduha = new System.Windows.Forms.Label();
            this.lblCilindarIzv = new System.Windows.Forms.Label();
            this.lblCilindarUvu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpbxAktuatori.SuspendLayout();
            this.grpbxVazduh.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 212);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpbxAktuatori
            // 
            this.grpbxAktuatori.Controls.Add(this.lblCilindarUvu);
            this.grpbxAktuatori.Controls.Add(this.lblCilindarIzv);
            this.grpbxAktuatori.Controls.Add(this.label7);
            this.grpbxAktuatori.Controls.Add(this.label6);
            this.grpbxAktuatori.Controls.Add(this.label5);
            this.grpbxAktuatori.Controls.Add(this.pbAktuatori);
            this.grpbxAktuatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpbxAktuatori.Location = new System.Drawing.Point(478, 270);
            this.grpbxAktuatori.Name = "grpbxAktuatori";
            this.grpbxAktuatori.Size = new System.Drawing.Size(425, 250);
            this.grpbxAktuatori.TabIndex = 5;
            this.grpbxAktuatori.TabStop = false;
            this.grpbxAktuatori.Text = "AKTUATORI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cilindar uvučen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cilindar izvučen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(137, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Radni vek cilindra";
            // 
            // pbAktuatori
            // 
            this.pbAktuatori.Location = new System.Drawing.Point(6, 213);
            this.pbAktuatori.Name = "pbAktuatori";
            this.pbAktuatori.Size = new System.Drawing.Size(397, 31);
            this.pbAktuatori.TabIndex = 4;
            // 
            // grpbxVazduh
            // 
            this.grpbxVazduh.Controls.Add(this.lblPotrosnjaVazduha);
            this.grpbxVazduh.Controls.Add(this.lblVakumStan2);
            this.grpbxVazduh.Controls.Add(this.lblVakumStan1);
            this.grpbxVazduh.Controls.Add(this.label4);
            this.grpbxVazduh.Controls.Add(this.pbVazuh);
            this.grpbxVazduh.Controls.Add(this.label3);
            this.grpbxVazduh.Controls.Add(this.label2);
            this.grpbxVazduh.Controls.Add(this.label1);
            this.grpbxVazduh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpbxVazduh.Location = new System.Drawing.Point(13, 270);
            this.grpbxVazduh.Name = "grpbxVazduh";
            this.grpbxVazduh.Size = new System.Drawing.Size(425, 250);
            this.grpbxVazduh.TabIndex = 6;
            this.grpbxVazduh.TabStop = false;
            this.grpbxVazduh.Text = "VAZDUH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(105, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Radni vek filtera vazduha";
            // 
            // pbVazuh
            // 
            this.pbVazuh.Location = new System.Drawing.Point(6, 213);
            this.pbVazuh.Name = "pbVazuh";
            this.pbVazuh.Size = new System.Drawing.Size(397, 31);
            this.pbVazuh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potrošnja vazuha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ukljucenost vakuma STANICA 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uključenost vakuma STANICA 1:";
            // 
            // lblVakumStan1
            // 
            this.lblVakumStan1.AutoSize = true;
            this.lblVakumStan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVakumStan1.Location = new System.Drawing.Point(281, 45);
            this.lblVakumStan1.Name = "lblVakumStan1";
            this.lblVakumStan1.Size = new System.Drawing.Size(20, 20);
            this.lblVakumStan1.TabIndex = 5;
            this.lblVakumStan1.Text = "X";
            // 
            // lblVakumStan2
            // 
            this.lblVakumStan2.AutoSize = true;
            this.lblVakumStan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVakumStan2.Location = new System.Drawing.Point(281, 75);
            this.lblVakumStan2.Name = "lblVakumStan2";
            this.lblVakumStan2.Size = new System.Drawing.Size(20, 20);
            this.lblVakumStan2.TabIndex = 6;
            this.lblVakumStan2.Text = "X";
            // 
            // lblPotrosnjaVazduha
            // 
            this.lblPotrosnjaVazduha.AutoSize = true;
            this.lblPotrosnjaVazduha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPotrosnjaVazduha.Location = new System.Drawing.Point(169, 121);
            this.lblPotrosnjaVazduha.Name = "lblPotrosnjaVazduha";
            this.lblPotrosnjaVazduha.Size = new System.Drawing.Size(27, 25);
            this.lblPotrosnjaVazduha.TabIndex = 7;
            this.lblPotrosnjaVazduha.Text = "X";
            // 
            // lblCilindarIzv
            // 
            this.lblCilindarIzv.AutoSize = true;
            this.lblCilindarIzv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCilindarIzv.Location = new System.Drawing.Point(148, 45);
            this.lblCilindarIzv.Name = "lblCilindarIzv";
            this.lblCilindarIzv.Size = new System.Drawing.Size(20, 20);
            this.lblCilindarIzv.TabIndex = 8;
            this.lblCilindarIzv.Text = "X";
            // 
            // lblCilindarUvu
            // 
            this.lblCilindarUvu.AutoSize = true;
            this.lblCilindarUvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCilindarUvu.Location = new System.Drawing.Point(148, 75);
            this.lblCilindarUvu.Name = "lblCilindarUvu";
            this.lblCilindarUvu.Size = new System.Drawing.Size(20, 20);
            this.lblCilindarUvu.TabIndex = 9;
            this.lblCilindarUvu.Text = "X";
            // 
            // Stanica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpbxVazduh);
            this.Controls.Add(this.grpbxAktuatori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stanica1";
            this.Text = "Stanica1";
            this.Load += new System.EventHandler(this.Stanica1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbxAktuatori.ResumeLayout(false);
            this.grpbxAktuatori.PerformLayout();
            this.grpbxVazduh.ResumeLayout(false);
            this.grpbxVazduh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuGanttChart1;
        private System.Windows.Forms.GroupBox grpbxAktuatori;
        private System.Windows.Forms.ProgressBar pbAktuatori;
        private System.Windows.Forms.GroupBox grpbxVazduh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbVazuh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCilindarUvu;
        private System.Windows.Forms.Label lblCilindarIzv;
        private System.Windows.Forms.Label lblPotrosnjaVazduha;
        private System.Windows.Forms.Label lblVakumStan2;
        private System.Windows.Forms.Label lblVakumStan1;
    }
}