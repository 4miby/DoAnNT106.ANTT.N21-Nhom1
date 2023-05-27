using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocaro
{
    class register
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Elo { get; set; }
        private static string error = "Phone number doesn't exist!";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(register user1, register user2)
        {
            if (user1 == null || user2 == null) return false;
            if (user1.Password != user2.Password)
            {
                error = "Wrong password";
                return false;
            }
            return true;
        }
    }
}
