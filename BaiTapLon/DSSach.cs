using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDamTanTien
{
    class DSSach
    {

        List<SACH> listSach = new List<SACH>();
        //xuất bảng danh sách
        public void Xuat()
        {
            foreach (SACH s in listSach)
            {
                s.Xuat();
            }
        }
        //hàm mở và đọc file và tăch chuỗi
        public void AddFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Admin\\source\\repos\\BaiTapLon\\BaiTapLon\\DSSach.txt"))
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] arr = line.Split(',');
                        string tensach = arr[0];
                        string tacgia = arr[1];
                        int masach = Int32.Parse(arr[2]);
                        int namsx = Int32.Parse(arr[3]);
                        double gia = Double.Parse(arr[4]);
                        SACH sach = new SACH(tensach, tacgia, masach, namsx, gia);
                        listSach.Add(sach);
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("khong the doc file\n");
                Console.WriteLine(e.Message);
            }
        }
        // hàm sắp xếp theo tên
        public void Namesort()
        {
            listSach.Sort(
                delegate (SACH s1, SACH s2)
                {
                    return s1.Tensach.CompareTo(s2.Tensach);
                }
                );
        }
        //hàm sắp xếp theo năm xuất bản
        public void Publishingyear()
        {
            listSach.Sort(
                delegate (SACH s1, SACH s2)
                {
                    return s1.Namsx - s2.Namsx;
                }
                );
        }
        //hàm tổng số sách
        public void PrintFooter()
        {
            int total;
            Console.Write("Tinh tong So Sach:\n");
            Console.Write("-----------------------------");
            total = listSach.Count();

            Console.Write("\nTong So Sach La:{0}\n", total);

        }
        //hàm thêm sách vào file 
        public void Themsach(SACH sach)
        {

            sach.Nhap();
            try
            {
                StreamWriter file = new StreamWriter("C:\\Users\\Admin\\source\\repos\\BaiTapLon\\BaiTapLon\\DSSach.txt", true);
                file.Write(sach.toString() + "\r\n");
                file.Close();
                Console.WriteLine("Luu thanh cong!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("khong the ghi file\n");
                Console.WriteLine(e.Message);
            }
        }
        //hàm xóa sách theo masach và không xóa danh sách sách cũ
        public void Xoa(int id)
        {
            //tim masach co trong list khong
            bool tim = false;
            
            for (int i = 0; i < listSach.Count(); i++)
                if (listSach[i].Masach == id)
                {
                    tim = true;
                    Console.WriteLine("\tKQ tim duoc\n");
                    listSach[i].Xuat();

                    if (tim == true)
                    {                       
                        listSach.Remove(listSach[i]);                        
                        Console.Write("sach da duoc xoa\n");
                    }
                    else
                    {
                        Console.Write("sach chua dc xoa\n");
                    }

                }
            //try
            //{
            //    StreamWriter file = new StreamWriter("C:\\Users\\Admin\\source\\repos\\BaiTapLon\\BaiTapLon\\DSSach.txt");
            //    file.Write( + "\r\n");
            //    file.Close();
            //    Console.WriteLine("Luu thanh cong!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("khong the ghi file");
            //    Console.WriteLine(e.Message);
            //}

        }
        //Hành vi tìm kiếm thông tin sách
        public void Find()
        {
            string key;

            Console.WriteLine("\n\t-- -- Sach co trong thu vien -- --");
            Console.Write("\tNhap ten sach: ");
            key = Console.ReadLine();

            for (int i = 0; i < listSach.Count(); i++)
                if (listSach[i].toString().Contains(key))
                {
                    Console.Write("{0}", i+1);
                    listSach[i].Xuat();
                }
        }
    }
}
        
    
        
    
    

