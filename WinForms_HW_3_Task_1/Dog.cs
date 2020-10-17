namespace HW_WF_2_T1
{
    public class Dog
    {
        /// <summary>
        /// Кличка
        /// </summary>
        public string Nickname { get; }

        /// <summary>
        /// Владелец
        /// </summary>
        public string Owner { get; }

        /// <summary>
        /// Высотка в холке
        /// </summary>
        public double Height { get; }

        public Dog(string nickname, string owner, double height)
        {
            Nickname = nickname;
            Owner = owner;
            Height = height;
        }
    }
}