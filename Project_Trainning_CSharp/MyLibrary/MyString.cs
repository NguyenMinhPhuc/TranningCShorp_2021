using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyString
    {
        //Proper-- Chuyen hoa dau tu
        //input : NGuyen    mINh     phuC
        //Output: Nguyen minh phuc
        /// <summary>
        /// Phương thức chuyển hoa đầu mỗi từ
        /// </summary>
        /// <param name="inputString">Chuỗi nhập vào</param>
        /// <returns>Chuỗi đã được chuyển</returns>
        public static string  Proper(string inputString)
        {
            string result = string.Empty;
            string str = RemoveWhiteSpace(inputString.ToLower());
            char[] charArr = str.ToCharArray();
            charArr[0] = char.ToUpper(charArr[0]);
            //Regular Expressions
            foreach (Match item in Regex.Matches(str,@"\s\S"))
            {
                charArr[item.Index + 1] = item.Value.ToUpper().Trim()[0];
            }
          
            result = new string(charArr);
            return result;
        }

        //xoa khoang trang du
        public static string RemoveWhiteSpace(string inputString)
        {
            string result = string.Empty;
            string str = inputString.Trim();
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            result = regex.Replace(str, " ");
            return result;
        }
        public static string GetAbbreviation(string inputString)
        {
            string result = string.Empty;
            string str = RemoveWhiteSpace(inputString.ToUpper());
            char[] vs = str.ToCharArray();
            result = vs[0].ToString() ;
            string pattern = @"\s\S";
            //Regex regex = new Regex(pattern);
            //MatchCollection matchCollection;
            //matchCollection = regex.Matches(str);
            foreach (Match item in Regex.Matches(str, pattern))
            {
                result += item.Value.Trim()[0];
            }
            return result;
        }

        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởõ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞÕ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỷỹỵ",
            "ÝỲỶỸỴ"
        };
        /// <summary>
        /// Phương thức sử dụng để bỏ dấu tiếng việt.
        /// chuyển một câu có dấu thành một câu không dấu tương ứng.
        /// </summary>
        /// <param name="str">Chuỗi có dấu được truyền vào phương thức</param>
        /// <returns>Chuỗi không dấu tương ứng</returns>
        public static string RemoveVietnameseAccents(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                {
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
                }
            }
            return str;
        }
        //100000000
        public static string ThemDauPhanNgan(int number)
        {
           return string.Format("{0:#,###}", number);
        }
        public static int BoDauPhanNgan(string number)
        {
            return Convert.ToInt32(number.Replace(",", ""));
        }

        public static Hashtable TinhTanSuatTu(string inputString)
        {
            Hashtable hashtable = new Hashtable();
            string[] vs = RemoveWhiteSpace(inputString).Split(' ');
            foreach (string item in vs)
            {
                if(hashtable.ContainsKey(item))
                {
                    hashtable[item] = ((int)hashtable[item]) + 1;
                }
                else
                {
                    hashtable.Add(item, 1);
                }
            }

               return hashtable;
        }
    }
}
