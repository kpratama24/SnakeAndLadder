using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Snake_and_Ladder
{
// kelas untuk mendefinisikan posisi player di board
    class PlayerLocation
    {
    //Posisi Player 1 
        public static void Player1Location(int Player1location, PictureBox Player1)
        {
         
            switch (Player1location)
            {
                case 0:
                    Player1.Location = new Point(45, 528);
                    break;
                case 1:
                    Player1.Location = new Point(108, 528);
                    break;
                case 2:
                    Player1.Location = new Point(168, 528);
                    break;
                case 3:
                    Player1.Location = new Point(232, 528);
                    break;
                case 4:
                    Player1.Location = new Point(293, 528);
                    break;
                case 5:
                    Player1.Location = new Point(355, 528);
                    break;
                case 6:
                    Player1.Location = new Point(417, 528);
                    
                    break;
                case 7:
                    Player1.Location = new Point(479, 528);
                    break;
                case 8:
                    Player1.Location = new Point(542, 528);
                    break;
                case 9:
                    Player1.Location = new Point(605, 528);
                    break;
                case 10:
                    Player1.Location = new Point(605, 472);
                    break;
                case 11:
                    Player1.Location = new Point(542, 472);
                    break;
                case 12:
                    Player1.Location = new Point(479, 472);
                   break;
                case 13:
                    Player1.Location = new Point(417, 472);
                    break;
                case 14:
                    Player1.Location = new Point(355, 472);
                    break;
                case 15:
                    Player1.Location = new Point(293, 472);
                    break;
                case 16:
                    Player1.Location = new Point(232, 472);
                    break;
                case 17:
                    Player1.Location = new Point(168, 472);
                    break;
                case 18:
                    Player1.Location = new Point(108, 472);
                    break;
                case 19:
                    Player1.Location = new Point(45, 472);
                    break;
                case 20:
                    Player1.Location = new Point(45, 415);
                    break;
                case 21:
                    Player1.Location = new Point(108, 415);
                    break;
                case 22:
                    Player1.Location = new Point(168, 415);
                    break;
                case 23:
                    Player1.Location = new Point(232, 415);
                    break;
                case 24:
                    Player1.Location = new Point(293, 415);
                    break;
                case 25:
                    Player1.Location = new Point(355, 415);
                    break;
                case 26:
                    Player1.Location = new Point(417, 415);
                    break;
                case 27:
                    Player1.Location = new Point(479, 415);
                    break;
                case 28:
                    Player1.Location = new Point(542, 415);
                    break;
                case 29:
                    Player1.Location = new Point(605, 415);
                    break;
                case 30:
                    Player1.Location = new Point(605, 358);
                    break;
                case 31:
                    Player1.Location = new Point(542, 358);
                    break;
                case 32:
                    Player1.Location = new Point(479, 358);
                    break;
                case 33:
                    Player1.Location = new Point(417, 358);
                    break;
                case 34:
                    Player1.Location = new Point(355, 358);
                    break;
                case 35:
                    Player1.Location = new Point(293, 358);
                    break;
                case 36:
                    Player1.Location = new Point(232, 358);
                    break;
                case 37:
                    Player1.Location = new Point(168, 358);
                    break;
                case 38:
                    Player1.Location = new Point(108, 358);
                    break;
                case 39:
                    Player1.Location = new Point(45, 358);
                    break;
                case 40:
                    Player1.Location = new Point(45, 301);
                    break;
                case 41:
                    Player1.Location = new Point(108, 301);
                    break;
                case 42:
                    Player1.Location = new Point(168, 301);
                    break;
                case 43:
                    Player1.Location = new Point(232, 301);
                    break;
                case 44:
                    Player1.Location = new Point(293, 301);
                    break;
                case 45:
                    Player1.Location = new Point(355, 301);
                    break;
                case 46:
                    Player1.Location = new Point(417, 301);
                    break;
                case 47:
                    Player1.Location = new Point(479, 301);
                    break;  
                case 48:
                    Player1.Location = new Point(542, 301);
                    break;
                case 49:
                    Player1.Location = new Point(605, 301);
                    break;
                case 50:
                    Player1.Location = new Point(605, 245);
                    break;
                case 51:
                    Player1.Location = new Point(542, 245);
                    break;
                case 52:
                    Player1.Location = new Point(479, 245);
                    break;
                case 53:
                    Player1.Location = new Point(417, 245);
                    break;
                case 54:
                    Player1.Location = new Point(355, 245);
                    break;
                case 55:
                    Player1.Location = new Point(293, 245);
                    break;
                case 56:
                    Player1.Location = new Point(232, 245);
                    break;
                case 57:
                    Player1.Location = new Point(168, 245);
                    break;
                case 58:
                    Player1.Location = new Point(108, 245);
                    break;
                case 59:
                    Player1.Location = new Point(45, 245);
                    break;
                case 60:
                    Player1.Location = new Point(45, 188);
                    break;
                case 61:
                    Player1.Location = new Point(108, 188);
                    break;
                case 62:
                    Player1.Location = new Point(168, 188);
                    break;
                case 63:
                    Player1.Location = new Point(232, 188);
                    break;
                case 64:
                    Player1.Location = new Point(293, 188);
                    break;
                case 65:
                    Player1.Location = new Point(355, 188);
                    break;
                case 66:
                    Player1.Location = new Point(417, 188);
                    break;
                case 67:
                    Player1.Location = new Point(479, 188);
                    break;
                case 68:
                    Player1.Location = new Point(542, 188);
                    break;
                case 69:
                    Player1.Location = new Point(605, 188);
                    break;
                case 70:
                    Player1.Location = new Point(605, 132);
                    break;
                case 71:
                    Player1.Location = new Point(542, 132);
                    break;
                case 72:
                    Player1.Location = new Point(479, 132);
                    break;
                case 73:
                    Player1.Location = new Point(417, 132);
                    break;
                case 74:
                    Player1.Location = new Point(355, 132);
                    break;
                case 75:
                    Player1.Location = new Point(293, 132);
                    break;
                case 76:
                    Player1.Location = new Point(232, 132);
                    break;
                case 77:
                    Player1.Location = new Point(168, 132);
                    break;
                case 78:
                    Player1.Location = new Point(108, 132);
                    break;
                case 79:
                    Player1.Location = new Point(45, 132);
                    break;
                case 80:
                    Player1.Location = new Point(45, 76);
                    break;
                case 81:
                    Player1.Location = new Point(108, 76);
                    break;
                case 82:
                    Player1.Location = new Point(168, 76);
                    break;
                case 83:
                    Player1.Location = new Point(232, 76);
                    break;
                case 84:
                    Player1.Location = new Point(293, 76);
                    break;
                case 85:
                    Player1.Location = new Point(355, 76);
                    break;
                case 86:
                    Player1.Location = new Point(417, 76);
                    break;
                case 87:
                    Player1.Location = new Point(479, 76);
                    break;
                case 88:
                    Player1.Location = new Point(542, 76);
                    break;
                case 89:
                    Player1.Location = new Point(605, 76);
                    break;
                case 90:
                    Player1.Location = new Point(605, 20);
                    break;
                case 91:
                    Player1.Location = new Point(542, 20);
                    break;
                case 92:
                    Player1.Location = new Point(479, 20);
                    break;
                case 93:
                    Player1.Location = new Point(417, 20);
                    break;
                case 94:
                    Player1.Location = new Point(355, 20);
                    break;
                case 95:
                    Player1.Location = new Point(293, 20);
                    break;
                case 96:
                    Player1.Location = new Point(232, 20);
                    break;
                case 97:
                    Player1.Location = new Point(168, 20);
                    break;
                case 98:
                    Player1.Location = new Point(108, 20);
                    break;
                case 99:
                    Player1.Location = new Point(45, 20);
                    break;
                case 100:
                    Player1.Location = new Point(45, 20);
                    break;
                default:
                    Player1.Location = new Point(45, 20);
                    break;

            }
        }
        //Posisi Player 2 
        public static void Player2Location(int Player2location, PictureBox Player2)
        {
            switch (Player2location)
            {
                case 0:
                    Player2.Location = new Point(45, 528 + 32);
                    break;
                case 1:
                    Player2.Location = new Point(108, 528 + 28);
                    break;
                case 2:
                    Player2.Location = new Point(168, 528 + 28);
                    break;
                case 3:
                    Player2.Location = new Point(232, 528 + 28);
                    break;
                case 4:
                    Player2.Location = new Point(293, 528 + 28);
                    break;
                case 5:
                    Player2.Location = new Point(355, 528 + 28);
                    break;
                case 6:
                    Player2.Location = new Point(417, 528 + 28);

                    break;
                case 7:
                    Player2.Location = new Point(479, 528 + 28);
                    break;
                case 8:
                    Player2.Location = new Point(542, 528 + 28);
                    break;
                case 9:
                    Player2.Location = new Point(605, 528 + 28);
                    break;
                case 10:
                    Player2.Location = new Point(605, 472 + 28);
                    break;
                case 11:
                    Player2.Location = new Point(542, 472 + 28);
                    break;
                case 12:
                    Player2.Location = new Point(479, 472 + 28);
                    break;
                case 13:
                    Player2.Location = new Point(417, 472 + 28);
                    break;
                case 14:
                    Player2.Location = new Point(355, 472 + 28);
                    break;
                case 15:
                    Player2.Location = new Point(293, 472 + 28);
                    break;
                case 16:
                    Player2.Location = new Point(232, 472 + 28);
                    break;
                case 17:
                    Player2.Location = new Point(168, 472 + 28);
                    break;
                case 18:
                    Player2.Location = new Point(108, 472 + 28);
                    break;
                case 19:
                    Player2.Location = new Point(45, 472 + 28);
                    break;
                case 20:
                    Player2.Location = new Point(45, 415 + 28);
                    break;
                case 21:
                    Player2.Location = new Point(108, 415 + 28);
                    break;
                case 22:
                    Player2.Location = new Point(168, 415 + 28);
                    break;
                case 23:
                    Player2.Location = new Point(232, 415 + 28);
                    break;
                case 24:
                    Player2.Location = new Point(293, 415 + 28);
                    break;
                case 25:
                    Player2.Location = new Point(355, 415 + 28);
                    break;
                case 26:
                    Player2.Location = new Point(417, 415 + 28);
                    break;
                case 27:
                    Player2.Location = new Point(479, 415 + 28);
                    break;
                case 28:
                    Player2.Location = new Point(542, 415 + 28);
                    break;
                case 29:
                    Player2.Location = new Point(605, 415 + 28);
                    break;
                case 30:
                    Player2.Location = new Point(605, 358 + 28);
                    break;
                case 31:
                    Player2.Location = new Point(542, 358 + 28);
                    break;
                case 32:
                    Player2.Location = new Point(479, 358 + 28);
                    break;
                case 33:
                    Player2.Location = new Point(417, 358 + 28);
                    break;
                case 34:
                    Player2.Location = new Point(355, 358 + 28);
                    break;
                case 35:
                    Player2.Location = new Point(293, 358 + 28);
                    break;
                case 36:
                    Player2.Location = new Point(232, 358 + 28);
                    break;
                case 37:
                    Player2.Location = new Point(168, 358 + 28);
                    break;
                case 38:
                    Player2.Location = new Point(108, 358 + 28);
                    break;
                case 39:
                    Player2.Location = new Point(45, 358 + 28);
                    break;
                case 40:
                    Player2.Location = new Point(45, 301 + 28);
                    break;
                case 41:
                    Player2.Location = new Point(108, 301 + 28);
                    break;
                case 42:
                    Player2.Location = new Point(168, 301 + 28);
                    break;
                case 43:
                    Player2.Location = new Point(232, 301 + 28);
                    break;
                case 44:
                    Player2.Location = new Point(293, 301 + 28);
                    break;
                case 45:
                    Player2.Location = new Point(355, 301 + 28);
                    break;
                case 46:
                    Player2.Location = new Point(417, 301 + 28);
                    break;
                case 47:
                    Player2.Location = new Point(479, 301 + 28);
                    break;
                case 48:
                    Player2.Location = new Point(542, 301 + 28);
                    break;
                case 49:
                    Player2.Location = new Point(605, 301 + 28);
                    break;
                case 50:
                    Player2.Location = new Point(605, 245 + 28);
                    break;
                case 51:
                    Player2.Location = new Point(542, 245 + 28);
                    break;
                case 52:
                    Player2.Location = new Point(479, 245 + 28);
                    break;
                case 53:
                    Player2.Location = new Point(417, 245 + 28);
                    break;
                case 54:
                    Player2.Location = new Point(355, 245 + 28);
                    break;
                case 55:
                    Player2.Location = new Point(293, 245 + 28);
                    break;
                case 56:
                    Player2.Location = new Point(232, 245 + 28);
                    break;
                case 57:
                    Player2.Location = new Point(168, 245 + 28);
                    break;
                case 58:
                    Player2.Location = new Point(108, 245 + 28);
                    break;
                case 59:
                    Player2.Location = new Point(45, 245 + 28);
                    break;
                case 60:
                    Player2.Location = new Point(45, 188 + 28);
                    break;
                case 61:
                    Player2.Location = new Point(108, 188 + 28);
                    break;
                case 62:
                    Player2.Location = new Point(168, 188 + 28);
                    break;
                case 63:
                    Player2.Location = new Point(232, 188 + 28);
                    break;
                case 64:
                    Player2.Location = new Point(293, 188 + 28);
                    break;
                case 65:
                    Player2.Location = new Point(355, 188 + 28);
                    break;
                case 66:
                    Player2.Location = new Point(417, 188 + 28);
                    break;
                case 67:
                    Player2.Location = new Point(479, 188 + 28);
                    break;
                case 68:
                    Player2.Location = new Point(542, 188 + 28);
                    break;
                case 69:
                    Player2.Location = new Point(605, 188 + 28);
                    break;
                case 70:
                    Player2.Location = new Point(605, 132 + 28);
                    break;
                case 71:
                    Player2.Location = new Point(542, 132 + 28);
                    break;
                case 72:
                    Player2.Location = new Point(479, 132 + 28);
                    break;
                case 73:
                    Player2.Location = new Point(417, 132 + 28);
                    break;
                case 74:
                    Player2.Location = new Point(355, 132 + 28);
                    break;
                case 75:
                    Player2.Location = new Point(293, 132 + 28);
                    break;
                case 76:
                    Player2.Location = new Point(232, 132 + 28);
                    break;
                case 77:
                    Player2.Location = new Point(168, 132 + 28);
                    break;
                case 78:
                    Player2.Location = new Point(108, 132 + 28);
                    break;
                case 79:
                    Player2.Location = new Point(45, 132 + 28);
                    break;
                case 80:
                    Player2.Location = new Point(45, 76 + 28);
                    break;
                case 81:
                    Player2.Location = new Point(108, 76 + 28);
                    break;
                case 82:
                    Player2.Location = new Point(168, 76 + 28);
                    break;
                case 83:
                    Player2.Location = new Point(232, 76 + 28);
                    break;
                case 84:
                    Player2.Location = new Point(293, 76 + 28);
                    break;
                case 85:
                    Player2.Location = new Point(355, 76 + 28);
                    break;
                case 86:
                    Player2.Location = new Point(417, 76 + 28);
                    break;
                case 87:
                    Player2.Location = new Point(479, 76 + 28);
                    break;
                case 88:
                    Player2.Location = new Point(542, 76 + 28);
                    break;
                case 89:
                    Player2.Location = new Point(605, 76 + 28);
                    break;
                case 90:
                    Player2.Location = new Point(605, 20 + 28);
                    break;
                case 91:
                    Player2.Location = new Point(542, 20 + 28);
                    break;
                case 92:
                    Player2.Location = new Point(479, 20 + 28);
                    break;
                case 93:
                    Player2.Location = new Point(417, 20 + 28);
                    break;
                case 94:
                    Player2.Location = new Point(355, 20 + 28);
                    break;
                case 95:
                    Player2.Location = new Point(293, 20 + 28);
                    break;
                case 96:
                    Player2.Location = new Point(232, 20 + 28);
                    break;
                case 97:
                    Player2.Location = new Point(168, 20 + 28);
                    break;
                case 98:
                    Player2.Location = new Point(108, 20 + 28);
                    break;
                case 99:
                    Player2.Location = new Point(45, 20 + 28);
                    break;
                case 100:
                    Player2.Location = new Point(45, 20 + 28);
                    break;
                default:
                    Player2.Location = new Point(45, 20 + 28);
                    break;

            }
        }
    }
}
