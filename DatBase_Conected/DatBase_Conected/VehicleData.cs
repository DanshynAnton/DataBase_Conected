using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatBase_Conected
{
    public partial class VehicleData : Form
    {
        /// <summary>
        /// Ссылка на главную форму
        /// </summary>
        DBForm MainForm;
        public VehicleData(DBForm parentForm)
        {
            InitializeComponent();
            MainForm = parentForm;
            //Обнуление корректности данных на форме
            MainForm.veh.correct = false;
            //Вставка данных из БД
            tbVehIUD_veh_id.Text =  MainForm.veh.veh_id;
            tbVehIUD_plate.Text = MainForm.veh.plate;
            tbVehIUD_box_id.Text = MainForm.veh.box_id;
            tbVehIUD_mileage.Text = MainForm.veh.mileage;
            tbVehIUD_lmc.Text = MainForm.veh.last_month_cost;
            tbVehIUD_fc.Text = MainForm.veh.full_cost;
            tbVehIUD_sdof.Text = MainForm.veh.start_date_of_use;
        }

        /// <summary>
        /// Завершение работы формы. Сохранение результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bComplete_Click(object sender, EventArgs e)
        {
            //Передача данных на главную форму
            MainForm.veh.veh_id = tbVehIUD_veh_id.Text;
            MainForm.veh.plate = tbVehIUD_plate.Text;
            MainForm.veh.box_id = tbVehIUD_box_id.Text;
            MainForm.veh.mileage = Utilities.StringOrNull(tbVehIUD_mileage.Text);
            MainForm.veh.last_month_cost = Utilities.StringOrNull(tbVehIUD_lmc.Text);
            MainForm.veh.full_cost = Utilities.StringOrNull(tbVehIUD_fc.Text);
            MainForm.veh.start_date_of_use = Utilities.StringOrNull(tbVehIUD_sdof.Text);
            MainForm.veh.correct = true;
            this.Close();
        }


    }
}
