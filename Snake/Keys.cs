using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Snake
{
    class Keys
    {
        private static Hashtable keyTable = new Hashtable(); //Düğmeleri Belirle     
        public static bool KeyPressed(System.Windows.Forms.Keys key)  //Girişi Kontrol Et
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
        //Giriş Yapıldığında
        public static void ChangeState(System.Windows.Forms.Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
