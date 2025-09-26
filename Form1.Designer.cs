namespace WinFormsApp3
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
            DGV = new DataGridView();
            btnAdd = new Button();
            textAddr = new TextBox();
            textLN = new TextBox();
            textFN = new TextBox();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.BackgroundColor = SystemColors.ButtonHighlight;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(257, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 51;
            DGV.Size = new Size(550, 408);
            DGV.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(-6, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textAddr
            // 
            textAddr.Location = new Point(74, 190);
            textAddr.Name = "textAddr";
            textAddr.Size = new Size(168, 27);
            textAddr.TabIndex = 2;
            // 
            // textLN
            // 
            textLN.Location = new Point(89, 106);
            textLN.Name = "textLN";
            textLN.Size = new Size(148, 27);
            textLN.TabIndex = 3;
            // 
            // textFN
            // 
            textFN.Location = new Point(89, 29);
            textFN.Name = "textFN";
            textFN.Size = new Size(148, 27);
            textFN.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(63, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-6, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 6;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-6, 106);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 7;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-6, 190);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(74, 292);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 31);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(161, 292);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 10;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(textFN);
            Controls.Add(textLN);
            Controls.Add(textAddr);
            Controls.Add(btnAdd);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private Button btnAdd;
        private TextBox textAddr;
        private TextBox textLN;
        private TextBox textFN;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnUpdate;
        private Button button1;
    }
}
