
namespace States_CardGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_Header = new System.Windows.Forms.TextBox();
            this.tb_prediction1 = new System.Windows.Forms.TextBox();
            this.btn_p1c1 = new System.Windows.Forms.Button();
            this.btn_p1c2 = new System.Windows.Forms.Button();
            this.btn_p2c2 = new System.Windows.Forms.Button();
            this.btn_p2c1 = new System.Windows.Forms.Button();
            this.tb_Prediction2 = new System.Windows.Forms.TextBox();
            this.btn_p3c2 = new System.Windows.Forms.Button();
            this.btn_p3c1 = new System.Windows.Forms.Button();
            this.tb_Prediction3 = new System.Windows.Forms.TextBox();
            this.tb_rightCard = new System.Windows.Forms.TextBox();
            this.tb_leftCard = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Reveal = new System.Windows.Forms.Button();
            this.pb_rightCard = new System.Windows.Forms.PictureBox();
            this.pb_leftCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftCard)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(97, 423);
            this.progressBar.Maximum = 3;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(419, 23);
            this.progressBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Progress:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(553, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 380);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "\r\n\r\n__________________________________________________________________";
            // 
            // tb_Header
            // 
            this.tb_Header.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tb_Header.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Header.Location = new System.Drawing.Point(557, 46);
            this.tb_Header.Name = "tb_Header";
            this.tb_Header.Size = new System.Drawing.Size(334, 29);
            this.tb_Header.TabIndex = 8;
            this.tb_Header.Text = "LOCK IN YOUR PREDICTIONS";
            this.tb_Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_prediction1
            // 
            this.tb_prediction1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tb_prediction1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_prediction1.Location = new System.Drawing.Point(645, 96);
            this.tb_prediction1.Name = "tb_prediction1";
            this.tb_prediction1.Size = new System.Drawing.Size(173, 27);
            this.tb_prediction1.TabIndex = 9;
            this.tb_prediction1.Text = "What\'s the Suit?";
            this.tb_prediction1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_p1c1
            // 
            this.btn_p1c1.BackColor = System.Drawing.Color.Turquoise;
            this.btn_p1c1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_p1c1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p1c1.Location = new System.Drawing.Point(609, 129);
            this.btn_p1c1.Name = "btn_p1c1";
            this.btn_p1c1.Size = new System.Drawing.Size(108, 35);
            this.btn_p1c1.TabIndex = 10;
            this.btn_p1c1.Text = "Choice 1";
            this.btn_p1c1.UseVisualStyleBackColor = false;
            this.btn_p1c1.Click += new System.EventHandler(this.btn_p1c1_Click);
            // 
            // btn_p1c2
            // 
            this.btn_p1c2.BackColor = System.Drawing.Color.Turquoise;
            this.btn_p1c2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_p1c2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p1c2.Location = new System.Drawing.Point(747, 129);
            this.btn_p1c2.Name = "btn_p1c2";
            this.btn_p1c2.Size = new System.Drawing.Size(108, 35);
            this.btn_p1c2.TabIndex = 11;
            this.btn_p1c2.Text = "Choice 2";
            this.btn_p1c2.UseVisualStyleBackColor = false;
            this.btn_p1c2.Click += new System.EventHandler(this.btn_p1c2_Click);
            // 
            // btn_p2c2
            // 
            this.btn_p2c2.BackColor = System.Drawing.Color.Turquoise;
            this.btn_p2c2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_p2c2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p2c2.Location = new System.Drawing.Point(747, 227);
            this.btn_p2c2.Name = "btn_p2c2";
            this.btn_p2c2.Size = new System.Drawing.Size(108, 35);
            this.btn_p2c2.TabIndex = 14;
            this.btn_p2c2.Text = "Choice 2";
            this.btn_p2c2.UseVisualStyleBackColor = false;
            this.btn_p2c2.Click += new System.EventHandler(this.btn_p2c2_Click);
            // 
            // btn_p2c1
            // 
            this.btn_p2c1.BackColor = System.Drawing.Color.Turquoise;
            this.btn_p2c1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_p2c1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p2c1.Location = new System.Drawing.Point(609, 227);
            this.btn_p2c1.Name = "btn_p2c1";
            this.btn_p2c1.Size = new System.Drawing.Size(108, 35);
            this.btn_p2c1.TabIndex = 13;
            this.btn_p2c1.Text = "Choice 1";
            this.btn_p2c1.UseVisualStyleBackColor = false;
            this.btn_p2c1.Click += new System.EventHandler(this.btn_p2c1_Click);
            // 
            // tb_Prediction2
            // 
            this.tb_Prediction2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tb_Prediction2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Prediction2.Location = new System.Drawing.Point(644, 194);
            this.tb_Prediction2.Name = "tb_Prediction2";
            this.tb_Prediction2.Size = new System.Drawing.Size(173, 27);
            this.tb_Prediction2.TabIndex = 12;
            this.tb_Prediction2.Text = "Higher or Lower?";
            this.tb_Prediction2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_p3c2
            // 
            this.btn_p3c2.BackColor = System.Drawing.Color.Turquoise;
            this.btn_p3c2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_p3c2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p3c2.Location = new System.Drawing.Point(747, 325);
            this.btn_p3c2.Name = "btn_p3c2";
            this.btn_p3c2.Size = new System.Drawing.Size(108, 35);
            this.btn_p3c2.TabIndex = 17;
            this.btn_p3c2.Text = "Choice 2";
            this.btn_p3c2.UseVisualStyleBackColor = false;
            this.btn_p3c2.Click += new System.EventHandler(this.btn_p3c2_Click);
            // 
            // btn_p3c1
            // 
            this.btn_p3c1.BackColor = System.Drawing.Color.Turquoise;
            this.btn_p3c1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_p3c1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p3c1.Location = new System.Drawing.Point(609, 325);
            this.btn_p3c1.Name = "btn_p3c1";
            this.btn_p3c1.Size = new System.Drawing.Size(108, 35);
            this.btn_p3c1.TabIndex = 16;
            this.btn_p3c1.Text = "Choice 1";
            this.btn_p3c1.UseVisualStyleBackColor = false;
            this.btn_p3c1.Click += new System.EventHandler(this.btn_p3c1_Click);
            // 
            // tb_Prediction3
            // 
            this.tb_Prediction3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tb_Prediction3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Prediction3.Location = new System.Drawing.Point(644, 292);
            this.tb_Prediction3.Name = "tb_Prediction3";
            this.tb_Prediction3.Size = new System.Drawing.Size(173, 27);
            this.tb_Prediction3.TabIndex = 15;
            this.tb_Prediction3.Text = "Same Suit?";
            this.tb_Prediction3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_rightCard
            // 
            this.tb_rightCard.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_rightCard.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_rightCard.Location = new System.Drawing.Point(286, 8);
            this.tb_rightCard.Name = "tb_rightCard";
            this.tb_rightCard.Size = new System.Drawing.Size(230, 27);
            this.tb_rightCard.TabIndex = 18;
            this.tb_rightCard.Text = "rightCard";
            // 
            // tb_leftCard
            // 
            this.tb_leftCard.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_leftCard.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_leftCard.Location = new System.Drawing.Point(27, 8);
            this.tb_leftCard.Name = "tb_leftCard";
            this.tb_leftCard.Size = new System.Drawing.Size(228, 27);
            this.tb_leftCard.TabIndex = 19;
            this.tb_leftCard.Text = "leftCard";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(816, 423);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(82, 25);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Reveal
            // 
            this.btn_Reveal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Reveal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reveal.Location = new System.Drawing.Point(623, 372);
            this.btn_Reveal.Name = "btn_Reveal";
            this.btn_Reveal.Size = new System.Drawing.Size(218, 32);
            this.btn_Reveal.TabIndex = 23;
            this.btn_Reveal.Text = "Check Prediction";
            this.btn_Reveal.UseVisualStyleBackColor = false;
            this.btn_Reveal.Click += new System.EventHandler(this.btn_Reveal_Click);
            // 
            // pb_rightCard
            // 
            this.pb_rightCard.BackColor = System.Drawing.Color.AliceBlue;
            this.pb_rightCard.BackgroundImage = global::States_CardGame.Properties.Resources.Peter_River;
            this.pb_rightCard.Location = new System.Drawing.Point(273, 38);
            this.pb_rightCard.Name = "pb_rightCard";
            this.pb_rightCard.Size = new System.Drawing.Size(255, 379);
            this.pb_rightCard.TabIndex = 1;
            this.pb_rightCard.TabStop = false;
            this.pb_rightCard.Click += new System.EventHandler(this.pb_rightCard_Click);
            // 
            // pb_leftCard
            // 
            this.pb_leftCard.BackColor = System.Drawing.Color.AliceBlue;
            this.pb_leftCard.BackgroundImage = global::States_CardGame.Properties.Resources.Peter_River;
            this.pb_leftCard.Location = new System.Drawing.Point(12, 38);
            this.pb_leftCard.Name = "pb_leftCard";
            this.pb_leftCard.Size = new System.Drawing.Size(255, 379);
            this.pb_leftCard.TabIndex = 22;
            this.pb_leftCard.TabStop = false;
            this.pb_leftCard.Click += new System.EventHandler(this.pb_leftCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(915, 453);
            this.Controls.Add(this.btn_Reveal);
            this.Controls.Add(this.pb_leftCard);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_p3c2);
            this.Controls.Add(this.btn_p3c1);
            this.Controls.Add(this.tb_Prediction3);
            this.Controls.Add(this.btn_p2c2);
            this.Controls.Add(this.btn_p2c1);
            this.Controls.Add(this.tb_Prediction2);
            this.Controls.Add(this.btn_p1c2);
            this.Controls.Add(this.btn_p1c1);
            this.Controls.Add(this.tb_prediction1);
            this.Controls.Add(this.tb_Header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pb_rightCard);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_rightCard);
            this.Controls.Add(this.tb_leftCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_Header;
        private System.Windows.Forms.TextBox tb_prediction1;
        private System.Windows.Forms.Button btn_p1c1;
        private System.Windows.Forms.Button btn_p1c2;
        private System.Windows.Forms.Button btn_p2c2;
        private System.Windows.Forms.Button btn_p2c1;
        private System.Windows.Forms.TextBox tb_Prediction2;
        private System.Windows.Forms.Button btn_p3c2;
        private System.Windows.Forms.Button btn_p3c1;
        private System.Windows.Forms.TextBox tb_Prediction3;
        private System.Windows.Forms.TextBox tb_rightCard;
        private System.Windows.Forms.TextBox tb_leftCard;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Reveal;
        private System.Windows.Forms.PictureBox pb_rightCard;
        private System.Windows.Forms.PictureBox pb_leftCard;
    }
}

