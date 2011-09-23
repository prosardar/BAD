namespace BAD
 {
     partial class SettingsForm
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
             this.button1 = new System.Windows.Forms.Button();
             this.groupBox1 = new System.Windows.Forms.GroupBox();
             this.radioButton3 = new System.Windows.Forms.RadioButton();
             this.radioButton2 = new System.Windows.Forms.RadioButton();
             this.radioButton1 = new System.Windows.Forms.RadioButton();
             this.groupBox2 = new System.Windows.Forms.GroupBox();
             this.label3 = new System.Windows.Forms.Label();
             this.label2 = new System.Windows.Forms.Label();
             this.comboBox3 = new System.Windows.Forms.ComboBox();
             this.comboBox2 = new System.Windows.Forms.ComboBox();
             this.comboBox1 = new System.Windows.Forms.ComboBox();
             this.label1 = new System.Windows.Forms.Label();
             this.groupBox1.SuspendLayout();
             this.groupBox2.SuspendLayout();
             this.SuspendLayout();
             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(213, 134);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(109, 31);
             this.button1.TabIndex = 0;
             this.button1.Text = "Сохранить";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // groupBox1
             // 
             this.groupBox1.Controls.Add(this.radioButton3);
             this.groupBox1.Controls.Add(this.radioButton2);
             this.groupBox1.Controls.Add(this.radioButton1);
             this.groupBox1.Location = new System.Drawing.Point(12, 12);
             this.groupBox1.Name = "groupBox1";
             this.groupBox1.Size = new System.Drawing.Size(164, 116);
             this.groupBox1.TabIndex = 2;
             this.groupBox1.TabStop = false;
             this.groupBox1.Text = "Тип игры";
             // 
             // radioButton3
             // 
             this.radioButton3.AutoSize = true;
             this.radioButton3.Location = new System.Drawing.Point(20, 78);
             this.radioButton3.Name = "radioButton3";
             this.radioButton3.Size = new System.Drawing.Size(120, 17);
             this.radioButton3.TabIndex = 2;
             this.radioButton3.TabStop = true;
             this.radioButton3.Text = "игра компьютеров";
             this.radioButton3.UseVisualStyleBackColor = true;
             this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
             // 
             // radioButton2
             // 
             this.radioButton2.AutoSize = true;
             this.radioButton2.Location = new System.Drawing.Point(20, 55);
             this.radioButton2.Name = "radioButton2";
             this.radioButton2.Size = new System.Drawing.Size(103, 17);
             this.radioButton2.TabIndex = 1;
             this.radioButton2.TabStop = true;
             this.radioButton2.Text = "игра с игроком";
             this.radioButton2.UseVisualStyleBackColor = true;
             this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
             // 
             // radioButton1
             // 
             this.radioButton1.AutoSize = true;
             this.radioButton1.Location = new System.Drawing.Point(20, 32);
             this.radioButton1.Name = "radioButton1";
             this.radioButton1.Size = new System.Drawing.Size(131, 17);
             this.radioButton1.TabIndex = 0;
             this.radioButton1.TabStop = true;
             this.radioButton1.Text = "игра с компьютером";
             this.radioButton1.UseVisualStyleBackColor = true;
             this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
             // 
             // groupBox2
             // 
             this.groupBox2.Controls.Add(this.label3);
             this.groupBox2.Controls.Add(this.label2);
             this.groupBox2.Controls.Add(this.comboBox3);
             this.groupBox2.Controls.Add(this.comboBox2);
             this.groupBox2.Controls.Add(this.comboBox1);
             this.groupBox2.Controls.Add(this.label1);
             this.groupBox2.Location = new System.Drawing.Point(182, 12);
             this.groupBox2.Name = "groupBox2";
             this.groupBox2.Size = new System.Drawing.Size(341, 116);
             this.groupBox2.TabIndex = 3;
             this.groupBox2.TabStop = false;
             this.groupBox2.Text = "Сложность";
             // 
             // label3
             // 
             this.label3.AutoSize = true;
             this.label3.Location = new System.Drawing.Point(186, 61);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(125, 13);
             this.label3.TabIndex = 5;
             this.label3.Text = "Компьютер 2(Красный)";
             // 
             // label2
             // 
             this.label2.AutoSize = true;
             this.label2.Location = new System.Drawing.Point(32, 34);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(71, 13);
             this.label2.TabIndex = 4;
             this.label2.Text = "Компьютера";
             // 
             // comboBox3
             // 
             this.comboBox3.FormattingEnabled = true;
             this.comboBox3.Items.AddRange(new object[] {
            "Лёгкий",
            "Средний",
            "Профи"});
             this.comboBox3.Location = new System.Drawing.Point(109, 31);
             this.comboBox3.Name = "comboBox3";
             this.comboBox3.Size = new System.Drawing.Size(121, 21);
             this.comboBox3.TabIndex = 3;
             // 
             // comboBox2
             // 
             this.comboBox2.FormattingEnabled = true;
             this.comboBox2.Items.AddRange(new object[] {
            "Лёгкий",
            "Средний",
            "Профи"});
             this.comboBox2.Location = new System.Drawing.Point(187, 77);
             this.comboBox2.Name = "comboBox2";
             this.comboBox2.Size = new System.Drawing.Size(121, 21);
             this.comboBox2.TabIndex = 2;
             // 
             // comboBox1
             // 
             this.comboBox1.FormattingEnabled = true;
             this.comboBox1.Items.AddRange(new object[] {
            "Лёгкий",
            "Средний",
            "Профи"});
             this.comboBox1.Location = new System.Drawing.Point(22, 77);
             this.comboBox1.Name = "comboBox1";
             this.comboBox1.Size = new System.Drawing.Size(121, 21);
             this.comboBox1.TabIndex = 1;
             // 
             // label1
             // 
             this.label1.AutoSize = true;
             this.label1.Location = new System.Drawing.Point(25, 61);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(122, 13);
             this.label1.TabIndex = 0;
             this.label1.Text = "Компьютер 1(Жёлтый)";
             // 
             // SettingsForm
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(535, 173);
             this.Controls.Add(this.groupBox2);
             this.Controls.Add(this.groupBox1);
             this.Controls.Add(this.button1);
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
             this.MaximizeBox = false;
             this.MinimizeBox = false;
             this.Name = "SettingsForm";
             this.Text = "Настройки игры";
             this.groupBox1.ResumeLayout(false);
             this.groupBox1.PerformLayout();
             this.groupBox2.ResumeLayout(false);
             this.groupBox2.PerformLayout();
             this.ResumeLayout(false);

         }

         #endregion

         private System.Windows.Forms.Button button1;
         private System.Windows.Forms.GroupBox groupBox1;
         private System.Windows.Forms.RadioButton radioButton3;
         private System.Windows.Forms.RadioButton radioButton2;
         private System.Windows.Forms.RadioButton radioButton1;
         private System.Windows.Forms.GroupBox groupBox2;
         private System.Windows.Forms.Label label3;
         private System.Windows.Forms.Label label2;
         private System.Windows.Forms.ComboBox comboBox3;
         private System.Windows.Forms.ComboBox comboBox2;
         private System.Windows.Forms.ComboBox comboBox1;
         private System.Windows.Forms.Label label1;
     }
 }