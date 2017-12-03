using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopTask06
{
    class Program
    {
        /*
         Для выделения текстовой надписи можно использовать выделение жирным, курсивом и подчёркиванием.
         Предложите способ хранения информации о выделении надписи и напишите программу, которая позволяет назначать и удалять текстовой надписи выделение:
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы закончить работу с программой нажмите 4\nПараметры надписи: None");
            ListOfStyles();

            ChekingStyles();

            Console.ReadKey();
        }
        /// <summary>
        /// Выводит запись с возможными стилями.
        /// </summary>
        public static void ListOfStyles()
        {
            Console.WriteLine("Введите:\n        1: bold\n        2: italic\n        3: underline ");
        }

        /// <summary>
        /// Выводит строку состояния стилей.
        /// </summary>
        /// <param name="paramStyle">Переменная содержащая параметр стиля</param>
        public static void MessageOfLabelParametre(string paramStyle)
        {
            Console.WriteLine("\nПараметры надписи:{0}", paramStyle);
        }

        /// <summary>
        /// Проверяет какие стили используются. 
        /// </summary>
        public static void ChekingStyles()
        {
            bool bold = false, italic = false, underline = false;
            string paramStyle;
            int styleNumber = 0;

            do
            {
                paramStyle = "";

                int.TryParse(Console.ReadLine(), out styleNumber);
            
                switch (styleNumber)
                {
                    case 1:
                        bold = bold == true ? false : true;
                        break;

                    case 2:
                        italic = italic == true ? false : true;
                        break;

                    case 3:
                        underline = underline == true ? false : true;
                        break;
                }

                if (bold == false & italic == false & underline == false)
                {
                    paramStyle = " None";
                    MessageOfLabelParametre(paramStyle);
                    ListOfStyles();
                }
           

                if (bold == true)
                {
                    paramStyle += " Bold";
                    MessageOfLabelParametre(paramStyle);
                    ListOfStyles();
                }

                if (italic == true)
                {
                    paramStyle += " Italic";
                    MessageOfLabelParametre(paramStyle);
                    ListOfStyles();
                }

                if (underline == true)
                {
                     paramStyle += " Underline";
                    MessageOfLabelParametre(paramStyle);
                    ListOfStyles();
                }

            } while (styleNumber != 4);
        }
    }
}
