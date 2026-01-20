using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKTCore.Test
{
    [TestFixture]
    internal class SanPhamServicesTest
    {
        public SanPhamServices _sps = null;
        [SetUp]
        public void Setup()
        {
            _sps = new SanPhamServices();
        }

        [Test]
        public void EditNotExists()
        {
            SanPham sp = new SanPham() { MaSP = "SP099", Name = "A", Gia = 10 };

            Assert.IsFalse(_sps.Edit(sp));

        }

        //Phân vùng theo giá
        // nếu có giới hạn số lượng ký tự => phân vùng theo số lượng ký tự

        [Test]
        public void AddGiaAm()
        {
            SanPham sp = new SanPham() { MaSP = "SP099", Name = "A", Gia = -10 };

            Assert.IsFalse(_sps.Add(sp));

        }

    }
}
