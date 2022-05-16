using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace projekt
{
    public partial class negyedikoldal : UserControl
    {
        public static string name = "";
        public static int price = 0;
        public static int quantity = 0;
        public static int sum = 0;
        public static bool isChanged = false;


        public negyedikoldal()
        {
            InitializeComponent();

            listView1.ContextMenuStrip = menuMain;

            #region timer settings
            /*timer1.Enabled = true;
            timer1.Interval = 100;*/
            #endregion

            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isChanged)
            {
                sum = price * quantity;

                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add($"{Convert.ToString(price)} Ft");
                item.SubItems.Add(Convert.ToString(quantity));
                item.SubItems.Add(Convert.ToString(sum) +"Ft" );
                listView1.Items.Add(item);


                EndSum();

                isChanged = false;
            }
        }

        private void EndSum()
        {
            
            try
            {
int sumtemp = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    sumtemp += Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                }

                textBox1.Text = Convert.ToString(sumtemp);
            }
            catch
            {
                textBox1.Text = "";
            }
        }


        private void MenuDelete_Click(object sender, EventArgs e)
        {
            listView1.LabelEdit = true;
            try
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            EndSum();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuMain.Show(this, new System.Drawing.Point(e.X, e.Y));
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            EndSum();
        }



        private void Excl_Click(object sender, EventArgs e)
        {

             /*Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
             xla.Visible = true;
             Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
             Worksheet ws = (Worksheet)xla.ActiveSheet;
             ws.Cells[1, 1] = "Termék";
                     ws.Cells[1, 2] = "Ár";
                     ws.Cells[1, 3] = "Db";
                     ws.Cells[1, 4] = "Összár";
             int i = 2, j = 1;
             foreach(ListViewItem comp in listView1.Items)
             {
                 ws.Cells[i, j] = comp.Text.ToString();
                 foreach(ListViewItem.ListViewSubItem drv in comp.SubItems)
                 {
                     ws.Cells[i, j] = drv.Text.ToString();
                     j++;
                 }
                 j = 1;
                 i++;              
             }
             */


            /*
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Termék";
                    ws.Cells[1, 2] = "Ár";
                    ws.Cells[1, 3] = "Db";
                    ws.Cells[1, 4] = "Összár";
                    int i = 2;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Exportálva", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            */

        }
    }
}
