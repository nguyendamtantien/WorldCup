
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDamTanTien
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu("Labrary");// tạo menu 
            DSSach ds = new DSSach();//tạo danh sách 
            ds.AddFromFile(); // đọc file
            Home://tạo vòng lặp quay lại Menu
            m.Display();
            switch (m.GetChoice())
            {
                case 1:
                    {
                        SACH.PrintHeader();
                        ds.Xuat();
                        ds.PrintFooter();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("\n\tDanh Sach Theo Ten Sach");
                        SACH.PrintHeader();
                        ds.Namesort();
                        ds.Xuat();
                        ds.PrintFooter();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("\n\tDanh Sach Theo Nam Xuat Ban");
                        SACH.PrintHeader();
                        ds.Publishingyear();
                        ds.Xuat();
                        ds.PrintFooter();
                    }
                    break;
                case 4:
                    {
                        ds.Themsach(new SACH());
                        Console.ReadLine();
                    }
                    goto Home;
                case 5:
                    {                       
                        Console.WriteLine("\n\t-- -- Xoa -- -- ");
                        Console.Write("\tMa sach : ");
                        int i =Convert.ToInt32(Console.ReadLine());
                        ds.Xoa(i);
                    }
                    goto Home;
                case 6:
                    {
                        ds.Find();
                    }
                    break;
                case 7:
                    {
                        Menu.SayBye();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("khong co gia tri");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}