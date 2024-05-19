using System;
using System.Collections.Generic;

namespace UserData
{
    // Định nghĩa class UserData
    public class UserData
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public List<float> Scores { get; set; }

        // Constructor để khởi tạo đối tượng UserData
        public UserData(string id, string userName, List<float> scores)
        {
            ID = id;
            UserName = userName;
            Scores = scores;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo list điểm đã cho trước
            List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

            // Khởi tạo đối tượng UserData với ID và userName
            UserData user = new UserData("123456", "Nguyen Van A", ldata);

            // Hiển thị thông tin của user
            Console.WriteLine("ID: " + user.ID);
            Console.WriteLine("UserName: " + user.UserName);
            Console.WriteLine("Scores: " + string.Join(", ", user.Scores));
        }
    }
}
