using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        private void PanelAddBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnelviewbooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PanelAddBook_MouseClick(object sender, MouseEventArgs e)
        {
            Add_Book abs = new Add_Book();
            abs.Show();
        }

        private void PanelAddstuduent_MouseClick(object sender, MouseEventArgs e)
        {
            Add_Student ads = new Add_Student();
            ads.Show();
        }

        private void Pnelviewbooks_MouseClick(object sender, MouseEventArgs e)
        {
            View_Books vbs = new View_Books();
            vbs.Show();
        }

        private void Panelviewstudent_MouseClick(object sender, MouseEventArgs e)
        {
            View_Student_Info vsi = new View_Student_Info();
            vsi.Show();
        }

        private void PanelIssuebook_MouseClick(object sender, MouseEventArgs e)
        {
            Issue_Book ib = new Issue_Book();
            ib.Show();
        }

        private void PanelReturnbooks_MouseClick(object sender, MouseEventArgs e)
        {
            Return_book rb = new Return_book();
            rb.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Complete_book_Details cbd = new Complete_book_Details();
            cbd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure you want to exit ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
