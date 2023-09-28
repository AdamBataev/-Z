namespace WindowsFormsApp1
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.labelSumResult = new System.Windows.Forms.TextBox();
            this.labelProductResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(629, 354);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(135, 69);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Калькуляция";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(38, 27);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(100, 22);
            this.textBoxArray.TabIndex = 1;
            // 
            // labelSumResult
            // 
            this.labelSumResult.Location = new System.Drawing.Point(38, 160);
            this.labelSumResult.Name = "labelSumResult";
            this.labelSumResult.Size = new System.Drawing.Size(100, 22);
            this.labelSumResult.TabIndex = 2;
            // 
            // labelProductResult
            // 
            this.labelProductResult.Location = new System.Drawing.Point(144, 160);
            this.labelProductResult.Name = "labelProductResult";
            this.labelProductResult.Size = new System.Drawing.Size(100, 22);
            this.labelProductResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProductResult);
            this.Controls.Add(this.labelSumResult);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.TextBox labelSumResult;
        private System.Windows.Forms.TextBox labelProductResult;
    }
}

