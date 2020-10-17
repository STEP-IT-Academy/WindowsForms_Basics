using System.Windows.Forms;

namespace WindowsForms_TicTacToe
{
    public class MyButton : Button
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Symbol { get; set; }

        public bool IsEmpty { get; set; } = true;

        public static bool operator==(MyButton myButton1, MyButton myButton2) => myButton1?.Symbol == myButton2?.Symbol;

        public static bool operator!=(MyButton myButton1, MyButton myButton2) => !(myButton1 == myButton2);

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj) => base.Equals(obj);
    }
}