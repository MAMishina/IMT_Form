namespace IMT_Form
{
    public partial class Form1 : Form
    {
        PersonIMT pimt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// кнопка рассчитать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true ;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (textBox2.Text == "m" || textBox2.Text == "f")
                {
                    if (Convert.ToInt16(textBox3.Text) > 0 && Convert.ToInt16(textBox3.Text) < 120)
                    {
                        if (Convert.ToInt16(textBox4.Text) > 40 && Convert.ToInt16(textBox4.Text) < 240)
                        {
                            if (Convert.ToInt16(textBox5.Text) > 3 && Convert.ToInt16(textBox5.Text) < 300)
                            {
                                pimt = new PersonIMT(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text),
                                    Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                                string recomendations = pimt.Recomendations();
                                //Создаем экземпляр дочерней формы. В качестве аргумента конструктора указываем значение
                                //свойства Form2.Label1
                                Form frm = new Form2(recomendations);
                                frm.Show();
                                this.Hide(); 
                            }
                            else
                            {
                                MessageBox.Show("Insert error! Check weight. It's must be > 5 and < 300", "Message", MessageBoxButtons.OK);
                                check = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insert error! Check height. It's must be > 40 and < 240", "Message", MessageBoxButtons.OK);
                            check = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert error! Check age. it's must be > 0 and < 120", "Message", MessageBoxButtons.OK);
                        check = false;
                    }
                }
                else
                {
                    MessageBox.Show("Insert error! Check gender. It's must be m or f", "Message", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else
            {
                MessageBox.Show("Insert error! Check name. It's must be not empty", "Message", MessageBoxButtons.OK);
                check = false;
            }
        }

        /// <summary>
        /// кнопка очистить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                Application.Exit();
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