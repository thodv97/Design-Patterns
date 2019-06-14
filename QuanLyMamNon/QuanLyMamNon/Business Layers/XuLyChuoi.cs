namespace QuanLyMamNon
{
    class XuLyChuoi
    {
        public static string StringHandling(string str)
        {
            if(str != "")
            {
                string result = "";

                // Cắt các khoảng trắng dư ở đầu và cuối chuỗi
                str = str.Trim();

                // Trong khi còn tìm thấy 2 khoảng trắng thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng
                while (str.IndexOf("  ") != -1)
                {
                    str = str.Replace("  ", " ");
                }

                /*
                 * Cắt chuỗi họ tên ra thành mảng các từ.
                 * Sau đó duyệt mảng để chuẩn hoá từng từ một.
                 * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến firstChar
                 * Cắt các chữ cái còn lại và lưu trong biến otherChar.
                 * Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
                 * Cuối cùng là lưu chữ vừa chuẩn hoá vào biến Result.
                */

                string[] subName = str.Split(' ');

                for (int i = 0; i < subName.Length; i++)
                {
                    string firstChar = subName[i].Substring(0, 1);
                    string otherChar = subName[i].Substring(1);
                    subName[i] = firstChar.ToUpper() + otherChar.ToLower();

                    if (i == subName.Length - 1)
                    {
                        result += subName[i];
                    }
                    else
                    {
                        result += subName[i] + " ";
                    }
                }

                return result;
            }
            return "";
        }
    }
}
