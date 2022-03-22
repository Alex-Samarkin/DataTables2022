using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.AppointmentsView". При необходимости она может быть перемещена или удалена.
            this.appointmentsViewTableAdapter.Fill(this.database1DataSet.AppointmentsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Appointment". При необходимости она может быть перемещена или удалена.
            this.appointmentTableAdapter.Fill(this.database1DataSet.Appointment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.database1DataSet.Person);

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.AppointmentsView". При необходимости она может быть перемещена или удалена.
            this.appointmentsViewTableAdapter.Fill(this.database1DataSet.AppointmentsView);

        }
    }
}
