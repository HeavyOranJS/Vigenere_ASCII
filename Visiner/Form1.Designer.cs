namespace Visiner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richKey = new System.Windows.Forms.RichTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCypher = new System.Windows.Forms.RadioButton();
            this.radioButtonDecypher = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.richInput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richKey);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richOutput);
            this.panel1.Controls.Add(this.richInput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 217);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ROT 0",
            "ROT 1"});
            this.comboBox1.Location = new System.Drawing.Point(206, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(259, 157);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(47, 22);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(206, 157);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(47, 22);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key";
            // 
            // richKey
            // 
            this.richKey.Location = new System.Drawing.Point(206, 43);
            this.richKey.Name = "richKey";
            this.richKey.Size = new System.Drawing.Size(100, 37);
            this.richKey.TabIndex = 4;
            this.richKey.Text = "пожалуйста";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(206, 183);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 22);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCypher);
            this.groupBox1.Controls.Add(this.radioButtonDecypher);
            this.groupBox1.Location = new System.Drawing.Point(206, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioButtonCypher
            // 
            this.radioButtonCypher.AutoSize = true;
            this.radioButtonCypher.Checked = true;
            this.radioButtonCypher.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCypher.Name = "radioButtonCypher";
            this.radioButtonCypher.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCypher.TabIndex = 7;
            this.radioButtonCypher.TabStop = true;
            this.radioButtonCypher.Text = "Cipher";
            this.radioButtonCypher.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecypher
            // 
            this.radioButtonDecypher.AutoSize = true;
            this.radioButtonDecypher.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDecypher.Name = "radioButtonDecypher";
            this.radioButtonDecypher.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDecypher.TabIndex = 8;
            this.radioButtonDecypher.Text = "Decipher";
            this.radioButtonDecypher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(312, 16);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(213, 189);
            this.richOutput.TabIndex = 1;
            this.richOutput.Text = "";
            // 
            // richInput
            // 
            this.richInput.Location = new System.Drawing.Point(0, 16);
            this.richInput.Name = "richInput";
            this.richInput.Size = new System.Drawing.Size(200, 190);
            this.richInput.TabIndex = 0;
            this.richInput.Text = "это не лучший пример кода, но он был читсый и рабочий. возьмите меня";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 230);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.RichTextBox richInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richKey;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCypher;
        private System.Windows.Forms.RadioButton radioButtonDecypher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

