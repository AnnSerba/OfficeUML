namespace OfficeWindowsForm
{
    partial class Menu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonShowNumberPolePayment = new System.Windows.Forms.Button();
            this.buttonShowListDocuments = new System.Windows.Forms.Button();
            this.buttonShowListClients = new System.Windows.Forms.Button();
            this.buttonShowListTasks = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 174);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonShowNumberPolePayment);
            this.groupBox4.Controls.Add(this.buttonShowListDocuments);
            this.groupBox4.Controls.Add(this.buttonShowListClients);
            this.groupBox4.Controls.Add(this.buttonShowListTasks);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(62, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите пункт меню";
            // 
            // buttonShowNumberPolePayment
            // 
            this.buttonShowNumberPolePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowNumberPolePayment.Location = new System.Drawing.Point(3, 112);
            this.buttonShowNumberPolePayment.Name = "buttonShowNumberPolePayment";
            this.buttonShowNumberPolePayment.Size = new System.Drawing.Size(226, 47);
            this.buttonShowNumberPolePayment.TabIndex = 3;
            this.buttonShowNumberPolePayment.Text = "Просмотр и поиск списка номеров и полей об оплате в реестре";
            this.buttonShowNumberPolePayment.UseVisualStyleBackColor = true;
            this.buttonShowNumberPolePayment.Click += new System.EventHandler(this.buttonShowNumberPolePayment_Click);
            // 
            // buttonShowListDocuments
            // 
            this.buttonShowListDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowListDocuments.Location = new System.Drawing.Point(3, 78);
            this.buttonShowListDocuments.Name = "buttonShowListDocuments";
            this.buttonShowListDocuments.Size = new System.Drawing.Size(226, 34);
            this.buttonShowListDocuments.TabIndex = 2;
            this.buttonShowListDocuments.Text = "Просмотр и поиск списка документов реестра";
            this.buttonShowListDocuments.UseVisualStyleBackColor = true;
            this.buttonShowListDocuments.Click += new System.EventHandler(this.buttonShowListDocuments_Click);
            // 
            // buttonShowListClients
            // 
            this.buttonShowListClients.AutoSize = true;
            this.buttonShowListClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowListClients.Location = new System.Drawing.Point(3, 44);
            this.buttonShowListClients.Name = "buttonShowListClients";
            this.buttonShowListClients.Size = new System.Drawing.Size(226, 34);
            this.buttonShowListClients.TabIndex = 1;
            this.buttonShowListClients.Text = "Просмотр и поиск списка клиентов реестра";
            this.buttonShowListClients.UseVisualStyleBackColor = true;
            this.buttonShowListClients.Click += new System.EventHandler(this.buttonShowListClients_Click);
            // 
            // buttonShowListTasks
            // 
            this.buttonShowListTasks.AutoSize = true;
            this.buttonShowListTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowListTasks.Location = new System.Drawing.Point(3, 16);
            this.buttonShowListTasks.Name = "buttonShowListTasks";
            this.buttonShowListTasks.Size = new System.Drawing.Size(226, 28);
            this.buttonShowListTasks.TabIndex = 0;
            this.buttonShowListTasks.Text = "Просмотр и поиск расписания";
            this.buttonShowListTasks.UseVisualStyleBackColor = true;
            this.buttonShowListTasks.Click += new System.EventHandler(this.buttonShowListTasks_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 174);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Меню";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonShowListTasks;
        private System.Windows.Forms.Button buttonShowNumberPolePayment;
        private System.Windows.Forms.Button buttonShowListDocuments;
        private System.Windows.Forms.Button buttonShowListClients;

    }
}