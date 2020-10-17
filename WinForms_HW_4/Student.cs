using System;

namespace HW_WF_4
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }

        public byte Age { get; set; }

        public int[] Marks { get; set; }

        public override string ToString()
        {
            return "Имя: " + Name + ", возраст: " + Age + " " + ", оценки: " + string.Join(",", Marks);
        }
    }
}
