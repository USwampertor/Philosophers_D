namespace Dining_Philosophers
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.thinkNum = new System.Windows.Forms.NumericUpDown();
            this.eatNum = new System.Windows.Forms.NumericUpDown();
            this.thinkLabel = new System.Windows.Forms.Label();
            this.eatLabel = new System.Windows.Forms.Label();
            this.philosLabel1 = new System.Windows.Forms.Label();
            this.philosLabel2 = new System.Windows.Forms.Label();
            this.philosLabel3 = new System.Windows.Forms.Label();
            this.philosLabel4 = new System.Windows.Forms.Label();
            this.philosLabel5 = new System.Windows.Forms.Label();
            this.goldenPicture = new System.Windows.Forms.PictureBox();
            this.woodenPicture = new System.Windows.Forms.PictureBox();
            this.platinumPicture = new System.Windows.Forms.PictureBox();
            this.plasticPicture = new System.Windows.Forms.PictureBox();
            this.silverPicture = new System.Windows.Forms.PictureBox();
            this.philosPicture3 = new System.Windows.Forms.PictureBox();
            this.philosPicture2 = new System.Windows.Forms.PictureBox();
            this.philosPicture4 = new System.Windows.Forms.PictureBox();
            this.tablePicture = new System.Windows.Forms.PictureBox();
            this.philosPicture5 = new System.Windows.Forms.PictureBox();
            this.philosPicture1 = new System.Windows.Forms.PictureBox();
            this.pauseNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thinkNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodenPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platinumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asistanceToolStripMenuItem
            // 
            this.asistanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.asistanceToolStripMenuItem.Name = "asistanceToolStripMenuItem";
            this.asistanceToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.asistanceToolStripMenuItem.Text = "Asistance";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pauseNum);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.thinkNum);
            this.panel1.Controls.Add(this.eatNum);
            this.panel1.Controls.Add(this.thinkLabel);
            this.panel1.Controls.Add(this.eatLabel);
            this.panel1.Location = new System.Drawing.Point(648, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 140);
            this.panel1.TabIndex = 1;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(6, 110);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(119, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(6, 80);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(67, 23);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 50);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // thinkNum
            // 
            this.thinkNum.Location = new System.Drawing.Point(79, 24);
            this.thinkNum.Name = "thinkNum";
            this.thinkNum.Size = new System.Drawing.Size(46, 20);
            this.thinkNum.TabIndex = 3;
            // 
            // eatNum
            // 
            this.eatNum.Location = new System.Drawing.Point(79, 3);
            this.eatNum.Name = "eatNum";
            this.eatNum.Size = new System.Drawing.Size(46, 20);
            this.eatNum.TabIndex = 2;
            // 
            // thinkLabel
            // 
            this.thinkLabel.AutoSize = true;
            this.thinkLabel.Location = new System.Drawing.Point(3, 26);
            this.thinkLabel.Name = "thinkLabel";
            this.thinkLabel.Size = new System.Drawing.Size(70, 13);
            this.thinkLabel.TabIndex = 1;
            this.thinkLabel.Text = "Thinking time";
            // 
            // eatLabel
            // 
            this.eatLabel.AutoSize = true;
            this.eatLabel.Location = new System.Drawing.Point(3, 5);
            this.eatLabel.Name = "eatLabel";
            this.eatLabel.Size = new System.Drawing.Size(59, 13);
            this.eatLabel.TabIndex = 0;
            this.eatLabel.Text = "Eating time";
            // 
            // philosLabel1
            // 
            this.philosLabel1.AutoSize = true;
            this.philosLabel1.BackColor = System.Drawing.Color.Transparent;
            this.philosLabel1.Font = new System.Drawing.Font("AR JULIAN", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philosLabel1.Location = new System.Drawing.Point(310, 142);
            this.philosLabel1.Name = "philosLabel1";
            this.philosLabel1.Size = new System.Drawing.Size(16, 14);
            this.philosLabel1.TabIndex = 8;
            this.philosLabel1.Text = "...";
            // 
            // philosLabel2
            // 
            this.philosLabel2.AutoSize = true;
            this.philosLabel2.BackColor = System.Drawing.Color.Transparent;
            this.philosLabel2.Font = new System.Drawing.Font("AR JULIAN", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philosLabel2.Location = new System.Drawing.Point(492, 178);
            this.philosLabel2.Name = "philosLabel2";
            this.philosLabel2.Size = new System.Drawing.Size(16, 14);
            this.philosLabel2.TabIndex = 9;
            this.philosLabel2.Text = "...";
            // 
            // philosLabel3
            // 
            this.philosLabel3.AutoSize = true;
            this.philosLabel3.BackColor = System.Drawing.Color.Transparent;
            this.philosLabel3.Font = new System.Drawing.Font("AR JULIAN", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philosLabel3.Location = new System.Drawing.Point(446, 435);
            this.philosLabel3.Name = "philosLabel3";
            this.philosLabel3.Size = new System.Drawing.Size(16, 14);
            this.philosLabel3.TabIndex = 10;
            this.philosLabel3.Text = "...";
            // 
            // philosLabel4
            // 
            this.philosLabel4.AutoSize = true;
            this.philosLabel4.BackColor = System.Drawing.Color.Transparent;
            this.philosLabel4.Font = new System.Drawing.Font("AR JULIAN", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philosLabel4.Location = new System.Drawing.Point(159, 435);
            this.philosLabel4.Name = "philosLabel4";
            this.philosLabel4.Size = new System.Drawing.Size(16, 14);
            this.philosLabel4.TabIndex = 11;
            this.philosLabel4.Text = "...";
            // 
            // philosLabel5
            // 
            this.philosLabel5.AutoSize = true;
            this.philosLabel5.BackColor = System.Drawing.Color.Transparent;
            this.philosLabel5.Font = new System.Drawing.Font("AR JULIAN", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philosLabel5.Location = new System.Drawing.Point(120, 187);
            this.philosLabel5.Name = "philosLabel5";
            this.philosLabel5.Size = new System.Drawing.Size(16, 14);
            this.philosLabel5.TabIndex = 12;
            this.philosLabel5.Text = "...";
            // 
            // goldenPicture
            // 
            this.goldenPicture.Image = global::Dining_Philosophers.Properties.Resources.yellowfork;
            this.goldenPicture.Location = new System.Drawing.Point(449, 244);
            this.goldenPicture.Name = "goldenPicture";
            this.goldenPicture.Size = new System.Drawing.Size(49, 50);
            this.goldenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldenPicture.TabIndex = 17;
            this.goldenPicture.TabStop = false;
            // 
            // woodenPicture
            // 
            this.woodenPicture.Image = global::Dining_Philosophers.Properties.Resources.brownfork;
            this.woodenPicture.Location = new System.Drawing.Point(205, 244);
            this.woodenPicture.Name = "woodenPicture";
            this.woodenPicture.Size = new System.Drawing.Size(49, 50);
            this.woodenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodenPicture.TabIndex = 16;
            this.woodenPicture.TabStop = false;
            // 
            // platinumPicture
            // 
            this.platinumPicture.Image = global::Dining_Philosophers.Properties.Resources.bluefork;
            this.platinumPicture.Location = new System.Drawing.Point(413, 151);
            this.platinumPicture.Name = "platinumPicture";
            this.platinumPicture.Size = new System.Drawing.Size(49, 50);
            this.platinumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platinumPicture.TabIndex = 15;
            this.platinumPicture.TabStop = false;
            // 
            // plasticPicture
            // 
            this.plasticPicture.Image = global::Dining_Philosophers.Properties.Resources.clearfork;
            this.plasticPicture.Location = new System.Drawing.Point(244, 151);
            this.plasticPicture.Name = "plasticPicture";
            this.plasticPicture.Size = new System.Drawing.Size(49, 50);
            this.plasticPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plasticPicture.TabIndex = 14;
            this.plasticPicture.TabStop = false;
            // 
            // silverPicture
            // 
            this.silverPicture.Image = global::Dining_Philosophers.Properties.Resources.freyfork;
            this.silverPicture.Location = new System.Drawing.Point(331, 340);
            this.silverPicture.Name = "silverPicture";
            this.silverPicture.Size = new System.Drawing.Size(49, 50);
            this.silverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.silverPicture.TabIndex = 13;
            this.silverPicture.TabStop = false;
            // 
            // philosPicture3
            // 
            this.philosPicture3.Image = global::Dining_Philosophers.Properties.Resources.nietzsche;
            this.philosPicture3.Location = new System.Drawing.Point(449, 320);
            this.philosPicture3.Name = "philosPicture3";
            this.philosPicture3.Size = new System.Drawing.Size(74, 112);
            this.philosPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.philosPicture3.TabIndex = 7;
            this.philosPicture3.TabStop = false;
            // 
            // philosPicture2
            // 
            this.philosPicture2.Image = global::Dining_Philosophers.Properties.Resources.platon;
            this.philosPicture2.Location = new System.Drawing.Point(495, 77);
            this.philosPicture2.Name = "philosPicture2";
            this.philosPicture2.Size = new System.Drawing.Size(82, 98);
            this.philosPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.philosPicture2.TabIndex = 6;
            this.philosPicture2.TabStop = false;
            // 
            // philosPicture4
            // 
            this.philosPicture4.Image = global::Dining_Philosophers.Properties.Resources.Parmenides;
            this.philosPicture4.Location = new System.Drawing.Point(162, 320);
            this.philosPicture4.Name = "philosPicture4";
            this.philosPicture4.Size = new System.Drawing.Size(92, 112);
            this.philosPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.philosPicture4.TabIndex = 5;
            this.philosPicture4.TabStop = false;
            // 
            // tablePicture
            // 
            this.tablePicture.Image = global::Dining_Philosophers.Properties.Resources.table;
            this.tablePicture.Location = new System.Drawing.Point(301, 224);
            this.tablePicture.Name = "tablePicture";
            this.tablePicture.Size = new System.Drawing.Size(103, 98);
            this.tablePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablePicture.TabIndex = 4;
            this.tablePicture.TabStop = false;
            // 
            // philosPicture5
            // 
            this.philosPicture5.Image = global::Dining_Philosophers.Properties.Resources.socrates;
            this.philosPicture5.Location = new System.Drawing.Point(123, 77);
            this.philosPicture5.Name = "philosPicture5";
            this.philosPicture5.Size = new System.Drawing.Size(83, 107);
            this.philosPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.philosPicture5.TabIndex = 3;
            this.philosPicture5.TabStop = false;
            // 
            // philosPicture1
            // 
            this.philosPicture1.Image = global::Dining_Philosophers.Properties.Resources.Aristoteles;
            this.philosPicture1.Location = new System.Drawing.Point(313, 27);
            this.philosPicture1.Name = "philosPicture1";
            this.philosPicture1.Size = new System.Drawing.Size(82, 114);
            this.philosPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.philosPicture1.TabIndex = 2;
            this.philosPicture1.TabStop = false;
            // 
            // pauseNum
            // 
            this.pauseNum.Location = new System.Drawing.Point(79, 82);
            this.pauseNum.Name = "pauseNum";
            this.pauseNum.Size = new System.Drawing.Size(46, 20);
            this.pauseNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goldenPicture);
            this.Controls.Add(this.woodenPicture);
            this.Controls.Add(this.platinumPicture);
            this.Controls.Add(this.plasticPicture);
            this.Controls.Add(this.silverPicture);
            this.Controls.Add(this.philosLabel5);
            this.Controls.Add(this.philosLabel4);
            this.Controls.Add(this.philosLabel3);
            this.Controls.Add(this.philosLabel2);
            this.Controls.Add(this.philosLabel1);
            this.Controls.Add(this.philosPicture3);
            this.Controls.Add(this.philosPicture2);
            this.Controls.Add(this.philosPicture4);
            this.Controls.Add(this.tablePicture);
            this.Controls.Add(this.philosPicture5);
            this.Controls.Add(this.philosPicture1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thinkNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodenPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platinumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philosPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown thinkNum;
        private System.Windows.Forms.NumericUpDown eatNum;
        private System.Windows.Forms.Label thinkLabel;
        private System.Windows.Forms.Label eatLabel;
        private System.Windows.Forms.PictureBox philosPicture1;
        private System.Windows.Forms.PictureBox philosPicture5;
        private System.Windows.Forms.PictureBox tablePicture;
        private System.Windows.Forms.PictureBox philosPicture4;
        private System.Windows.Forms.PictureBox philosPicture2;
        private System.Windows.Forms.PictureBox philosPicture3;
        private System.Windows.Forms.Label philosLabel1;
        private System.Windows.Forms.Label philosLabel2;
        private System.Windows.Forms.Label philosLabel3;
        private System.Windows.Forms.Label philosLabel4;
        private System.Windows.Forms.Label philosLabel5;
        private System.Windows.Forms.PictureBox silverPicture;
        private System.Windows.Forms.PictureBox plasticPicture;
        private System.Windows.Forms.PictureBox platinumPicture;
        private System.Windows.Forms.PictureBox woodenPicture;
        private System.Windows.Forms.PictureBox goldenPicture;
        private System.Windows.Forms.NumericUpDown pauseNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

