
namespace OBS
{
    partial class CourseConfirmation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.False_RadioButton = new System.Windows.Forms.RadioButton();
            this.True_RadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.DersId_textBox = new System.Windows.Forms.TextBox();
            this.Reflesh_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.False_RadioButton);
            this.groupBox3.Controls.Add(this.True_RadioButton);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.DersId_textBox);
            this.groupBox3.Controls.Add(this.Reflesh_Button);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Update_Button);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(0, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 248);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders Onay";
            // 
            // False_RadioButton
            // 
            this.False_RadioButton.AutoSize = true;
            this.False_RadioButton.Location = new System.Drawing.Point(322, 103);
            this.False_RadioButton.Name = "False_RadioButton";
            this.False_RadioButton.Size = new System.Drawing.Size(50, 17);
            this.False_RadioButton.TabIndex = 20;
            this.False_RadioButton.TabStop = true;
            this.False_RadioButton.Text = "False";
            this.False_RadioButton.UseVisualStyleBackColor = true;
            // 
            // True_RadioButton
            // 
            this.True_RadioButton.AutoSize = true;
            this.True_RadioButton.Location = new System.Drawing.Point(245, 103);
            this.True_RadioButton.Name = "True_RadioButton";
            this.True_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.True_RadioButton.TabIndex = 19;
            this.True_RadioButton.TabStop = true;
            this.True_RadioButton.Text = "True";
            this.True_RadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DersId_textBox
            // 
            this.DersId_textBox.Location = new System.Drawing.Point(260, 54);
            this.DersId_textBox.Name = "DersId_textBox";
            this.DersId_textBox.Size = new System.Drawing.Size(100, 20);
            this.DersId_textBox.TabIndex = 17;
            // 
            // Reflesh_Button
            // 
            this.Reflesh_Button.Location = new System.Drawing.Point(49, 262);
            this.Reflesh_Button.Name = "Reflesh_Button";
            this.Reflesh_Button.Size = new System.Drawing.Size(203, 30);
            this.Reflesh_Button.TabIndex = 15;
            this.Reflesh_Button.Text = "Yenile";
            this.Reflesh_Button.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ders ID";
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(466, 38);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(203, 50);
            this.Update_Button.TabIndex = 1;
            this.Update_Button.Text = "Guncelleme";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // CourseConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CourseConfirmation";
            this.Text = "CourseConfirmation";
            this.Load += new System.EventHandler(this.CourseConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DersId_textBox;
        private System.Windows.Forms.Button Reflesh_Button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton False_RadioButton;
        private System.Windows.Forms.RadioButton True_RadioButton;
    }
}