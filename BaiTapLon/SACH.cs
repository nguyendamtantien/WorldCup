using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDamTanTien
{
    class SACH
    {
        private string tensach;
        public string Tensach
        {
            get { return tensach; }
            set { tensach = value; }
        }
        private string tacgia;
        public string Tacgia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }
        private int masach;
        public int Masach
        {
            get { return masach; }
            set { masach = value; }
        }
        private int namsx;
        public int Namsx
        {
            get { return namsx; }
            set { namsx = value; }
        }
        private double gia;
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public SACH()
        { }
        public SACH(string tensach, string tacgia, int masach, int namsx, double gia)
        {
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.masach = masach;
            this.namsx = namsx;
            this.gia = gia;
        }
        //nhập thông tin sách
        public void Nhap()
        {
            Console.Write("nhap ten sach: ");
            tensach = Console.ReadLine();
            Console.Write("nhap ten tac gia: ");
            tacgia = Console.ReadLine();
            Console.Write("nhap ma sach: ");
            masach =Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap nam san xuat: ");
            namsx = Int32.Parse(Console.ReadLine());
            Console.Write("nhap gia cua sach: ");
            gia = Double.Parse(Console.ReadLine());
        }
        //xuất thông tin sách đã canh lề
        public void Xuat()
        {
            Console.WriteLine("|{0,-20}|{1,-10}|{2,10}|{3,20}|{4,10}|", tensach, tacgia, masach, namsx, gia);
        }
        //tự thiết kế chuỗi 
        public string toString()
        {
            string S = tensach + ',' + tacgia + ',' + masach + ',' + namsx + "," + gia;
            return S;
        }
        //hàm mặc định viết đầu bảng
        public static void PrintHeader()
        {
            Console.WriteLine("|{0,-20}|{1,-10}|{2,10}|{3,20}|{4,10}|", "TenSach", "TacGia", "MaSach", "NamSanXuat", "Gia");
            Console.WriteLine("****************************************************************************");
        }
        //hàm mặc định viết cuối bảng
        
       
    }
}
