namespace Task06
{
using System;

    public class Program
    {
        /*
         Для выделения текстовой надписи можно использовать выделение жирным, курсивом и подчёркиванием.
         Предложите способ хранения информации о выделении надписи и напишите программу, которая позволяет назначать и удалять текстовой надписи выделение:
         */
        public static void Main(string[] args)
        {
            int number;
            string style0 = "None", style1 = "Bold", style2 = "Italic", style3 = "Undeline";

            Cheking a = new Cheking();
            int[] box = new int[] { 0, 0, 0 };

            if (box[0] == 0 & box[1] == 0 & box[2] == 0)
            {
                Console.WriteLine("Параметры надписи: {0}", style0);
                a.Styles();
            }

            do
            {
                int.TryParse(Console.ReadLine(), out number);

                a.ChekingBold(number, box, style0, style1, style2, style3);
                a.ChekingItalic(number, box, style0, style1, style2, style3);
                a.ChekingUnderline(number, box, style0, style1, style2, style3);
            } 
            while (number < 4);//todo pn хардкод и секретное знание

            Console.ReadKey();
        }
    }
}
