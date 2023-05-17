namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LgepnBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\n\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1753, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fixed Scanner Port";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dissconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.InfoLabel);
            this.tabPage1.Controls.Add(this.LgepnBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ModelBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.testbox);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1753, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Process";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LgepnBox
            // 
            this.LgepnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LgepnBox.Location = new System.Drawing.Point(218, 163);
            this.LgepnBox.Name = "LgepnBox";
            this.LgepnBox.Size = new System.Drawing.Size(514, 40);
            this.LgepnBox.TabIndex = 8;
            this.LgepnBox.TextChanged += new System.EventHandler(this.LgepnBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 41);
            this.label7.TabIndex = 7;
            this.label7.Text = "LGE P/N";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBox
            // 
            this.ModelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModelBox.Location = new System.Drawing.Point(218, 113);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(514, 40);
            this.ModelBox.TabIndex = 6;
            this.ModelBox.TextChanged += new System.EventHandler(this.ModelBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "MODEL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 318);
            this.label2.TabIndex = 1;
            this.label2.Text = "READY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // testbox
            // 
            this.testbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testbox.Location = new System.Drawing.Point(218, 67);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(514, 40);
            this.testbox.TabIndex = 0;
            this.testbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(218, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(514, 40);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "SET(WIP) S/N";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1761, 558);
            this.tabControl1.TabIndex = 2;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Black;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Yellow;
            this.InfoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoLabel.Location = new System.Drawing.Point(6, 485);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(1741, 44);
            this.InfoLabel.TabIndex = 9;
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1753, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Model Change";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "SET P/N";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(514, 41);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Choose from list";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(23, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Find Model";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(248, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 40);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Write P/N";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 41);
            this.label8.TabIndex = 10;
            this.label8.Text = "HS P/N";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SubOutputModelControll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox LgepnBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
    }
}

