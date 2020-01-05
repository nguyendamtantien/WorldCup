using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDamTanTien
{
    class Menu
    {
        public string Name;
        public Menu(string name)
        {
            Name = name;
        }
        //hàm giao diện menu
        public void Display()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                 Bang Menu Chuc Nang                             *");
            Console.WriteLine("*                 1.Xem Danh Sach Sach                            *");
            Console.WriteLine("*                 2.Sap Xep Theo Ten Sach                         *");
            Console.WriteLine("*                 3.Sap Xep Theo Nam San Xuat                     *");
            Console.WriteLine("*                 4.Them Sach                                     *");
            Console.WriteLine("*                 5.Xoa Sach                                      *");
            Console.WriteLine("*                 6.Tim Sach                                      *");
            Console.WriteLine("*                 7.Thoat                                         *");
            Console.WriteLine("*******************************************************************");

        }
        //hàm nhập chức năng 
        public int GetChoice()
        {
            Console.Write("Nhap chuc nang can su dung:\n");
            int numberMenu = Int32.Parse(Console.ReadLine());
            return numberMenu;
        }
        //hàm saybye
        public static void SayBye()
        {
            Console.WriteLine("tam biet");
        }

    }
}