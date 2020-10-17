using System;
using System.Linq;

namespace HW_WF_2
{
    /// <summary>
    /// Класс одномерного массива целых чисел
    /// </summary>
    public class SingleArray
    {
        /// <summary>
        /// Массив целых чисел
        /// </summary>
        int[] array;

        /// <summary>
        /// Св-во для определения длины массива
        /// </summary>
        public int Lenght => array.Length;

        /// <summary>
        /// Индексатор для доступа к элементам поля-массива
        /// </summary>
        /// <param name="i"></param>
        /// <returns>int</returns>
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < array.Length)
                {
                    return array[i];
                }
                else throw new ArgumentOutOfRangeException("Указанный индекс вышел за границы исходного массива");
            }
            set
            {
                array[i] = value;
            }
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="array"></param>
        public SingleArray(int[] array)
        {
            this.array = array ?? throw new ArgumentNullException(nameof(array));
        }

        public SingleArray(int countOfElem)
        {
            array = new int[countOfElem];
        }

        /// <summary>
        /// Метод для вычисления суммы элементов массива
        /// </summary>
        /// <returns>int</returns>
        public int SumOfArrayElem() => array.Sum();

        /// <summary>
        /// Метод для вычисления произведения элементов массива
        /// </summary>
        /// <returns>int</returns>
        public int MultiplicationOfArrayElem()
        {
            if (array.Length != 0)
            {
                int tmp = 1;
                foreach (int item in array)
                {
                    tmp *= item;
                }
                return tmp;
            }
            else throw new ArgumentNullException("Ошибка! Исходный массив пуст.");
        }
    }
}