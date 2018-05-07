using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    //Nesnelerin Belirlenmesi
    public enum Direction
    {  Up,Down,Left, Right};
    
    public class Object
    {
      
        //Get ve Set <Get çağırmak, Set değişim >
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static bool GameOver { get; set; }
        public static bool GamePause { get; set; }
        public static Direction direction { get; set; }

        public Object()
        {
            Width = 16;
            Height = 16;
            Speed = 15;
            Score = 0;
            GameOver = false;
            GamePause = false;
            direction = Direction.Down;
        }
        //Başlangıç
        public static void ResetSetting(bool SpeedReset)
        {
            Width = 16;
            Height = 16;
            Score = 0;
            GameOver = false;
            GamePause = false;
            direction = Direction.Down;
            if (SpeedReset)
                Speed = 15;
        }
    }
}
