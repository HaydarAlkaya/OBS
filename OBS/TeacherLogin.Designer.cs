
namespace OBS
{
    partial class TeacherLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kullanici_TextBox = new System.Windows.Forms.TextBox();
            this.Sifre_TextBox = new System.Windows.Forms.TextBox();
            this.SifreGoster_CheckBox = new System.Windows.Forms.CheckBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kullanici_TextBox
            // 
            this.Kullanici_TextBox.Location = new System.Drawing.Point(95, 15);
            this.Kullanici_TextBox.Name = "Kullanici_TextBox";
            this.Kullanici_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Kullanici_TextBox.TabIndex = 2;
            this.Kullanici_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sifre_TextBox
            // 
            this.Sifre_TextBox.Location = new System.Drawing.Point(95, 58);
            this.Sifre_TextBox.Name = "Sifre_TextBox";
            this.Sifre_TextBox.PasswordChar = '*';
            this.Sifre_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Sifre_TextBox.TabIndex = 3;
            this.Sifre_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SifreGoster_CheckBox
            // 
            this.SifreGoster_CheckBox.AutoSize = true;
            this.SifreGoster_CheckBox.Location = new System.Drawing.Point(202, 60);
            this.SifreGoster_CheckBox.Name = "SifreGoster_CheckBox";
            this.SifreGoster_CheckBox.Size = new System.Drawing.Size(88, 17);
            this.SifreGoster_CheckBox.TabIndex = 5;
            this.SifreGoster_CheckBox.Text = "Sifreyi Goster";
            this.SifreGoster_CheckBox.UseVisualStyleBackColor = true;
            this.SifreGoster_CheckBox.CheckedChanged += new System.EventHandler(this.SifreGoster_CheckBox_CheckedChanged);
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(116, 110);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Giriş";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Login_Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SifreGoster_CheckBox);
            this.groupBox1.Controls.Add(this.Kullanici_TextBox);
            this.groupBox1.Controls.Add(this.Sifre_TextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // TeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(313, 182);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeacherLogin";
            this.Text = "TeacherLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kullanici_TextBox;
        private System.Windows.Forms.TextBox Sifre_TextBox;
        private System.Windows.Forms.CheckBox SifreGoster_CheckBox;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}