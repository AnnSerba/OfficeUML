namespace OfficeWindowsForm
{
    partial class Input
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxWho = new System.Windows.Forms.ComboBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNameShef = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxWho, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHello, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameShef, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonInput, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxWho
            // 
            this.comboBoxWho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxWho.FormattingEnabled = true;
            this.comboBoxWho.Items.AddRange(new object[] {
            "Юрист",
            "Секретарь",
            "Бухгалтер"});
            this.comboBoxWho.Location = new System.Drawing.Point(96, 28);
            this.comboBoxWho.Name = "comboBoxWho";
            this.comboBoxWho.Size = new System.Drawing.Size(181, 21);
            this.comboBoxWho.TabIndex = 0;
            this.comboBoxWho.Text = "Юрист";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHello.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelHello.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(96, 5);
            this.labelHello.Name = "labelHello";
            this.labelHello.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHello.Size = new System.Drawing.Size(181, 20);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Привет! Кто вы?";
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(96, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Text = "Введите имя";
            // 
            // textBoxNameShef
            // 
            this.textBoxNameShef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameShef.Location = new System.Drawing.Point(96, 104);
            this.textBoxNameShef.Name = "textBoxNameShef";
            this.textBoxNameShef.Size = new System.Drawing.Size(181, 20);
            this.textBoxNameShef.TabIndex = 3;
            this.textBoxNameShef.Text = "Введите имя начальника";
            // 
            // buttonInput
            // 
            this.buttonInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInput.Location = new System.Drawing.Point(96, 129);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(181, 24);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Войти";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(96, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Ввод пароля";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 154);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Input";
            this.Text = "Вход в меню";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxWho;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNameShef;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBox1;
    }
}

