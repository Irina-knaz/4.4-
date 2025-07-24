namespace Леша_4._4_домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Для одномерного массива, состоящего из n вводимых с клавиатуры эле-
            ментов (n - не больше 20), вычислить указанное в задании значение.*/

            Console.WriteLine("Введите значения массивов:");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = int.Parse(Console.ReadLine()); 
            }

            // 1) Среднее арифметическое положительных элементов массива.

            int summa = 0;
            int quantityPositiv = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summa = summa + array[i];
                    quantityPositiv++;
                }                                               
            }
            double sredneeArifm = summa / quantityPositiv;
            Console.WriteLine("Среднее арифметическое положительных элементов массива: " + sredneeArifm);

            //2) Произведение элементов, расположенных после наибольшего элемента.

            int proizvedenie = 1;
            int max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++) 
            {
                if (array[i] > max) 
                {
                    max = array[i];
                    index = i;
                }
            }           

            for (int i = index; i < array.Length; i++)
            {                
                    proizvedenie = proizvedenie * array[i];                            
            }
            Console.WriteLine("Произведение элементов, расположенных после наибольшего элемента: " + proizvedenie);

            //3) Сумму элементов массива, расположенных до последнего положительного элемента.

            int sumNegatine = 0;
            int negativElement = 0;

            for (int i = 0; i < array.Length; i++)
            {               
                if (array [i] < 0)
                {
                    negativElement = i;
                    break;
                }             
            }

            for (int i = 0; i < negativElement; i++)
            {
                sumNegatine = sumNegatine + array[i];
            }
            Console.WriteLine("Сумма элементов массива, расположенных до последнего положительного элемента: " + sumNegatine);

            //4) Сумму элементов, расположенных до наименьшего элемента.

            int summaMin = 0;
            int minElement = array [0];
            int indexMin = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array [i];
                    indexMin = i;
                }
            }

            for (int i = 0; i < indexMin; i++)
            {
                summaMin = summaMin + array[i];
            }
            Console.WriteLine("Сумма элементов, расположенных до наименьшего элемента: " + summaMin);

            //5) Среднее арифметическое отрицательных элементов массива.

            int summNegative = 0;
            int quantity = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                { 
                    summNegative = summNegative + array[i];
                    quantity++;
                }              
            }
            Console.WriteLine("Среднее арифметическое отрицательных элементов массива: " + summNegative / quantity);

            //9) Сумму элементов массива, расположенных после последнего элемента, равного нулю.

            int summZero = 0;
            int lastZeroIndex = 0;

            for (int i = array.Length; i > 0; i--)
            {
                if (array[i] == 0)
                {
                    lastZeroIndex = i;
                    break;
                }
            }

            for (int i = lastZeroIndex; i < array.Length; i++)
            {
                summZero = summZero + array[i];
            }
            Console.WriteLine("Сумма элементов массива, расположенных после последнего элемента, равного нулю: " + summZero);
        }
    }
}