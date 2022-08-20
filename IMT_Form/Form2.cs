using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMT_Form
{
    public partial class Form2 : Form
    {
    
        public Form2(String Data)
        {
            InitializeComponent();
            //Полученные в качестве аргумента данные напрямую пишем в свойство Text лейбла
            label1.Text = Data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        /// <summary>
        /// Кнопка "Выход" в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
