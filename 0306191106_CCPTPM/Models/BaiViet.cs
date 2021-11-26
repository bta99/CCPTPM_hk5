using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191106_CCPTPM.Models
{
    public class BaiViet
    {
        public int Id { get; set; }
        public string maBaiViet { get; set; }

        public string tenBaiViet { get; set; }

        public string noiDungBaiViet { get; set; }

        public DateTime ngayDangBaiViet { get; set; }
    }
}
