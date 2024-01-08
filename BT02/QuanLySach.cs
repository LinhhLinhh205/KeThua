using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class QuanLySach
    {
        private TaiLieu[] sach;
        private int n;

        
        public QuanLySach()
        {
            sach = new TaiLieu[100];
            n = 0;
        }
        public QuanLySach(int sophantu)
        {
            sach = new TaiLieu[sophantu];
            n = 0;
        }
        public void ThemSach(TaiLieu a)
        {
            sach[n++] = a;
        }
        public void XoaTaiLieuMaTaiLieu(int b)
        {
            if (b != n)
            {
                for(int i = b; i < n; i++)
                {
                    sach[i].Matailieu = sach[i + 1].Matailieu;
                }
                n = n + 1;        
            }
        }
        public void HienThongTinTaiLieu()
        {
            Console.WriteLine()
        }


    }
}
