namespace Task06
{
    using System;

    public class Cheking
    {
        /// <summary>
        /// Возвращает строку со списком стилей
        /// </summary>
        public void Styles()
        {
            Console.WriteLine("Введите:\n        1: bold\n        2: italic\n        3: underline ");
        }

        /// <summary>
        /// Метод для проверки выделения жирным
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <param name="box">Массив хранящий значения состояния</param>
        /// <param name="style0">Переменная хранящая значение "None"</param>
        /// <param name="style1">Переменная хранящая значение "Bold"</param>
        /// <param name="style2">Переменная хранящая значение "Italic"</param>
        /// <param name="style3">Переменная хранящая значение "Undeline"</param>
        public void ChekingBold(int number, int[] box, string style0, string style1, string style2, string style3)
        {
            if (number == 1)
            {
                if (box[0] == 1 & box[1] == 0 & box[2] == 0)
                {
                    box[0] = 0;
                    Console.WriteLine("Параметры надписи: {0}", style0);
                    this.Styles();
                }
                else
                {
                    if (box[0] == 0 & box[1] == 0 & box[2] == 0)
                    {
                        box[0] = 1;
                        Console.WriteLine("Параметры надписи: {0}", style1);
                        this.Styles();
                    }
                    else
                    {
                        if (box[0] == 1 & box[1] == 0 & box[2] == 1)
                        {
                            box[0] = 0;
                            Console.WriteLine("Параметры надписи: {0}", style3);
                            this.Styles();
                        }
                        else
                        {
                            if (box[0] == 1 & box[1] == 1 & box[2] == 0)
                            {
                                box[0] = 0;
                                Console.WriteLine("Параметры надписи: {0}", style2);
                                this.Styles();
                            }
                            else
                            {
                                if (box[0] == 0 & box[1] == 1 & box[2] == 0)
                                {
                                    box[0] = 1;
                                    Console.WriteLine("Параметры надписи: {0},{1}", style1, style2);
                                    this.Styles();
                                }
                                else
                                {
                                    if (box[0] == 1 & box[1] == 1 & box[2] == 1)
                                    {
                                        box[0] = 0;
                                        Console.WriteLine("Параметры надписи: {0}, {1}", style2, style3);
                                        this.Styles();
                                    }
                                    else
                                    {
                                        if (box[0] == 0 & box[1] == 1 & box[2] == 1)
                                        {
                                            box[0] = 1;
                                            Console.WriteLine("Параметры надписи: {0}, {1}, {2}", style1, style2, style3);
                                            this.Styles();
                                        }
                                        else
                                        {
                                            if (box[0] == 0 & box[1] == 0 & box[2] == 1)
                                            {
                                                box[0] = 1;
                                                Console.WriteLine("Параметры надписи: {0}, {1}", style1, style3);
                                                this.Styles();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод для проверки выделения курсивом
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <param name="box">Массив хранящий значения состояния</param>
        /// <param name="style0">Переменная хранящая значение "None"</param>
        /// <param name="style1">Переменная хранящая значение "Bold"</param>
        /// <param name="style2">Переменная хранящая значение "Italic"</param>
        /// <param name="style3">Переменная хранящая значение "Undeline"</param>
        public void ChekingItalic(int number, int[] box, string style0, string style1, string style2, string style3)
        {
            if (number == 2)
            {
                if (box[0] == 0 & box[1] == 1 & box[2] == 0)
                {
                    box[1] = 0;
                    Console.WriteLine("Параметры надписи: {0}", style0);
                    this.Styles();
                }
                else
                {
                    if (box[0] == 0 & box[1] == 0 & box[2] == 0)
                    {
                        box[1] = 1;
                        Console.WriteLine("Параметры надписи: {0}", style2);
                        this.Styles();
                    }
                    else
                    {
                        if (box[0] == 0 & box[1] == 1 & box[2] == 1)
                        {
                            box[1] = 0;
                            Console.WriteLine("Параметры надписи: {0}", style3);
                            this.Styles();
                        }
                        else
                        {
                            if (box[0] == 1 & box[1] == 1 & box[2] == 0)
                            {
                                box[1] = 0;
                                Console.WriteLine("Параметры надписи: {0}", style1);
                                this.Styles();
                            }
                            else
                            {
                                if (box[0] == 1 & box[1] == 1 & box[2] == 1)
                                {
                                    box[1] = 0;
                                    Console.WriteLine("Параметры надписи: {0}, {1}", style1, style3);
                                    this.Styles();
                                }
                                else
                                {
                                    if (box[0] == 1 & box[1] == 0 & box[2] == 1)
                                    {
                                        box[1] = 1;
                                        Console.WriteLine("Параметры надписи: {0}, {1}, {2}", style1, style2, style3);
                                        this.Styles();
                                    }
                                    else
                                    {
                                        if (box[0] == 1 & box[1] == 0 & box[2] == 0)
                                        {
                                            box[1] = 1;
                                            Console.WriteLine("Параметры надписи: {0}, {1}", style1, style2);
                                            this.Styles();
                                        }
                                        else
                                        {
                                            if (box[0] == 0 & box[1] == 0 & box[2] == 1)
                                            {
                                                box[1] = 1;
                                                Console.WriteLine("Параметры надписи: {0}, {1}", style2, style3);
                                                this.Styles();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод для проверки подчеркивания
        /// </summary>
        /// <param name="number">Введенное число</param>
        /// <param name="box">Массив хранящий значения состояния</param>
        /// <param name="style0">Переменная хранящая значение "None"</param>
        /// <param name="style1">Переменная хранящая значение "Bold"</param>
        /// <param name="style2">Переменная хранящая значение "Italic"</param>
        /// <param name="style3">Переменная хранящая значение "Undeline"</param>
        public void ChekingUnderline(int number, int[] box, string style0, string style1, string style2, string style3)
        {
            if (number == 3)
            {
                if (box[0] == 0 & box[1] == 0 & box[2] == 1)
                {
                    box[2] = 0;
                    Console.WriteLine("Параметры надписи: {0}", style0);
                    this.Styles();
                }
                else
                {
                    if (box[0] == 0 & box[1] == 0 & box[2] == 0)
                    {
                        box[2] = 1;
                        Console.WriteLine("Параметры надписи: {0}", style3);
                        this.Styles();
                    }
                    else
                    {
                        if (box[0] == 1 & box[1] == 0 & box[2] == 1)
                        {
                            box[2] = 0;
                            Console.WriteLine("Параметры надписи: {0}", style1);
                            this.Styles();
                        }
                        else
                        {
                            if (box[0] == 1 & box[1] == 1 & box[2] == 1)
                            {
                                box[2] = 0;
                                Console.WriteLine("Параметры надписи: {0},{1}", style1, style2);
                                this.Styles();
                            }
                            else
                            {
                                if (box[0] == 0 & box[1] == 1 & box[2] == 0)
                                {
                                    box[2] = 1;
                                    Console.WriteLine("Параметры надписи: {0}, {1}", style2, style3);
                                    this.Styles();
                                }
                                else
                                {
                                    if (box[0] == 1 & box[1] == 1 & box[2] == 0)
                                    {
                                        box[2] = 1;
                                        Console.WriteLine("Параметры надписи: {0}, {1}, {2}", style1, style2, style3);
                                        this.Styles();
                                    }
                                    else
                                    {
                                        if (box[0] == 1 & box[1] == 0 & box[2] == 0)
                                        {
                                            box[2] = 1;
                                            Console.WriteLine("Параметры надписи: {0}, {1}", style1, style3);
                                            this.Styles();
                                        }
                                        else
                                        {
                                            if (box[0] == 0 & box[1] == 1 & box[2] == 1)
                                            {
                                                box[2] = 0;
                                                Console.WriteLine("Параметры надписи: {0}", style2);
                                                this.Styles();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
