using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKTCore
{
    public class SanPhamServices
    {
        // mô phỏng dữ liệu
        private readonly List<SanPham> sanPhams = new List<SanPham>();  
        public SanPhamServices()
        {
            sanPhams.Add(new SanPham() { MaSP="SP001", Name="A", Gia = 10 });
        }

        public SanPham? getSPbyMa(string MaSP)
        {
            return sanPhams.FirstOrDefault(x=> x.MaSP == MaSP);
        }

        public bool Add(SanPham sp)
        {
            try
            {
                if(sp.Gia < 0) return false;
                sanPhams.Add(sp);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Edit(SanPham sp)
        {
            var existsSP = sanPhams.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (existsSP != null)
            {
                if (sp.Gia < 0) return false;

                existsSP.Gia = sp.Gia;
                existsSP.Name = sp.Name;
                return true;
            }
            return false;
        }
    }
}
