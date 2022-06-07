using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Id:"+txtEmployeeid.Text +"\n"+ "Employee:"+txtEmployeename.Text+"\n"+"Salary:"+txtSalary.Text+"\n"+"Department:"+txtDepartment.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeid.Clear();
            txtEmployeename.Clear();
            txtSalary.Clear();
            txtDepartment.Clear();
        }
    }
}
