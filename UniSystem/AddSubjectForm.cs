using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniSystem
{
    public partial class AddSubjectForm : Form
    {
        public string Subject { get; set; }
        public double Grade { get; set; }

        public AddSubjectForm()
        {
            InitializeComponent();
            textBoxSubject.DataBindings.Add(new Binding("Text", this, "Subject"));
            numericUpDownGrade.DataBindings.Add(new Binding("Text", this, "Grade"));
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
