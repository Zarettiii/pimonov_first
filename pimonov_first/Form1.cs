using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pimonov_first.Classes;

namespace pimonov_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /**
         * Рассчитать цены и отразить результаты на графике 
         */
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //
            // Проверка на заполненность полей
            //
            if
                (
                    txt_a.Text == "" ||
                    txt_b.Text == "" ||
                    txt_c.Text == "" ||
                    txt_d.Text == "" ||
                    txt_q.Text == "" ||
                    txt_n.Text == ""
                )
            {
                MessageBox.Show("Заполните все поля"); // Предупредить в сообщении, о незаполненности полей
            }
            //
            // Произвести расчеты, вывести результаты на график
            //
            else
            {
                //
                // Инициализировать и установить значения с формы экземпляру класса модели с обучением
                //
                c__learning_model lm__model = new c__learning_model(
                                                                        double.Parse(txt_a.Text),
                                                                        double.Parse(txt_b.Text),
                                                                        double.Parse(txt_c.Text),
                                                                        double.Parse(txt_d.Text),
                                                                        double.Parse(txt_q.Text)
                                                                    );


                lm__model.calculate_new_periods(byte.Parse(txt_n.Text)); // Вычислить значения цены для периодов


                chrt_prices.Series["Price"].Points.Clear(); // Очистить график


                List<double> l__d__prices = lm__model.get_prices(); // Получить значения рассчитанных цен


                //
                // Заполнить график
                //
                for (int i__1 = 0; i__1 < l__d__prices.Count; i__1++)
                {
                    chrt_prices.Series["Price"].Points.AddXY(i__1 + 1, l__d__prices[i__1]); // Установить значение 
                }                                                    
            }
        }
    }
}
