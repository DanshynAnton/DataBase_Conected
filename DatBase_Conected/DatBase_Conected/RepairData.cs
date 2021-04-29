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
    public partial class RepairData : Form
    {
        /// <summary>
        /// Ссылка на главную форму
        /// </summary>
        DBForm MainForm;
        public RepairData(DBForm parentForm)
        {
            InitializeComponent();
            MainForm = parentForm;
            //Обнуление корректности данных на главной форме
            MainForm.rep.correct = false;
            //Вставка данных из БД
            tbRepUID_repair_id.Text = MainForm.rep.repair_id;
            tbRepUID_crew_id.Text = MainForm.rep.crew_id;
            tbRepUID_vehicle_id.Text = MainForm.rep.vehicle_id;
            tbRepUID_repair_cost.Text = MainForm.rep.repair_cost;
        }

        /// <summary>
        /// Возвращение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bComplete_Click(object sender, EventArgs e)
        {
            //Передача данных
            MainForm.rep.correct = true;
            MainForm.rep.repair_id = tbRepUID_repair_id.Text;
            MainForm.rep.crew_id = Utilities.StringOrNull(tbRepUID_crew_id.Text);
            MainForm.rep.vehicle_id = Utilities.StringOrNull(tbRepUID_vehicle_id.Text);
            MainForm.rep.repair_cost = Utilities.StringOrNull(tbRepUID_repair_cost.Text);

            this.Close();
        }
    }
}
