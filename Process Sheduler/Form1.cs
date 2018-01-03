using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Sheduler
{
    public partial class Sheduler : Form
    {
        enum Algorithms { FIFO = 0, RR = 1, HPF = 2 };
        enum Columns { Name = 1, Priority = 2, Memory = 3, CP = 4, State = 5 };
        public Int32 CurRRIndex;
        public Int32 MaxPriorityI;
        public Int32 MaxPriority;
        public Sheduler()
        {
            InitializeComponent();
            Algorithm.SelectedItem = Algorithm.Items[0];
        }

        private void Algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerHPF.Stop();
            TimerRR.Stop();
            TimerFIFO.Stop();
            for (int i = 0; i < Program.AddedProcesses.Count; i++)
                ProcessList.Items[i].SubItems[(int)Columns.State].Text = "Ожидает";
        }

        private void TimerFIFO_Tick(object sender, EventArgs e)
        {
            if (Program.AddedProcesses.Count > Program.FirstID)
            {
                ProcessList.Items[Program.FirstID].SubItems[(int)Columns.State].Text = "Выполняется";
                Program.AddedProcesses[Program.FirstID].LifeTime--;
                if (Program.AddedProcesses[Program.FirstID].LifeTime == 0)
                {
                    Program.AddedProcesses.Remove(Program.AddedProcesses[Program.FirstID]);
                    ProcessList.Items.Remove(ProcessList.Items[Program.FirstID]);
                }
            }
        }

        private void TimerRR_Tick(object sender, EventArgs e)
        {
            if (Program.AddedProcesses.Count > CurRRIndex)
            {
                Int32 CurRRIndexNext = (CurRRIndex + 1) % Program.AddedProcesses.Count;
                Int32 CurRRIndexPrev = (CurRRIndex + Program.AddedProcesses.Count - 1) % Program.AddedProcesses.Count;
                if (CurRRIndexPrev!=CurRRIndex)
                    ProcessList.Items[CurRRIndexPrev].SubItems[(int)Columns.State].Text = "Ожидает";
                ProcessList.Items[CurRRIndex].SubItems[(int)Columns.State].Text = "Выполняется";
                Program.AddedProcesses[CurRRIndex].LifeTime--;
                if (Program.AddedProcesses[CurRRIndex].LifeTime == 0)
                {
                    Program.AddedProcesses.Remove(Program.AddedProcesses[CurRRIndex]);
                    ProcessList.Items.Remove(ProcessList.Items[CurRRIndex]);
                }
                CurRRIndex = CurRRIndexNext;
            }
        }

        private void TimerHPF_Tick(object sender, EventArgs e)
        {
            ProcessList.Items[MaxPriorityI].SubItems[(int)Columns.State].Text = "Выполняется";
            Program.AddedProcesses[MaxPriorityI].LifeTime--;
            if (Program.AddedProcesses[MaxPriorityI].LifeTime == 0)
            {
                Program.AddedProcesses.Remove(Program.AddedProcesses[MaxPriorityI]);
                ProcessList.Items.Remove(ProcessList.Items[MaxPriorityI]);
                FindMaxPriority();
            }
        }
        private void FindMaxPriority()
        {
            MaxPriority = 0;
            for(int i=0;i<Program.AddedProcesses.Count;i++)
                if (Program.AddedProcesses[i].Priority > MaxPriority)
                {
                    MaxPriority = Program.AddedProcesses[i].Priority;
                    MaxPriorityI = i;
                }
        }

        private void AddProcessButton_Click(object sender, EventArgs e)
        {
            Program.LastID = Program.AddedProcesses.Count();
            TimerHPF.Stop();
            TimerRR.Stop();
            TimerFIFO.Stop();
            AddProcess DialWindow = new AddProcess();
            DialWindow.ShowDialog();
            if (Program.IsProcesAdded)
            {
                ProcessList.Items.Add(Program.AddedProcesses[Program.LastID].ID.ToString());
                ProcessList.Items[Program.LastID].SubItems.Add(Program.AddedProcesses[Program.LastID].Name);
                ProcessList.Items[Program.LastID].SubItems.Add(Program.AddedProcesses[Program.LastID].Priority.ToString());
                ProcessList.Items[Program.LastID].SubItems.Add(Program.AddedProcesses[Program.LastID].Memory.ToString());
                ProcessList.Items[Program.LastID].SubItems.Add(Program.AddedProcesses[Program.LastID].CP.ToString());
                ProcessList.Items[Program.LastID].SubItems.Add("Ожидает");
                Program.LastID++;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            TimerHPF.Stop();
            TimerRR.Stop();
            TimerFIFO.Stop();
            for (int i = 0; i < Program.AddedProcesses.Count; i++)
                ProcessList.Items[i].SubItems[(int)Columns.State].Text = "Ожидает";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            switch (Algorithm.SelectedIndex)
            {
                case (int)Algorithms.FIFO:
                    TimerFIFO.Start();
                    break;
                case (int)Algorithms.RR:
                    CurRRIndex = 0;
                    TimerRR.Start();
                    break;
                case (int)Algorithms.HPF:
                    FindMaxPriority();
                    TimerHPF.Start();
                    break;
            }
        }
    }
}
