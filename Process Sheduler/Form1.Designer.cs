namespace Process_Sheduler
{
    partial class Sheduler
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
            this.components = new System.ComponentModel.Container();
            this.AlgorithmLabel = new System.Windows.Forms.Label();
            this.Algorithm = new System.Windows.Forms.ComboBox();
            this.ProcessList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddProcessButton = new System.Windows.Forms.Button();
            this.TimerFIFO = new System.Windows.Forms.Timer(this.components);
            this.TimerRR = new System.Windows.Forms.Timer(this.components);
            this.TimerHPF = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlgorithmLabel
            // 
            this.AlgorithmLabel.AutoSize = true;
            this.AlgorithmLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlgorithmLabel.Location = new System.Drawing.Point(516, 356);
            this.AlgorithmLabel.Name = "AlgorithmLabel";
            this.AlgorithmLabel.Size = new System.Drawing.Size(181, 19);
            this.AlgorithmLabel.TabIndex = 0;
            this.AlgorithmLabel.Text = "Алгоритм планирования:";
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Algorithm.Items.AddRange(new object[] {
            "Очередь (FIFO)",
            "Круговорот (Round Robin)",
            "Приоритетный (HPF)"});
            this.Algorithm.Location = new System.Drawing.Point(517, 378);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(180, 21);
            this.Algorithm.TabIndex = 1;
            this.Algorithm.SelectedIndexChanged += new System.EventHandler(this.Algorithm_SelectedIndexChanged);
            // 
            // ProcessList
            // 
            this.ProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProcessName,
            this.Priority,
            this.Memory,
            this.CP,
            this.State});
            this.ProcessList.Location = new System.Drawing.Point(1, 0);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(510, 456);
            this.ProcessList.TabIndex = 2;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            this.ProcessList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 23;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Имя";
            this.ProcessName.Width = 194;
            // 
            // Priority
            // 
            this.Priority.Text = "Приоритет";
            this.Priority.Width = 75;
            // 
            // Memory
            // 
            this.Memory.Text = "Память";
            this.Memory.Width = 70;
            // 
            // CP
            // 
            this.CP.Text = "ЦП";
            this.CP.Width = 41;
            // 
            // State
            // 
            this.State.Text = "Состояние";
            this.State.Width = 102;
            // 
            // AddProcessButton
            // 
            this.AddProcessButton.Location = new System.Drawing.Point(581, 426);
            this.AddProcessButton.Name = "AddProcessButton";
            this.AddProcessButton.Size = new System.Drawing.Size(116, 30);
            this.AddProcessButton.TabIndex = 3;
            this.AddProcessButton.Text = "Добавить процесс";
            this.AddProcessButton.UseVisualStyleBackColor = true;
            this.AddProcessButton.Click += new System.EventHandler(this.AddProcessButton_Click);
            // 
            // TimerFIFO
            // 
            this.TimerFIFO.Interval = 200;
            this.TimerFIFO.Tick += new System.EventHandler(this.TimerFIFO_Tick);
            // 
            // TimerRR
            // 
            this.TimerRR.Interval = 200;
            this.TimerRR.Tick += new System.EventHandler(this.TimerRR_Tick);
            // 
            // TimerHPF
            // 
            this.TimerHPF.Interval = 200;
            this.TimerHPF.Tick += new System.EventHandler(this.TimerHPF_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(606, 199);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(79, 28);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(606, 243);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(79, 28);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Остановка";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Sheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 468);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.AddProcessButton);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.AlgorithmLabel);
            this.Name = "Sheduler";
            this.Text = "Process Sheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlgorithmLabel;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.ListView ProcessList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader Memory;
        private System.Windows.Forms.ColumnHeader CP;
        private System.Windows.Forms.Button AddProcessButton;
        private System.Windows.Forms.Timer TimerFIFO;
        private System.Windows.Forms.Timer TimerRR;
        private System.Windows.Forms.Timer TimerHPF;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
    }
}

