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
            this.label1 = new System.Windows.Forms.Label();
            this.choosePizza = new System.Windows.Forms.ComboBox();
            this.addToPizza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChoseElem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор пиццы:";
            // 
            // choosePizza
            // 
            this.choosePizza.FormattingEnabled = true;
            this.choosePizza.Location = new System.Drawing.Point(20, 36);
            this.choosePizza.Name = "choosePizza";
            this.choosePizza.Size = new System.Drawing.Size(122, 21);
            this.choosePizza.TabIndex = 1;
            this.choosePizza.SelectedIndexChanged += new System.EventHandler(this.choosePizza_SelectedIndexChanged);
            // 
            // addToPizza
            // 
            this.addToPizza.FormattingEnabled = true;
            this.addToPizza.Location = new System.Drawing.Point(20, 91);
            this.addToPizza.Name = "addToPizza";
            this.addToPizza.Size = new System.Drawing.Size(119, 21);
            this.addToPizza.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дополнительно:";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(191, 37);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(48, 20);
            this.priceBox.TabIndex = 4;
            this.priceBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена:";
            // 
            // ChoseElem
            // 
            this.ChoseElem.Location = new System.Drawing.Point(294, 37);
            this.ChoseElem.Multiline = true;
            this.ChoseElem.Name = "ChoseElem";
            this.ChoseElem.ReadOnly = true;
            this.ChoseElem.Size = new System.Drawing.Size(200, 120);
            this.ChoseElem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавлено в заказ:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 130);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 26);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 202);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChoseElem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addToPizza);
            this.Controls.Add(this.choosePizza);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox choosePizza;
        private System.Windows.Forms.ComboBox addToPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChoseElem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
    }
}

