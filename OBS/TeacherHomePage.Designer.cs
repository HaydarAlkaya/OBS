
namespace OBS
{
    partial class TeacherHomePage
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
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencılerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devamsızlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nolandırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersOnayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TC_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DogumTarihi_textBox = new System.Windows.Forms.TextBox();
            this.Mail_textBox = new System.Windows.Forms.TextBox();
            this.Soyad_textBox = new System.Windows.Forms.TextBox();
            this.Ad_textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem,
            this.öğrencılerToolStripMenuItem,
            this.dersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gorevToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // gorevToolStripMenuItem
            // 
            this.gorevToolStripMenuItem.Name = "gorevToolStripMenuItem";
            this.gorevToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gorevToolStripMenuItem.Text = "Küçült";
            this.gorevToolStripMenuItem.Click += new System.EventHandler(this.gorevToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cikisToolStripMenuItem.Text = "Cikis";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // öğrencılerToolStripMenuItem
            // 
            this.öğrencılerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciListesiToolStripMenuItem,
            this.devamsızlıkToolStripMenuItem,
            this.nolandırmaToolStripMenuItem,
            this.dersOnayToolStripMenuItem});
            this.öğrencılerToolStripMenuItem.Name = "öğrencılerToolStripMenuItem";
            this.öğrencılerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrencılerToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // devamsızlıkToolStripMenuItem
            // 
            this.devamsızlıkToolStripMenuItem.Name = "devamsızlıkToolStripMenuItem";
            this.devamsızlıkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devamsızlıkToolStripMenuItem.Text = "Devamsızlık";
            this.devamsızlıkToolStripMenuItem.Click += new System.EventHandler(this.devamsızlıkToolStripMenuItem_Click);
            // 
            // nolandırmaToolStripMenuItem
            // 
            this.nolandırmaToolStripMenuItem.Name = "nolandırmaToolStripMenuItem";
            this.nolandırmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nolandırmaToolStripMenuItem.Text = "Notandırma";
            this.nolandırmaToolStripMenuItem.Click += new System.EventHandler(this.nolandırmaToolStripMenuItem_Click);
            // 
            // dersOnayToolStripMenuItem
            // 
            this.dersOnayToolStripMenuItem.Name = "dersOnayToolStripMenuItem";
            this.dersOnayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dersOnayToolStripMenuItem.Text = "Ders Onay";
            this.dersOnayToolStripMenuItem.Click += new System.EventHandler(this.dersOnayToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            this.dersToolStripMenuItem.Click += new System.EventHandler(this.dersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğretmen Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doğum yılı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TC_TextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DogumTarihi_textBox);
            this.groupBox1.Controls.Add(this.Mail_textBox);
            this.groupBox1.Controls.Add(this.Soyad_textBox);
            this.groupBox1.Controls.Add(this.Ad_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // TC_TextBox
            // 
            this.TC_TextBox.Location = new System.Drawing.Point(116, 106);
            this.TC_TextBox.Name = "TC_TextBox";
            this.TC_TextBox.Size = new System.Drawing.Size(100, 20);
            this.TC_TextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TC";
            // 
            // DogumTarihi_textBox
            // 
            this.DogumTarihi_textBox.Location = new System.Drawing.Point(116, 138);
            this.DogumTarihi_textBox.Name = "DogumTarihi_textBox";
            this.DogumTarihi_textBox.Size = new System.Drawing.Size(100, 20);
            this.DogumTarihi_textBox.TabIndex = 9;
            // 
            // Mail_textBox
            // 
            this.Mail_textBox.Location = new System.Drawing.Point(116, 79);
            this.Mail_textBox.Name = "Mail_textBox";
            this.Mail_textBox.Size = new System.Drawing.Size(100, 20);
            this.Mail_textBox.TabIndex = 8;
            // 
            // Soyad_textBox
            // 
            this.Soyad_textBox.Location = new System.Drawing.Point(116, 52);
            this.Soyad_textBox.Name = "Soyad_textBox";
            this.Soyad_textBox.Size = new System.Drawing.Size(100, 20);
            this.Soyad_textBox.TabIndex = 7;
            // 
            // Ad_textBox
            // 
            this.Ad_textBox.Location = new System.Drawing.Point(116, 23);
            this.Ad_textBox.Name = "Ad_textBox";
            this.Ad_textBox.Size = new System.Drawing.Size(100, 20);
            this.Ad_textBox.TabIndex = 6;
            // 
            // TeacherHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(246, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherHomePage";
            this.Text = "TeacherHomePage";
            this.Load += new System.EventHandler(this.TeacherHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DogumTarihi_textBox;
        private System.Windows.Forms.TextBox Mail_textBox;
        private System.Windows.Forms.TextBox Soyad_textBox;
        private System.Windows.Forms.TextBox Ad_textBox;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencılerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devamsızlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nolandırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersOnayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TC_TextBox;
        private System.Windows.Forms.Label label5;
    }
}