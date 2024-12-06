namespace WinFormsApp5
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
            groupBoxsayilar = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBoxoperatör = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button1 = new Button();
            groupBoxsayilar.SuspendLayout();
            groupBoxoperatör.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxsayilar
            // 
            groupBoxsayilar.BackColor = SystemColors.ActiveCaption;
            groupBoxsayilar.Controls.Add(maskedTextBox2);
            groupBoxsayilar.Controls.Add(maskedTextBox1);
            groupBoxsayilar.Location = new Point(12, 12);
            groupBoxsayilar.Name = "groupBoxsayilar";
            groupBoxsayilar.Size = new Size(327, 106);
            groupBoxsayilar.TabIndex = 0;
            groupBoxsayilar.TabStop = false;
            groupBoxsayilar.Text = "sayilar";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(29, 59);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(29, 26);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // groupBoxoperatör
            // 
            groupBoxoperatör.BackColor = SystemColors.ActiveCaption;
            groupBoxoperatör.Controls.Add(comboBox1);
            groupBoxoperatör.Location = new Point(12, 135);
            groupBoxoperatör.Name = "groupBoxoperatör";
            groupBoxoperatör.Size = new Size(327, 65);
            groupBoxoperatör.TabIndex = 2;
            groupBoxoperatör.TabStop = false;
            groupBoxoperatör.Text = "operatör";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(29, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 136);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 104);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(12, 218);
            button1.Name = "button1";
            button1.Size = new Size(321, 29);
            button1.TabIndex = 4;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 395);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxoperatör);
            Controls.Add(groupBoxsayilar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxsayilar.ResumeLayout(false);
            groupBoxsayilar.PerformLayout();
            groupBoxoperatör.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxsayilar;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private GroupBox groupBoxoperatör;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
    }
}
