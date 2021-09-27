using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение

            #region Задание1
            //
            // ///метод, перемножающий матрицу на число
            // static int[,] MultiplicationByNumber(int[,] Matrix, int Number)
            // {
            //     int[,] result = new int[Matrix.GetLength(0),Matrix.GetLength(1)];
            //
            //     for (int i = 0; i < Matrix.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < Matrix.GetLength(1); j++)
            //         {
            //             result[i, j] += Number * Matrix[i, j];
            //         }
            //     }
            //     return result;
            // }
            //
            // ///метод,который осуществляет сложение двух матриц
            // static int[,] SumOfMatrix(int[,] Matrix1, int[,] Matrix2)
            // {
            //     int[,] result = new int[Matrix1.GetLength(0), Matrix1.GetLength(1)];
            //
            //     for (int i = 0; i < Matrix1.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < Matrix1.GetLength(1); j++)
            //         {
            //             result[i, j] += Matrix1[i, j] + Matrix2[i,j];
            //         }
            //     }
            //     return result;
            // }
            //
            // ///метод,который осуществляет вычитание двух матриц
            // static int[,] DifferenceOfMatrix(int[,] Matrix1, int[,] Matrix2)
            // {
            //     int[,] result = new int[Matrix1.GetLength(0), Matrix1.GetLength(1)];
            //
            //     for (int i = 0; i < Matrix1.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < Matrix1.GetLength(1); j++)
            //         {
            //             result[i, j] += Matrix1[i, j] - Matrix2[i,j];
            //         }
            //     }
            //     return result;
            // }
            //
            // ///метод перемножения матриц
            // static int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
            // {
            //     int[,] result = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
            //
            //     if (Matrix1.GetLength(0) == Matrix2.GetLength(1) && Matrix2.GetLength(0) == Matrix1.GetLength(1))
            //     {
            //         for (int i = 0; i < Matrix1.GetLength(0); i++)
            //         {
            //             for (int j = 0; j < Matrix2.GetLength(1); j++)
            //             {
            //                 for (int k = 0; k < Matrix2.GetLength(1); k++)
            //                 {
            //                     result[i, j] += Matrix1[i, k] * Matrix2[k, j];
            //                 }
            //             }
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Невозможно выполнить действие. Проверьте размерность матриц ");
            //     }
            //     
            //     return result;
            // }
            //
            // Random r = new Random();
            // int[,] firstMatrix = new int[3, 4];
            //
            // Console.WriteLine("First Matrix:");
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         firstMatrix[i, j] = r.Next(15);
            //         Console.Write(firstMatrix[i, j] + " ");
            //
            //     }
            //     Console.WriteLine();
            // }
            //
            // int[,] secondMatrix = new int[4, 3];
            //    
            // Console.WriteLine("Second Matrix:");
            //
            // for (int i = 0; i < 4; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         secondMatrix[i, j] = r.Next(15);
            //         Console.Write(secondMatrix[i, j] + " ");
            //
            //     }
            //     Console.WriteLine();
            // }         
            //
            // var res = MultiplicationByNumber(firstMatrix, 5);
            // Console.WriteLine("Multiplication by a number:");
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         Console.Write($"{res[i,j],3}");
            //     } 
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("Multiplication: ");
            // res = MatrixMultiplication(firstMatrix, secondMatrix);
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.Write($"{res[i,j],8}");
            //     } 
            //     Console.WriteLine();
            // }
            //
            //
            // res = SumOfMatrix(firstMatrix, secondMatrix);
            // Console.WriteLine("Sum:");
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         Console.Write($"{res[i,j],3}");
            //     } 
            //     Console.WriteLine();
            // }
            //
            // res = DifferenceOfMatrix(firstMatrix, secondMatrix);
            // Console.WriteLine("Difference:");
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         Console.Write($"{res[i,j],8}");
            //     } 
            //     Console.WriteLine();
            // }
            
            #endregion

            //
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //

            #region Задание2

            /*static string[] Sort(string Text)
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                string[] words = Text.Split(delimiterChars);
                string temp;

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i].Length > words[j].Length)
                        {
                            temp = words[i];
                            words[i] = words[j];
                            words[j] = temp;
                        }
                    }
                    Console.Write($" {words[i]} ");
                }     

                return words;
            }

            static string MinWord(string[] Text)
            {
                string result = "";
                result = Text[0];                
                return result;
            }
            
            
            static string[] MaxWord(string[] Text)
            {
                string[] maxWord = new string[Text.Length];
                maxWord[0] = Text[Text.Length - 1];
            

                for(int i = Text.Length ; i > 1 ; i--)
                {
                    if (Text[Text.Length-1].Length == Text[i-2].Length)
                    {
                        maxWord[Text.Length - i + 1] = Text[i-2];         
                    }
                }

                Console.WriteLine("Максимальное кол-во символов в словах: ");

                for (int i = 0; i < maxWord.Length; i++)
			    {
                    Console.Write($" {maxWord[i]} ");
			    }
                return maxWord;
            }

            //string text = "A ББ ВВВ ГГГГ ДДДД ДД ЕЕ ЖЖ ЗЗЗ";

            
            //Console.WriteLine($" Минимальное кол-во букв в слове: {res}");

            string text = "A ББ ВВВ,ГГГГ ДДДД.ДД ЕЕ ЖЖ:ЗЗЗЗ";
            Console.WriteLine($"Original text: '{text}'");
            string[] res = new string[0];
            string result = "";

            res = Sort(text);
            result = MinWord(res);
            Console.WriteLine($" Минимальное слово: {result}");
            string[] resultMax = new string[0];
            resultMax = MaxWord(res);
            foreach (string resultmax in resultMax)
            {
                Console.Write($" {resultmax} ");
            }
            Console.ReadKey();*/


            #endregion

            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день

            #region Задание3

               /* static string GetText(string Text)
                {
                    string res = null;
                    char firstSymbol = Text[0];
                    Console.WriteLine(firstSymbol);
                    char symbol = 'A';
                                   
                    for (int i = 1; i < Text.Length - 1; i++)
			        {
                        if (Text[i]!=Text[i+1])
	                    {
                            symbol = Text[i+1];
	                    }     
                        else continue;
                                          
                        res += symbol;
			        }
                    res = firstSymbol + res;
                    return res;
                }

                string statement = "ППППООООООГГГГГООООДДДДДАААААА";
                string result = "";

                result = GetText(statement);
                Console.Write($"{result}");   
                Console.ReadKey();*/

            #endregion
                
            // 
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия


            #region Задание 4

            /*static bool ArithmeticProgression(double[] A)
            {
                double d;
                for (int i = 1; i < A.Length-1; i++)
                {
                    d = A[1] - A[0];
                    if (A[i+1]!=A[i]+d)
                    {
                        return false;
                    }
                }
                return true;
            }
            
            static bool GeometryProgression(double[] A)
            {
                double q;
                for (int i = 0; i < A.Length; i++)
                {
                    q = A[1] / A[0];
                    if (A[i+1] != A[i] * q)
                    {
                        return false;
                    }
                }
                return true;
            }

            static bool Progression(double[] A)
            {
                if (A.Length<3)
                    return false;

                if (ArithmeticProgression(A) | GeometryProgression(A))
                    return true;

                return false;
            }
            
            double[] sequence = {1, 2, 3, 4, 5, 6};
            Console.WriteLine(Progression(sequence));*/

            #endregion

            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
            // Весь код должен быть откоммментирован

            #region Задание 5

            /*static int Method1(int n,int m)
            {
                if (n == 0) return m + 1;

                if (n != 0 && m == 0) return Method1(n - 1, 1);

                if (n > 0 && m > 0)
                    return Method1(n - 1, Method1(n, m - 1));

                return 0;
            }
             
            Console.WriteLine(Method1(2,5));
            Console.WriteLine(Method1(1,2));*/

            #endregion
        }
    }
}
