namespace Process_Sheduler
{
    partial class AddProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MemoryBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.CPLabel = new System.Windows.Forms.Label();
            this.PriorityBox = new System.Windows.Forms.TextBox();
            this.CPBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные нового процесса:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(270, 221);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(77, 25);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(353, 221);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 25);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 57);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(97, 20);
            this.NameBox.TabIndex = 3;
            // 
            // MemoryBox
            // 
            this.MemoryBox.Location = new System.Drawing.Point(12, 105);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Size = new System.Drawing.Size(97, 20);
            this.MemoryBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(8, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 19);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя:";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryLabel.Location = new System.Drawing.Point(8, 80);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(61, 19);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Память:";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLabel.Location = new System.Drawing.Point(151, 80);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(86, 19);
            this.PriorityLabel.TabIndex = 10;
            this.PriorityLabel.Text = "Приоритет:";
            // 
            // CPLabel
            // 
            this.CPLabel.AutoSize = true;
            this.CPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPLabel.Location = new System.Drawing.Point(151, 35);
            this.CPLabel.Name = "CPLabel";
            this.CPLabel.Size = new System.Drawing.Size(34, 19);
            this.CPLabel.TabIndex = 9;
            this.CPLabel.Text = "ЦП:";
            // 
            // PriorityBox
            // 
            this.PriorityBox.Location = new System.Drawing.Point(155, 105);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(97, 20);
            this.PriorityBox.TabIndex = 8;
            // 
            // CPBox
            // 
            this.CPBox.Location = new System.Drawing.Point(155, 57);
            this.CPBox.Name = "CPBox";
            this.CPBox.Size = new System.Drawing.Size(97, 20);
            this.CPBox.TabIndex = 7;
            // 
            // AddProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 258);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.CPLabel);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.CPBox);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MemoryBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProcess";
            this.ShowIcon = false;
            this.Text = "AddProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MemoryBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label CPLabel;
        private System.Windows.Forms.TextBox PriorityBox;
        private System.Windows.Forms.TextBox CPBox;
    }
}