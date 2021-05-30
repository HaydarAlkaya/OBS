
namespace OBS
{
    partial class LoginPage
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
            this.Teacher_Button = new System.Windows.Forms.Button();
            this.Student_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Teacher_Button
            // 
            this.Teacher_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Teacher_Button.Location = new System.Drawing.Point(3, 16);
            this.Teacher_Button.Name = "Teacher_Button";
            this.Teacher_Button.Size = new System.Drawing.Size(277, 95);
            this.Teacher_Button.TabIndex = 0;
            this.Teacher_Button.Text = "Ogretmen";
            this.Teacher_Button.UseVisualStyleBackColor = true;
            this.Teacher_Button.Click += new System.EventHandler(this.Teacher_Button_Click);
            // 
            // Student_Button
            // 
            this.Student_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Student_Button.Location = new System.Drawing.Point(3, 117);
            this.Student_Button.Name = "Student_Button";
            this.Student_Button.Size = new System.Drawing.Size(277, 87);
            this.Student_Button.TabIndex = 1;
            this.Student_Button.Text = "Student";
            this.Student_Button.UseVisualStyleBackColor = true;
            this.Student_Button.Click += new System.EventHandler(this.Student_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Teacher_Button);
            this.groupBox1.Controls.Add(this.Student_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(298, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Teacher_Button;
        private System.Windows.Forms.Button Student_Button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

