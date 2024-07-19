namespace Pawsitive
{
    partial class StaffMlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Loginpicbox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Userbox = new System.Windows.Forms.PictureBox();
            this.Passbox = new System.Windows.Forms.PictureBox();
            this.Backbox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Loginpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Userbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(87, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(87, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Loginpicbox
            // 
            this.Loginpicbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loginpicbox.BackColor = System.Drawing.Color.Transparent;
            this.Loginpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Loginpicbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Loginpicbox.Image = global::Pawsitive.Properties.Resources.Usermain;
            this.Loginpicbox.Location = new System.Drawing.Point(176, 119);
            this.Loginpicbox.Name = "Loginpicbox";
            this.Loginpicbox.Size = new System.Drawing.Size(106, 106);
            this.Loginpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Loginpicbox.TabIndex = 4;
            this.Loginpicbox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // Userbox
            // 
            this.Userbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Userbox.BackColor = System.Drawing.Color.Transparent;
            this.Userbox.Image = global::Pawsitive.Properties.Resources.Male_User;
            this.Userbox.Location = new System.Drawing.Point(38, 270);
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(43, 40);
            this.Userbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Userbox.TabIndex = 7;
            this.Userbox.TabStop = false;
            this.Userbox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Passbox
            // 
            this.Passbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passbox.BackColor = System.Drawing.Color.Transparent;
            this.Passbox.Image = global::Pawsitive.Properties.Resources.password;
            this.Passbox.Location = new System.Drawing.Point(38, 347);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(43, 40);
            this.Passbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Passbox.TabIndex = 8;
            this.Passbox.TabStop = false;
            // 
            // Backbox
            // 
            this.Backbox.BackColor = System.Drawing.Color.Transparent;
            this.Backbox.Image = global::Pawsitive.Properties.Resources.Back;
            this.Backbox.Location = new System.Drawing.Point(15, 12);
            this.Backbox.Name = "Backbox";
            this.Backbox.Size = new System.Drawing.Size(37, 34);
            this.Backbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Backbox.TabIndex = 19;
            this.Backbox.TabStop = false;
            this.Backbox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(248, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Forgot Password?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(140, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "No account? Sign up";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(307, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Log In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // StaffMlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pawsitive.Properties.Resources.abstract_gradient_red_geometric_background_vector_2652259;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Backbox);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.Userbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loginpicbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaffMlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Managment";
            ((System.ComponentModel.ISupportInitialize)(this.Loginpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Userbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox Loginpicbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Userbox;
        private System.Windows.Forms.PictureBox Passbox;
        private System.Windows.Forms.PictureBox Backbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}