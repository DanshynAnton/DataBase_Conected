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
    public partial class PointData : Form
    {
        /// <summary>
        /// Ссылка на главную форму
        /// </summary>
        DBForm MainForm;

        public PointData(DBForm parentForm)
        {
            InitializeComponent();
            MainForm = parentForm;
            //Обнуление корректности данных на главной форме
            //MainForm.myPoint.correct = false;
        }

        /// <summary>
        /// Возвращение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bComplete_Click(object sender, EventArgs e)
        {
            //Возвращение данных
            //MainForm.myPoint.correct = true;
            //MainForm.myPoint.point_id = tbPointIUD_point_id.Text;
            //MainForm.myPoint.pname = tbPointIUD_pname.Text;
            this.Close();
        }
    }
}
