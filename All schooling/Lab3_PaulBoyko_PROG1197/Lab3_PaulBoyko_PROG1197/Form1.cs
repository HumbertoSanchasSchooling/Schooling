using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_PaulBoyko_PROG1197
{
    public partial class Queue : Form
    {

        public ToDoQueue nQue = new ToDoQueue();

        public Queue()
        {
            InitializeComponent();            
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            var nToDo = new ToDo(txtAddToDo.Text, ddlPriority.Text);
            nQue.Enqueue(nToDo);
            lblNextOutput.Text = nQue.First.ThingToDo;         
        }

       
    }
}
