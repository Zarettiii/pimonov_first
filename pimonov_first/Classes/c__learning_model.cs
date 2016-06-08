using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pimonov_first.Classes
{

    /**
     * Класс модели с обучением
     */
    class c__learning_model
    {
        private List<double> l__d__price; // Список цен продукта на периодах деятельности
        private Random       rnd__random; // Генератор случайных чисел

        private double d__a_param;     // А параметр
        private double d__b_param;     // B параметр
        private double d__c_param;     // C параметр
        private double d__d_param;     // D параметр

        private double d__reaction; // Показатель реакции

        //private byte b__period_count; // Количество периодов



        /**
         * Конструктор
         * 
         * @param  double  d__a_param_in      А параметр    
         * @param  double  d__b_param_in      B параметр
         * @param  double  d__c_param_in      C параметр
         * @param  double  d__d_param_in      D параметр
         * @param  double  d__reaction_in     Значение реакции производителя (число от 0 до 1)
         * @param  double  d__start_price_in  Начальное значение цены
         */
        public c__learning_model(
                                    double d__a_param_in, 
                                    double d__b_param_in, 
                                    double d__c_param_in, 
                                    double d__d_param_in, 
                                    double d__reaction_in, 
                                    double d__start_price_in
                                )
        {
            rnd__random = new Random(); // Установить генератор случайных чисел

            l__d__price = new List<double>(); // Установить список цен


            //
            // Установить значения параметров
            //
            d__a_param     = d__a_param_in;
            d__b_param     = d__b_param_in;
            d__c_param     = d__c_param_in;
            d__d_param     = d__d_param_in;
            d__reaction    = d__reaction_in;

            l__d__price.Add(d__start_price_in); // Установить начальное значение цены
        }



        /**
         * Вычислить значение цены продукта на новом периоде
         */
        private void calculate_new_price()
        {
            double d__new_price; // Цена, которая будет рассчитана

            //
            // Если у модели не достаточно цен для обучения (меньше двух)
            // то рассчитать цену по классическому закону
            //
            if (l__d__price.Count < 2)
            {
                d__new_price = (d__a_param - 
                                d__c_param - 
                                d__d_param * l__d__price[l__d__price.Count - 1] - 
                                get_random() + 
                                get_random() + 
                                get_random()) 
                               / d__b_param;


                d__new_price = d__new_price * -1; // Костыль (мой код не место для лжи)
            }
            else // Рассчитать по закону модели с обучением 
            {
                d__new_price = l__d__price[l__d__price.Count - 1] -
                               d__reaction *
                                (l__d__price[l__d__price.Count - 1] -
                                 l__d__price[l__d__price.Count - 2]);
            }

            l__d__price.Add(d__new_price); // Добавить новое значение цены в список
        }



        /**
         * Вычислить цены для новых периодов
         * 
         * @param  byte  b__period_count  Количество периодов для которых нужно вычислить цену
         */
        public void calculate_new_periods(byte b__period_count)
        {
            //
            // Если количество периодов отрицательно или равно 0, выйти из функции
            //
            if (b__period_count <= 0)
            {
                return;
            }


            //
            // Вычислить цену для каждого периода
            //
            for (int i__1 = 0; i__1 < b__period_count; i__1++)
            {
                calculate_new_price();
            }
        }



        /**
         * Получить список цен в периодах
         * 
         * @return  List<double>  Список цен в периодах
         */
        public List<double> get_prices()
        {
            return l__d__price; // Вернуть спиоск цен
        }



        /**
         * Получить случайную величину
         * 
         * @return  double  Случайная величина 
         */
        public double get_random()
        {
            return rnd__random.NextDouble();
        }
    }
}
