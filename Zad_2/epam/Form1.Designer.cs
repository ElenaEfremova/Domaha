namespace epam
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
            this.button_pow = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.textBox_degree = new System.Windows.Forms.TextBox();
            this.textBox_acc = new System.Windows.Forms.TextBox();
            this.textBox_var = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_New = new System.Windows.Forms.Label();
            this.label_Pow = new System.Windows.Forms.Label();
            this.button_equal = new System.Windows.Forms.Button();
            this.label_eq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_pow
            // 
            this.button_pow.Location = new System.Drawing.Point(147, 189);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(75, 23);
            this.button_pow.TabIndex = 0;
            this.button_pow.Text = "Math.Pow";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Location = new System.Drawing.Point(52, 189);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(75, 23);
            this.button_sqrt.TabIndex = 1;
            this.button_sqrt.Text = "Ньютон";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_degree
            // 
            this.textBox_degree.Location = new System.Drawing.Point(122, 88);
            this.textBox_degree.Name = "textBox_degree";
            this.textBox_degree.Size = new System.Drawing.Size(100, 20);
            this.textBox_degree.TabIndex = 2;
            // 
            // textBox_acc
            // 
            this.textBox_acc.Location = new System.Drawing.Point(122, 138);
            this.textBox_acc.Name = "textBox_acc";
            this.textBox_acc.Size = new System.Drawing.Size(100, 20);
            this.textBox_acc.TabIndex = 3;
            // 
            // textBox_var
            // 
            this.textBox_var.Location = new System.Drawing.Point(122, 39);
            this.textBox_var.Name = "textBox_var";
            this.textBox_var.Size = new System.Drawing.Size(100, 20);
            this.textBox_var.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Степень корня";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Точность";
            // 
            // label_New
            // 
            this.label_New.AutoSize = true;
            this.label_New.Location = new System.Drawing.Point(311, 54);
            this.label_New.Name = "label_New";
            this.label_New.Size = new System.Drawing.Size(0, 13);
            this.label_New.TabIndex = 8;
            // 
            // label_Pow
            // 
            this.label_Pow.AutoSize = true;
            this.label_Pow.Location = new System.Drawing.Point(311, 138);
            this.label_Pow.Name = "label_Pow";
            this.label_Pow.Size = new System.Drawing.Size(0, 13);
            this.label_Pow.TabIndex = 9;
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(314, 189);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(75, 23);
            this.button_equal.TabIndex = 10;
            this.button_equal.Text = "Сравнить";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // label_eq
            // 
            this.label_eq.AutoSize = true;
            this.label_eq.Location = new System.Drawing.Point(311, 95);
            this.label_eq.Name = "label_eq";
            this.label_eq.Size = new System.Drawing.Size(0, 13);
            this.label_eq.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 246);
            this.Controls.Add(this.label_eq);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.label_Pow);
            this.Controls.Add(this.label_New);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_var);
            this.Controls.Add(this.textBox_acc);
            this.Controls.Add(this.textBox_degree);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button_pow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pow;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.TextBox textBox_degree;
        private System.Windows.Forms.TextBox textBox_acc;
        private System.Windows.Forms.TextBox textBox_var;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_New;
        private System.Windows.Forms.Label label_Pow;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Label label_eq;
    }
}

