namespace WinFormITEA
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tBoxA = new System.Windows.Forms.TextBox();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.tBoxSum = new System.Windows.Forms.TextBox();
            this.btSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // tBoxA
            // 
            this.tBoxA.Location = new System.Drawing.Point(287, 50);
            this.tBoxA.Name = "tBoxA";
            this.tBoxA.Size = new System.Drawing.Size(100, 20);
            this.tBoxA.TabIndex = 5;
            // 
            // tBoxB
            // 
            this.tBoxB.Location = new System.Drawing.Point(404, 50);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.Size = new System.Drawing.Size(100, 20);
            this.tBoxB.TabIndex = 6;
            // 
            // tBoxSum
            // 
            this.tBoxSum.Location = new System.Drawing.Point(344, 76);
            this.tBoxSum.Name = "tBoxSum";
            this.tBoxSum.Size = new System.Drawing.Size(100, 20);
            this.tBoxSum.TabIndex = 7;
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(358, 108);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(75, 23);
            this.btSum.TabIndex = 8;
            this.btSum.Text = "Сума";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.tBoxSum);
            this.Controls.Add(this.tBoxB);
            this.Controls.Add(this.tBoxA);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tBoxA;
        private System.Windows.Forms.TextBox tBoxB;
        private System.Windows.Forms.TextBox tBoxSum;
        private System.Windows.Forms.Button btSum;
    }
}

