using System;

namespace MyNamespace
{
    // Định nghĩa class UserData
    public class UserData
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public int Level { get; set; }

        // Constructor để khởi tạo đối tượng UserData
        public UserData(string id, string username, int level)
        {
            Id = id;
            Username = username;
            Level = level;
        }

        // Phương thức để xuất thông tin người dùng ra console
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Level: {Level}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng UserData với id, username và level
            UserData user = new UserData("123456", "Nguyen Van A", 5);

            // Xuất thông tin của user ra màn hình console
            user.DisplayInfo();
        }
    }
}
