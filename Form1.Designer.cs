namespace SectionC
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
            btnAdd = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblOutput = new Label();
            tblMobilePhones = new ListBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(110, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(387, 273);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 77);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Mobile Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(235, 69);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 4;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(235, 126);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(235, 186);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 134);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 194);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantity";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(159, 9);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(105, 45);
            lblOutput.TabIndex = 9;
            lblOutput.Text = "label4";
            // 
            // tblMobilePhones
            // 
            tblMobilePhones.FormattingEnabled = true;
            tblMobilePhones.ItemHeight = 15;
            tblMobilePhones.Location = new Point(408, 63);
            tblMobilePhones.Name = "tblMobilePhones";
            tblMobilePhones.Size = new Size(365, 154);
            tblMobilePhones.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMobilePhones);
            Controls.Add(lblOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnFind;
        private Button btnDelete;
        private Label label1;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Label label2;
        private Label label3;
        private Label lblOutput;
        private ListBox tblMobilePhones;
    }
}
