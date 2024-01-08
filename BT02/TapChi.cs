using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class TapChi:TaiLieu
    {
        private int sophathanh;
        private int thangphathanh;

        public TapChi()
        {

        }
        public TapChi(string matailieu,string tennhaxuatban,int sobanphathanh,int sophathanh,int thangphathanh) : base(matailieu, tennhaxuatban, sobanphathanh)
        {
            this.sophathanh = sophathanh;
            this.thangphathanh = thangphathanh;
        }
        public int Sophathanh
        {
            get { return sophathanh; }
            set { sophathanh = value; }
        }
        public int Thangphathanh
        {
            get { return thangphathanh; }
            set { thangphathanh = value; }
        }

    }
}
