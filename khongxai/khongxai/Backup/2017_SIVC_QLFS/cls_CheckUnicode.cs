using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2017_SIVC_QLFS
{
    class cls_CheckUnicode
    {
        public bool CheckFileName(string name)
        {
            bool check = false;
            bool stilk = true; //có tồn tại
            string[] ChuoiSoSanh = new string[] { ".", "+", "|", "A", "B", "C", "D", "Đ", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " ", "-", "_", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for (int i = 0; i < name.Length; i++)
            {
                string kytu = name.Substring(i, 1); // cắt từng ký tự
                foreach (string ma in ChuoiSoSanh)
                {
                    if (kytu.Equals(ma))
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    stilk = false;
                    break;
                }
                check = false;
            }
            return stilk;
        }
    }
}
