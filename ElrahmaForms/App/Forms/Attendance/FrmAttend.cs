﻿using ElrahmaForms.App.Classes;
using ElrahmaForms.App.Forms;
using MySqlX.XDevAPI.Relational;
using System;
using ElrahmaForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElrahmaForms.App.Forms.Attendance;

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
            LoadTheme();


        }

      
            private void LoadTheme()
            {
                foreach (Control btns in this.Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button)btns;
                        btn.BackColor = ThemeColor.PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    }
                }
                //lblheader.ForeColor = ThemeColor.PrimaryColor;
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
                                MessageBox.Show("مع السلامة  يا " + str[0]+ "\n"+"عدد ساعات العمل " +ds.ToString(@"d\.hh\:mm\:ss"));
                               
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
                row.Cells[0].Value = ds.ToString(@"d\.hh\:mm\:ss");

                
            }

            


            xClsattend.Get();

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnreport_Click_1(object sender, EventArgs e)
        {
            MainForm.instance.OpenChildForm(new FrmAttendReport(), sender , "التقارير");



        }

     

        private void btnempreport_Click(object sender, EventArgs e)
        {
            Form frm= new Form();
            TextBox txt = new TextBox();
            frm.Height= txt.Height + 50;
            frm.Width= txt.Width + 10;
            frm.StartPosition= FormStartPosition.CenterScreen;
            frm.Icon= this.Icon;
            frm.Controls.Add(txt);
            string s = txt.Text;
            txt.PasswordChar ='*';
           // frm.ShowDialog();
             s = txt.Text;
            if(s=="aaaaa")
            {

            }
            MainForm.instance.OpenChildForm(new FrmAttendReport(), sender, "التقارير");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpDetail frm = new FrmEmpDetail();
            frm.Text = "تقرير للموظف";
            frm.BackColor = ThemeColor.PrimaryColor;
            frm.ShowDialog();
        }
    }
}
