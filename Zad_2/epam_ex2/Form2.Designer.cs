namespace epam_ex2
{
    partial class Form2
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
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_bin = new System.Windows.Forms.TextBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.radioButton_lib = new System.Windows.Forms.RadioButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_dec
            // 
            this.textBox_dec.Location = new System.Drawing.Point(29, 43);
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.Size = new System.Drawing.Size(100, 20);
            this.textBox_dec.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Десятичное";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Двоичное";
            // 
            // textBox_bin
            // 
            this.textBox_bin.Location = new System.Drawing.Point(221, 43);
            this.textBox_bin.Name = "textBox_bin";
            this.textBox_bin.Size = new System.Drawing.Size(100, 20);
            this.textBox_bin.TabIndex = 2;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(140, 40);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 4;
            this.button_convert.Text = "=>";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // radioButton_lib
            // 
            this.radioButton_lib.AutoSize = true;
            this.radioButton_lib.Location = new System.Drawing.Point(197, 88);
            this.radioButton_lib.Name = "radioButton_lib";
            this.radioButton_lib.Size = new System.Drawing.Size(87, 17);
            this.radioButton_lib.TabIndex = 5;
            this.radioButton_lib.TabStop = true;
            this.radioButton_lib.Text = "Встроенный";
            this.radioButton_lib.UseVisualStyleBackColor = true;
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Location = new System.Drawing.Point(69, 88);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(122, 17);
            this.radioButton_user.TabIndex = 6;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "Пользовательский";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 129);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.radioButton_lib);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_bin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dec);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bin;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.RadioButton radioButton_lib;
        private System.Windows.Forms.RadioButton radioButton_user;
    }
}

