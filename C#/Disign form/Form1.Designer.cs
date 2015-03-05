namespace DeGokkers
{
    partial class FormRenbaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenbaan));
            this.wedt = new System.Windows.Forms.Button();
            this.wedtEuro = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hondNummer = new System.Windows.Forms.NumericUpDown();
            this.Weddenschap1 = new System.Windows.Forms.TextBox();
            this.weddenschap3 = new System.Windows.Forms.TextBox();
            this.weddenschap2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.tmrDog = new System.Windows.Forms.Timer(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblSietseCash = new System.Windows.Forms.Label();
            this.lblLidyCash = new System.Windows.Forms.Label();
            this.lblFerCash = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.deelnemer1 = new System.Windows.Forms.RadioButton();
            this.deelnemer2 = new System.Windows.Forms.RadioButton();
            this.deelnemer3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblfinish1 = new System.Windows.Forms.Label();
            this.lblfinish2 = new System.Windows.Forms.Label();
            this.lblfinish4 = new System.Windows.Forms.Label();
            this.lblfinish3 = new System.Windows.Forms.Label();
            this.txtRendierNummer = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dier4 = new System.Windows.Forms.PictureBox();
            this.dier3 = new System.Windows.Forms.PictureBox();
            this.dier2 = new System.Windows.Forms.PictureBox();
            this.dier1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wedtEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hondNummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wedt
            // 
            this.wedt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wedt.Location = new System.Drawing.Point(84, 533);
            this.wedt.Margin = new System.Windows.Forms.Padding(4);
            this.wedt.Name = "wedt";
            this.wedt.Size = new System.Drawing.Size(100, 28);
            this.wedt.TabIndex = 9;
            this.wedt.Text = "wedt";
            this.wedt.UseVisualStyleBackColor = true;
            this.wedt.Click += new System.EventHandler(this.wedt_Click);
            // 
            // wedtEuro
            // 
            this.wedtEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wedtEuro.Location = new System.Drawing.Point(192, 539);
            this.wedtEuro.Margin = new System.Windows.Forms.Padding(4);
            this.wedtEuro.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.wedtEuro.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wedtEuro.Name = "wedtEuro";
            this.wedtEuro.Size = new System.Drawing.Size(49, 22);
            this.wedtEuro.TabIndex = 10;
            this.wedtEuro.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(249, 540);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(203, 19);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "euro op rendier nummer:";
            // 
            // hondNummer
            // 
            this.hondNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hondNummer.Location = new System.Drawing.Point(487, 537);
            this.hondNummer.Margin = new System.Windows.Forms.Padding(4);
            this.hondNummer.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.hondNummer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hondNummer.Name = "hondNummer";
            this.hondNummer.Size = new System.Drawing.Size(56, 22);
            this.hondNummer.TabIndex = 12;
            this.hondNummer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Weddenschap1
            // 
            this.Weddenschap1.BackColor = System.Drawing.SystemColors.Control;
            this.Weddenschap1.Location = new System.Drawing.Point(487, 445);
            this.Weddenschap1.Margin = new System.Windows.Forms.Padding(4);
            this.Weddenschap1.Name = "Weddenschap1";
            this.Weddenschap1.ReadOnly = true;
            this.Weddenschap1.Size = new System.Drawing.Size(545, 22);
            this.Weddenschap1.TabIndex = 13;
            this.Weddenschap1.Text = "Sieste heeft nog geen weddenscap geplaatst";
            // 
            // weddenschap3
            // 
            this.weddenschap3.BackColor = System.Drawing.SystemColors.Control;
            this.weddenschap3.Location = new System.Drawing.Point(487, 505);
            this.weddenschap3.Margin = new System.Windows.Forms.Padding(4);
            this.weddenschap3.Name = "weddenschap3";
            this.weddenschap3.ReadOnly = true;
            this.weddenschap3.Size = new System.Drawing.Size(545, 22);
            this.weddenschap3.TabIndex = 14;
            this.weddenschap3.Text = "Fer heeft nog geen weddenscap geplaatst";
            // 
            // weddenschap2
            // 
            this.weddenschap2.BackColor = System.Drawing.SystemColors.Control;
            this.weddenschap2.Location = new System.Drawing.Point(487, 476);
            this.weddenschap2.Margin = new System.Windows.Forms.Padding(4);
            this.weddenschap2.Name = "weddenschap2";
            this.weddenschap2.ReadOnly = true;
            this.weddenschap2.Size = new System.Drawing.Size(545, 22);
            this.weddenschap2.TabIndex = 15;
            this.weddenschap2.Text = "Lidy heeft nog geen weddenscap geplaatst";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(487, 401);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(287, 27);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Weddenschappen";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(966, 540);
            this.goButton.Margin = new System.Windows.Forms.Padding(4);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 33);
            this.goButton.TabIndex = 17;
            this.goButton.Text = "Go!!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // tmrDog
            // 
            this.tmrDog.Interval = 10;
            this.tmrDog.Tick += new System.EventHandler(this.tmrDog_Tick);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 196);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(16, 27);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "3";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(0, 292);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(16, 27);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "4";
            // 
            // lblSietseCash
            // 
            this.lblSietseCash.AutoSize = true;
            this.lblSietseCash.Location = new System.Drawing.Point(88, 450);
            this.lblSietseCash.Name = "lblSietseCash";
            this.lblSietseCash.Size = new System.Drawing.Size(16, 17);
            this.lblSietseCash.TabIndex = 23;
            this.lblSietseCash.Text = "€";
            // 
            // lblLidyCash
            // 
            this.lblLidyCash.AutoSize = true;
            this.lblLidyCash.Location = new System.Drawing.Point(88, 476);
            this.lblLidyCash.Name = "lblLidyCash";
            this.lblLidyCash.Size = new System.Drawing.Size(16, 17);
            this.lblLidyCash.TabIndex = 24;
            this.lblLidyCash.Text = "€";
            // 
            // lblFerCash
            // 
            this.lblFerCash.AutoSize = true;
            this.lblFerCash.Location = new System.Drawing.Point(88, 505);
            this.lblFerCash.Name = "lblFerCash";
            this.lblFerCash.Size = new System.Drawing.Size(16, 17);
            this.lblFerCash.TabIndex = 25;
            this.lblFerCash.Text = "€";
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(30, 542);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(47, 17);
            this.lblNamePlayer.TabIndex = 26;
            this.lblNamePlayer.Text = "Sietse";
            // 
            // deelnemer1
            // 
            this.deelnemer1.AutoSize = true;
            this.deelnemer1.Checked = true;
            this.deelnemer1.Location = new System.Drawing.Point(16, 450);
            this.deelnemer1.Margin = new System.Windows.Forms.Padding(4);
            this.deelnemer1.Name = "deelnemer1";
            this.deelnemer1.Size = new System.Drawing.Size(68, 21);
            this.deelnemer1.TabIndex = 27;
            this.deelnemer1.TabStop = true;
            this.deelnemer1.Text = "Sietse";
            this.deelnemer1.UseVisualStyleBackColor = true;
            this.deelnemer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deelnemer1_MouseClick);
            // 
            // deelnemer2
            // 
            this.deelnemer2.AutoSize = true;
            this.deelnemer2.Location = new System.Drawing.Point(16, 476);
            this.deelnemer2.Margin = new System.Windows.Forms.Padding(4);
            this.deelnemer2.Name = "deelnemer2";
            this.deelnemer2.Size = new System.Drawing.Size(55, 21);
            this.deelnemer2.TabIndex = 28;
            this.deelnemer2.Text = "Lidy";
            this.deelnemer2.UseVisualStyleBackColor = true;
            this.deelnemer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deelnemer1_MouseClick);
            // 
            // deelnemer3
            // 
            this.deelnemer3.AutoSize = true;
            this.deelnemer3.Location = new System.Drawing.Point(17, 502);
            this.deelnemer3.Margin = new System.Windows.Forms.Padding(4);
            this.deelnemer3.Name = "deelnemer3";
            this.deelnemer3.Size = new System.Drawing.Size(50, 21);
            this.deelnemer3.TabIndex = 29;
            this.deelnemer3.Text = "Fer";
            this.deelnemer3.UseVisualStyleBackColor = true;
            this.deelnemer3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deelnemer1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 410);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(287, 27);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Minimum inzet 5 Euro";
            // 
            // lblfinish1
            // 
            this.lblfinish1.AutoSize = true;
            this.lblfinish1.Location = new System.Drawing.Point(1040, 35);
            this.lblfinish1.Name = "lblfinish1";
            this.lblfinish1.Size = new System.Drawing.Size(40, 17);
            this.lblfinish1.TabIndex = 31;
            this.lblfinish1.Text = "- - - -";
            // 
            // lblfinish2
            // 
            this.lblfinish2.AutoSize = true;
            this.lblfinish2.Location = new System.Drawing.Point(1039, 126);
            this.lblfinish2.Name = "lblfinish2";
            this.lblfinish2.Size = new System.Drawing.Size(40, 17);
            this.lblfinish2.TabIndex = 32;
            this.lblfinish2.Text = "- - - -";
            // 
            // lblfinish4
            // 
            this.lblfinish4.AutoSize = true;
            this.lblfinish4.Location = new System.Drawing.Point(1040, 302);
            this.lblfinish4.Name = "lblfinish4";
            this.lblfinish4.Size = new System.Drawing.Size(40, 17);
            this.lblfinish4.TabIndex = 34;
            this.lblfinish4.Text = "- - - -";
            // 
            // lblfinish3
            // 
            this.lblfinish3.AutoSize = true;
            this.lblfinish3.Location = new System.Drawing.Point(1040, 206);
            this.lblfinish3.Name = "lblfinish3";
            this.lblfinish3.Size = new System.Drawing.Size(40, 17);
            this.lblfinish3.TabIndex = 33;
            this.lblfinish3.Text = "- - - -";
            // 
            // txtRendierNummer
            // 
            this.txtRendierNummer.BackColor = System.Drawing.Color.OliveDrab;
            this.txtRendierNummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRendierNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendierNummer.Location = new System.Drawing.Point(0, 25);
            this.txtRendierNummer.Margin = new System.Windows.Forms.Padding(4);
            this.txtRendierNummer.Name = "txtRendierNummer";
            this.txtRendierNummer.ReadOnly = true;
            this.txtRendierNummer.Size = new System.Drawing.Size(16, 27);
            this.txtRendierNummer.TabIndex = 35;
            this.txtRendierNummer.Text = "1";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 116);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(16, 27);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "2";
            // 
            // dier4
            // 
            this.dier4.Image = global::DeGokkers.Properties.Resources.reindeergifStatic;
            this.dier4.Location = new System.Drawing.Point(32, 273);
            this.dier4.Margin = new System.Windows.Forms.Padding(4);
            this.dier4.Name = "dier4";
            this.dier4.Size = new System.Drawing.Size(116, 70);
            this.dier4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier4.TabIndex = 4;
            this.dier4.TabStop = false;
            // 
            // dier3
            // 
            this.dier3.Image = global::DeGokkers.Properties.Resources.reindeergifStatic;
            this.dier3.Location = new System.Drawing.Point(32, 183);
            this.dier3.Margin = new System.Windows.Forms.Padding(4);
            this.dier3.Name = "dier3";
            this.dier3.Size = new System.Drawing.Size(116, 70);
            this.dier3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier3.TabIndex = 3;
            this.dier3.TabStop = false;
            // 
            // dier2
            // 
            this.dier2.Image = global::DeGokkers.Properties.Resources.reindeergifStatic;
            this.dier2.Location = new System.Drawing.Point(32, 95);
            this.dier2.Margin = new System.Windows.Forms.Padding(4);
            this.dier2.Name = "dier2";
            this.dier2.Size = new System.Drawing.Size(116, 70);
            this.dier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier2.TabIndex = 2;
            this.dier2.TabStop = false;
            // 
            // dier1
            // 
            this.dier1.Image = global::DeGokkers.Properties.Resources.reindeergifStatic;
            this.dier1.Location = new System.Drawing.Point(32, 7);
            this.dier1.Margin = new System.Windows.Forms.Padding(4);
            this.dier1.Name = "dier1";
            this.dier1.Size = new System.Drawing.Size(116, 70);
            this.dier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier1.TabIndex = 1;
            this.dier1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeGokkers.Properties.Resources.renbaan2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // FormRenbaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1100, 582);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtRendierNummer);
            this.Controls.Add(this.lblfinish4);
            this.Controls.Add(this.lblfinish3);
            this.Controls.Add(this.lblfinish2);
            this.Controls.Add(this.lblfinish1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deelnemer3);
            this.Controls.Add(this.deelnemer2);
            this.Controls.Add(this.deelnemer1);
            this.Controls.Add(this.lblNamePlayer);
            this.Controls.Add(this.lblFerCash);
            this.Controls.Add(this.lblLidyCash);
            this.Controls.Add(this.lblSietseCash);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.weddenschap2);
            this.Controls.Add(this.weddenschap3);
            this.Controls.Add(this.Weddenschap1);
            this.Controls.Add(this.hondNummer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.wedtEuro);
            this.Controls.Add(this.wedt);
            this.Controls.Add(this.dier4);
            this.Controls.Add(this.dier3);
            this.Controls.Add(this.dier2);
            this.Controls.Add(this.dier1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRenbaan";
            this.Text = "Rendieren Race";
            ((System.ComponentModel.ISupportInitialize)(this.wedtEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hondNummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dier2;
        private System.Windows.Forms.PictureBox dier3;
        private System.Windows.Forms.PictureBox dier4;
        private System.Windows.Forms.Button wedt;
        private System.Windows.Forms.NumericUpDown wedtEuro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown hondNummer;
        private System.Windows.Forms.TextBox Weddenschap1;
        private System.Windows.Forms.TextBox weddenschap3;
        private System.Windows.Forms.TextBox weddenschap2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Timer tmrDog;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblSietseCash;
        private System.Windows.Forms.Label lblLidyCash;
        private System.Windows.Forms.Label lblFerCash;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.RadioButton deelnemer1;
        private System.Windows.Forms.RadioButton deelnemer2;
        private System.Windows.Forms.RadioButton deelnemer3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfinish1;
        private System.Windows.Forms.Label lblfinish2;
        private System.Windows.Forms.Label lblfinish4;
        private System.Windows.Forms.Label lblfinish3;
        private System.Windows.Forms.TextBox txtRendierNummer;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox dier1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

