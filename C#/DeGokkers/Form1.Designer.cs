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
            this.wedtButton = new System.Windows.Forms.Button();
            this.wedtEuro = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hondNummer = new System.Windows.Forms.NumericUpDown();
            this.Weddenschap1 = new System.Windows.Forms.TextBox();
            this.Weddenschap3 = new System.Windows.Forms.TextBox();
            this.Weddenschap2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.tmrReindeer = new System.Windows.Forms.Timer(this.components);
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
            this.dier4 = new System.Windows.Forms.PictureBox();
            this.dier3 = new System.Windows.Forms.PictureBox();
            this.dier2 = new System.Windows.Forms.PictureBox();
            this.dier1 = new System.Windows.Forms.PictureBox();
            this.Renbaan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wedtEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hondNummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Renbaan)).BeginInit();
            this.SuspendLayout();
            // 
            // wedtButton
            // 
            this.wedtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wedtButton.Location = new System.Drawing.Point(63, 433);
            this.wedtButton.Name = "wedtButton";
            this.wedtButton.Size = new System.Drawing.Size(75, 23);
            this.wedtButton.TabIndex = 9;
            this.wedtButton.Text = "wedt";
            this.wedtButton.UseVisualStyleBackColor = true;
            this.wedtButton.Click += new System.EventHandler(this.wedt_Click);
            // 
            // wedtEuro
            // 
            this.wedtEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wedtEuro.Location = new System.Drawing.Point(144, 438);
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
            this.wedtEuro.Size = new System.Drawing.Size(37, 20);
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
            this.textBox2.Location = new System.Drawing.Point(187, 439);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(152, 15);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Euro op rendier nummer:";
            // 
            // hondNummer
            // 
            this.hondNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hondNummer.Location = new System.Drawing.Point(365, 436);
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
            this.hondNummer.Size = new System.Drawing.Size(42, 20);
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
            this.Weddenschap1.Location = new System.Drawing.Point(365, 362);
            this.Weddenschap1.Name = "Weddenschap1";
            this.Weddenschap1.ReadOnly = true;
            this.Weddenschap1.Size = new System.Drawing.Size(410, 20);
            this.Weddenschap1.TabIndex = 13;
            this.Weddenschap1.Text = "Sieste heeft nog geen weddenscap geplaatst";
            // 
            // Weddenschap3
            // 
            this.Weddenschap3.BackColor = System.Drawing.SystemColors.Control;
            this.Weddenschap3.Location = new System.Drawing.Point(365, 410);
            this.Weddenschap3.Name = "Weddenschap3";
            this.Weddenschap3.ReadOnly = true;
            this.Weddenschap3.Size = new System.Drawing.Size(410, 20);
            this.Weddenschap3.TabIndex = 14;
            this.Weddenschap3.Text = "Fer heeft nog geen weddenscap geplaatst";
            // 
            // Weddenschap2
            // 
            this.Weddenschap2.BackColor = System.Drawing.SystemColors.Control;
            this.Weddenschap2.Location = new System.Drawing.Point(365, 387);
            this.Weddenschap2.Name = "Weddenschap2";
            this.Weddenschap2.ReadOnly = true;
            this.Weddenschap2.Size = new System.Drawing.Size(410, 20);
            this.Weddenschap2.TabIndex = 15;
            this.Weddenschap2.Text = "Lidy heeft nog geen weddenscap geplaatst";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(365, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(215, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Weddenschappen";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(724, 439);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 27);
            this.goButton.TabIndex = 17;
            this.goButton.Text = "Go!!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // tmrReindeer
            // 
            this.tmrReindeer.Interval = 10;
            this.tmrReindeer.Tick += new System.EventHandler(this.tmrReindeer_Tick);
            // 
            // lblSietseCash
            // 
            this.lblSietseCash.AutoSize = true;
            this.lblSietseCash.Location = new System.Drawing.Point(66, 366);
            this.lblSietseCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSietseCash.Name = "lblSietseCash";
            this.lblSietseCash.Size = new System.Drawing.Size(19, 13);
            this.lblSietseCash.TabIndex = 23;
            this.lblSietseCash.Text = "50";
            // 
            // lblLidyCash
            // 
            this.lblLidyCash.AutoSize = true;
            this.lblLidyCash.Location = new System.Drawing.Point(66, 387);
            this.lblLidyCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLidyCash.Name = "lblLidyCash";
            this.lblLidyCash.Size = new System.Drawing.Size(19, 13);
            this.lblLidyCash.TabIndex = 24;
            this.lblLidyCash.Text = "75";
            // 
            // lblFerCash
            // 
            this.lblFerCash.AutoSize = true;
            this.lblFerCash.Location = new System.Drawing.Point(66, 410);
            this.lblFerCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFerCash.Name = "lblFerCash";
            this.lblFerCash.Size = new System.Drawing.Size(19, 13);
            this.lblFerCash.TabIndex = 25;
            this.lblFerCash.Text = "40";
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(22, 440);
            this.lblNamePlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(36, 13);
            this.lblNamePlayer.TabIndex = 26;
            this.lblNamePlayer.Text = "Sietse";
            // 
            // deelnemer1
            // 
            this.deelnemer1.AutoSize = true;
            this.deelnemer1.Checked = true;
            this.deelnemer1.Location = new System.Drawing.Point(12, 366);
            this.deelnemer1.Name = "deelnemer1";
            this.deelnemer1.Size = new System.Drawing.Size(54, 17);
            this.deelnemer1.TabIndex = 27;
            this.deelnemer1.TabStop = true;
            this.deelnemer1.Text = "Sietse";
            this.deelnemer1.UseVisualStyleBackColor = true;
            this.deelnemer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deelnemer1_MouseClick);
            // 
            // deelnemer2
            // 
            this.deelnemer2.AutoSize = true;
            this.deelnemer2.Location = new System.Drawing.Point(12, 387);
            this.deelnemer2.Name = "deelnemer2";
            this.deelnemer2.Size = new System.Drawing.Size(44, 17);
            this.deelnemer2.TabIndex = 28;
            this.deelnemer2.Text = "Lidy";
            this.deelnemer2.UseVisualStyleBackColor = true;
            this.deelnemer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deelnemer1_MouseClick);
            // 
            // deelnemer3
            // 
            this.deelnemer3.AutoSize = true;
            this.deelnemer3.Location = new System.Drawing.Point(13, 408);
            this.deelnemer3.Name = "deelnemer3";
            this.deelnemer3.Size = new System.Drawing.Size(40, 17);
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
            this.textBox1.Location = new System.Drawing.Point(13, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Minimum inzet 5 Euro";
            // 
            // lblfinish1
            // 
            this.lblfinish1.AutoSize = true;
            this.lblfinish1.Location = new System.Drawing.Point(794, 26);
            this.lblfinish1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinish1.Name = "lblfinish1";
            this.lblfinish1.Size = new System.Drawing.Size(28, 13);
            this.lblfinish1.TabIndex = 31;
            this.lblfinish1.Text = "- - - -";
            // 
            // lblfinish2
            // 
            this.lblfinish2.AutoSize = true;
            this.lblfinish2.Location = new System.Drawing.Point(794, 99);
            this.lblfinish2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinish2.Name = "lblfinish2";
            this.lblfinish2.Size = new System.Drawing.Size(28, 13);
            this.lblfinish2.TabIndex = 32;
            this.lblfinish2.Text = "- - - -";
            // 
            // lblfinish4
            // 
            this.lblfinish4.AutoSize = true;
            this.lblfinish4.Location = new System.Drawing.Point(794, 230);
            this.lblfinish4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinish4.Name = "lblfinish4";
            this.lblfinish4.Size = new System.Drawing.Size(28, 13);
            this.lblfinish4.TabIndex = 34;
            this.lblfinish4.Text = "- - - -";
            // 
            // lblfinish3
            // 
            this.lblfinish3.AutoSize = true;
            this.lblfinish3.Location = new System.Drawing.Point(794, 162);
            this.lblfinish3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinish3.Name = "lblfinish3";
            this.lblfinish3.Size = new System.Drawing.Size(28, 13);
            this.lblfinish3.TabIndex = 33;
            this.lblfinish3.Text = "- - - -";
            // 
            // dier4
            // 
            this.dier4.BackColor = System.Drawing.Color.Transparent;
            this.dier4.Image = global::DeGokkers.Properties.Resources.rendeergif2static;
            this.dier4.Location = new System.Drawing.Point(25, 208);
            this.dier4.Name = "dier4";
            this.dier4.Size = new System.Drawing.Size(87, 57);
            this.dier4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier4.TabIndex = 4;
            this.dier4.TabStop = false;
            // 
            // dier3
            // 
            this.dier3.BackColor = System.Drawing.Color.Transparent;
            this.dier3.Image = global::DeGokkers.Properties.Resources.rendeergif2static;
            this.dier3.Location = new System.Drawing.Point(25, 136);
            this.dier3.Name = "dier3";
            this.dier3.Size = new System.Drawing.Size(87, 57);
            this.dier3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier3.TabIndex = 3;
            this.dier3.TabStop = false;
            // 
            // dier2
            // 
            this.dier2.BackColor = System.Drawing.Color.Transparent;
            this.dier2.Image = global::DeGokkers.Properties.Resources.rendeergif2static;
            this.dier2.Location = new System.Drawing.Point(25, 68);
            this.dier2.Name = "dier2";
            this.dier2.Size = new System.Drawing.Size(87, 57);
            this.dier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier2.TabIndex = 2;
            this.dier2.TabStop = false;
            // 
            // dier1
            // 
            this.dier1.BackColor = System.Drawing.Color.Transparent;
            this.dier1.Image = global::DeGokkers.Properties.Resources.rendeergif2static;
            this.dier1.Location = new System.Drawing.Point(25, 0);
            this.dier1.Name = "dier1";
            this.dier1.Size = new System.Drawing.Size(87, 57);
            this.dier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dier1.TabIndex = 1;
            this.dier1.TabStop = false;
            // 
            // Renbaan
            // 
            this.Renbaan.BackColor = System.Drawing.Color.Transparent;
            this.Renbaan.Image = global::DeGokkers.Properties.Resources.renbaan2;
            this.Renbaan.Location = new System.Drawing.Point(-1, -3);
            this.Renbaan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Renbaan.Name = "Renbaan";
            this.Renbaan.Size = new System.Drawing.Size(790, 270);
            this.Renbaan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Renbaan.TabIndex = 36;
            this.Renbaan.TabStop = false;
            // 
            // FormRenbaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(838, 473);
            this.Controls.Add(this.dier1);
            this.Controls.Add(this.lblfinish4);
            this.Controls.Add(this.lblfinish3);
            this.Controls.Add(this.dier2);
            this.Controls.Add(this.lblfinish2);
            this.Controls.Add(this.dier3);
            this.Controls.Add(this.lblfinish1);
            this.Controls.Add(this.dier4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deelnemer3);
            this.Controls.Add(this.deelnemer2);
            this.Controls.Add(this.deelnemer1);
            this.Controls.Add(this.lblNamePlayer);
            this.Controls.Add(this.lblFerCash);
            this.Controls.Add(this.lblLidyCash);
            this.Controls.Add(this.lblSietseCash);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Weddenschap2);
            this.Controls.Add(this.Weddenschap3);
            this.Controls.Add(this.Weddenschap1);
            this.Controls.Add(this.hondNummer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.wedtEuro);
            this.Controls.Add(this.wedtButton);
            this.Controls.Add(this.Renbaan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.Renbaan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wedtButton;
        private System.Windows.Forms.NumericUpDown wedtEuro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown hondNummer;
        private System.Windows.Forms.TextBox Weddenschap1;
        private System.Windows.Forms.TextBox Weddenschap3;
        private System.Windows.Forms.TextBox Weddenschap2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Timer tmrReindeer;
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
        private System.Windows.Forms.PictureBox dier4;
        private System.Windows.Forms.PictureBox dier3;
        private System.Windows.Forms.PictureBox dier2;
        private System.Windows.Forms.PictureBox dier1;
        private System.Windows.Forms.PictureBox Renbaan;
    }
}

