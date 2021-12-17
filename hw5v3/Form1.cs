using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace hw5v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void membershipBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membershipBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDataSet_Tim2);

        }

        private void membershipBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.membershipBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDataSet_Tim2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'machine_location_DataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter8.Fill(this.machine_location_DataSet.Machines);
            // TODO: 這行程式碼會將資料載入 'machine_key_search_DataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter6.Fill(this.machine_key_search_DataSet.Machines);
            // TODO: 這行程式碼會將資料載入 'machine_category_DataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter5.Fill(this.machine_category_DataSet.Machines);
            // TODO: 這行程式碼會將資料載入 'machine_driver_DataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter4.Fill(this.machine_driver_DataSet.Machines);
            // TODO: 這行程式碼會將資料載入 'machine_driver_DataSet.Driver' 資料表。您可以視需要進行移動或移除。
            this.driverTableAdapter.Fill(this.machine_driver_DataSet.Driver);
            // TODO: 這行程式碼會將資料載入 'machine_category_DataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.machine_category_DataSet.Categories);
            // TODO: 這行程式碼會將資料載入 'machineDataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter3.Fill(this.machineDataSet.Machines);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim5.Latest_order' 資料表。您可以視需要進行移動或移除。
            this.latest_orderTableAdapter.Fill(this.businessDataSet_Tim5.Latest_order);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim52.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter1.Fill(this.businessDataSet_Tim52.Orders);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim51.Name' 資料表。您可以視需要進行移動或移除。
            this.nameTableAdapter1.Fill(this.businessDataSet_Tim51.Name);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim5.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter4.Fill(this.businessDataSet_Tim5.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim5.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter1.Fill(this.businessDataSet_Tim5.Staff);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim5.Name' 資料表。您可以視需要進行移動或移除。
            this.nameTableAdapter1.Fill(this.businessDataSet_Tim5.Name);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim5.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter1.Fill(this.businessDataSet_Tim5.Orders);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim5.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter2.Fill(this.businessDataSet_Tim5.Machines);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim2.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.businessDataSet_Tim2.Staff);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim22.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.businessDataSet_Tim22.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim22.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.businessDataSet_Tim22.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim22.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter1.Fill(this.businessDataSet_Tim22.Machines);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim22.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.businessDataSet_Tim22.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim2.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter1.Fill(this.businessDataSet_Tim2.Machines);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_TIM4.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter3.Fill(this.businessDataSet_TIM4.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim21.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.businessDataSet_Tim21.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim21.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.businessDataSet_Tim21.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim32.NAME' 資料表。您可以視需要進行移動或移除。
            this.nAMETableAdapter.Fill(this.businessDataSet_Tim32.NAME);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim32.NAME' 資料表。您可以視需要進行移動或移除。
            this.nAMETableAdapter.Fill(this.businessDataSet_Tim32.NAME);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim3.MAXmeberID' 資料表。您可以視需要進行移動或移除。
            this.mAXmeberIDTableAdapter.Fill(this.businessDataSet_Tim3.MAXmeberID);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim2.MAXorderID' 資料表。您可以視需要進行移動或移除。
            this.mAXorderIDTableAdapter.Fill(this.businessDataSet_Tim2.MAXorderID);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim3.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter.Fill(this.businessDataSet_Tim3.Machines);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim31.NAME' 資料表。您可以視需要進行移動或移除。
            this.nAMETableAdapter.Fill(this.businessDataSet_Tim31.NAME);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim3.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter2.Fill(this.businessDataSet_Tim3.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim2.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter.Fill(this.businessDataSet_Tim2.Orders);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.businessDataSet_Tim.DataTable1);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.businessDataSet_Tim.DataTable1);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.businessDataSet_Tim.DataTable1);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.businessDataSet_Tim.DataTable1);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.businessDataSet_Tim.DataTable1);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter1.Fill(this.businessDataSet_Tim.Membership);
            // TODO: 這行程式碼會將資料載入 'businessDataSet_Tim2.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.businessDataSet_Tim2.Membership);

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            membershipTableAdapter2.InsertQuery_Tim(
                Convert.ToInt32(textBox1.Text),
                textBox2.Text,
                Convert.ToInt32(textBox4.Text),
                textBox3.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text

                );
            membershipTableAdapter2.Fill(this.businessDataSet_Tim3.Membership);
            
            MessageBox.Show("sucess!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            membershipTableAdapter2.DeleteQuery_TIM(int.Parse(comboBox1.SelectedValue.ToString()));
            membershipTableAdapter2.Fill(this.businessDataSet_Tim3.Membership);
            MessageBox.Show("sucess!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.DeleteQuery_TIM1(int.Parse(comboBox2.SelectedValue.ToString()));
            ordersTableAdapter.Fill(this.businessDataSet_Tim2.Orders);
            MessageBox.Show("sucess!");
        }

        

        

        private void button4_Click_1(object sender, EventArgs e)
        {
          
            this.ordersTableAdapter1.InsertQuery_TIM7(
                int.Parse(this.comboBox3.SelectedValue.ToString()),
                Convert.ToInt32(this.textBox8.Text),
                int.Parse(this.comboBox4.SelectedValue.ToString()),
                int.Parse(this.comboBox5.SelectedValue.ToString()),
                
                int.Parse(this.comboBox6.SelectedValue.ToString()),
                Convert.ToInt32(this.textBox9.Text),
                this.comboBox7.SelectedText.ToString()
                );
            
            this.ordersTableAdapter1.Fill(this.businessDataSet_Tim5.Orders);
            MessageBox.Show("sucess!");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            membershipTableAdapter4.UpdateQuery_TIM8(

                Convert.ToInt32( textBox10.Text),
                textBox11.Text,
                int.Parse(comboBox8.SelectedValue.ToString())

                );
            membershipTableAdapter4.Fill(this.businessDataSet_Tim5.Membership);
            MessageBox.Show("sucess!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ordersTableAdapter1.UpdateQuery_Tim9(
                Convert.ToInt32(textBox12.Text),
                int.Parse(comboBox10.SelectedValue.ToString()),
                int.Parse(comboBox11.SelectedValue.ToString()),
                comboBox12.SelectedText.ToString(),
                int.Parse(comboBox9.SelectedValue.ToString())
                );
            ordersTableAdapter1.Fill(this.businessDataSet_Tim5.Orders);
            MessageBox.Show("sucess!");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.machinesTableAdapter6.FillBy(this.machine_key_search_DataSet.Machines, keywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.machinesTableAdapter7.Fill(this.mation_location_DataSet_detail.Machines, ((int)(System.Convert.ChangeType(machine_idToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.machinesTableAdapter7.Fill(this.mation_location_DataSet_detail.Machines, ((int)(System.Convert.ChangeType(listBox1.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
