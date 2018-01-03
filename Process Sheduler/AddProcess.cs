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
    public partial class AddProcess : Form
    {
        public AddProcess()
        {
            Program.IsProcesAdded = false;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Program.AddedProcesses.Add(new Program.Process());
            Program.AddedProcesses[Program.LastID].Name = NameBox.Text;
            Program.AddedProcesses[Program.LastID].Memory = Int32.Parse(MemoryBox.Text);
            Program.AddedProcesses[Program.LastID].CP = Int32.Parse(CPBox.Text);
            Program.AddedProcesses[Program.LastID].Priority = Int32.Parse(PriorityBox.Text);
            Program.AddedProcesses[Program.LastID].ID = Program.LastID;
            Random rnd = new Random();
            Program.AddedProcesses[Program.LastID].LifeTime = rnd.Next(20, 50);
            Program.IsProcesAdded = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
