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
    public partial class PathData : Form
    {
        /// <summary>
        /// Ссылка на главную форму
        /// </summary>
        DBForm MainForm;

        public PathData(DBForm parentForm)
        {
            InitializeComponent();
            MainForm = parentForm;
            //Обнуление корректности данных на главной форме
            MainForm.myPath.correct = false;
            //Вставка данных из БД
            tbPathIUD_passangers.Text = MainForm.myPath.passangers;
            foreach (var elPoint in MainForm.dictPoints)
            {
                lbPathIUD_points.Items.Add(elPoint.Value);
            }
            foreach (var el in MainForm.myPath.pointList)
            {
                if (lbPathIUD_points.Items.Contains(el))
                {
                    lbPathIUD_points.SetSelected(lbPathIUD_points.Items.IndexOf(el), true);
                }
            }
        }

        /// <summary>
        /// Возвращение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bComplete_Click(object sender, EventArgs e)
        {
            //Передача данных на главную форму
            MainForm.myPath.correct = true;
            MainForm.myPath.path_id = tbPathIUD_path_id.Text;
            MainForm.myPath.passangers = Utilities.StringOrNull(tbPathIUD_passangers.Text);
            MainForm.myPath.pointList = new string[lbPathIUD_points.SelectedItems.Count];
            int i = 0;
            foreach (var el in lbPathIUD_points.SelectedItems)
            {
                MainForm.myPath.pointList[i] = el.ToString();
                i++;
            }
            this.Close();
        }
    }
}
