using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElrahmaForms.App.Forms
{
    public partial class FrmAttend : Form
    {
        Clsattend xClsattend = new Clsattend();
        public FrmAttend()
        {
            InitializeComponent();
        }

        private void FrmAttend_Load(object sender, EventArgs e)
        {
            xClsattend.Get();
            dgvattend.DataSource = xClsattend.Dt_Get;
           
        }

     

        private void txtcheckin_Enter(object sender, EventArgs e)
        {
            txtcheckin.Text = "";
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpNO =int.Parse( txtcheckin.Text);
                

                if (xClsattend.XclsDb.Check() == true)
                {

                  

                    if(dgvattend.Rows.Count > 0)
                    {
                        

                        foreach (DataGridViewRow row in dgvattend.Rows)
                        {
                            

                            if ((int)row.Cells[5].Value == EmpNO)
                            {
                                
                                string[] str = row.Cells[1].Value.ToString().Split(' ');
                                TimeSpan ds = DateTime.Now.Subtract(Convert.ToDateTime(row.Cells[2].Value));                                
                                xClsattend.CheckOut(EmpNO, (int)row.Cells[4].Value,ds);
                                xClsattend.Get();
                                dgvattend.DataSource = xClsattend.Dt_Get;
                                MessageBox.Show("مع السلامة  يا " + str[0]+ "\n"+"عدد ساعات العمل " +ds.ToString(@"hh\:mm\:ss"));
                               
                                return;

                            }



                        }


                        xClsattend.CheckIn(EmpNO);
                        xClsattend.Get();
                        dgvattend.DataSource = xClsattend.Dt_Get;

                      

                    }
                    else
                    {

                        xClsattend.CheckIn(EmpNO);
                        xClsattend.Get();
                        dgvattend.DataSource = xClsattend.Dt_Get;


                    }








                }





            }
            catch
            {
                MessageBox.Show("ادخل رقم الموظف!!!!");
            }
            
        }


        
        private void timer_Tick(object sender, EventArgs e)
        {

            
            foreach (DataGridViewRow row in dgvattend.Rows)
            {
                TimeSpan ds = DateTime.Now.Subtract(Convert.ToDateTime(row.Cells[2].Value));
                row.Cells[0].Value = ds.ToString(@"hh\:mm\:ss");

                
            }

            


            xClsattend.Get();

        }

       
    }
}
