using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_1
{

    class Thongtin
    {
        private string hoten;
        private string masv;
        private string lop;
        private string username;
        private string email;

        public Thongtin(string hoten, string masv, string lop, string username, string email)
        {
            this.hoten = hoten;
            this.masv = masv;
            this.lop = lop;
            this.username = username;
            this.email = email;
        }
        public void InThongTin()
        {
            Console.WriteLine($"Họ tên:\t{hoten}");
            Console.WriteLine($"Mã sinh viên:\t{masv}");
            Console.WriteLine($"Lớp:\t{lop}");
            Console.WriteLine($"GitHub:\t{username}");
            Console.WriteLine($"Email:\t{email}");
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Thongtin thongtin = new Thongtin("Trương Đức Huy", "10122199", "12422TN", "huyhandsome2k4", "shinwolford2004@gmail.com")
            {
                hoten = "Trương Đức Huy",
                masv = "10122199",
                lop = "12422TN",
                username = "Trương Đức Huy",
                email = "shinwolford2004@gmail.com",
            };
            thongtin.InThongTin();
            Console.ReadKey();

        }

    }
}

    
