using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    class LichSuHocTap
    {
        ///<sumary>
        ///Khoa chinh
        /// </sumary>
        public string Id { get; set; }
        ///<summary>
        ///Truong
        /// </summary>
        public string School { get; set; }
        ///<summary>
        ///Diem hoc tap
        /// </summary>
        public string Diem { get; set; }
        ///<summary>
        ///Hanh kiem
        /// </summary>
        public EHanhKiem HanhKiem { get; set; }


        public static List<LichSuHocTap> GetList()
        {
            var ls = new List<LichSuHocTap>();
            ls.Add(new LichSuHocTap
            {
                Id = "1",
                School = "Truong tieu hoc Thuy Duong",
                Diem = "9d",
                HanhKiem = EHanhKiem.Tot
            });
            ls.Add(new LichSuHocTap
            {
                Id = "2",
                School = "Truong trung hoc co so Thuy Duong",
                Diem = "9d",
                HanhKiem = EHanhKiem.Tot
            });
            ls.Add(new LichSuHocTap
            {
                Id = "3",
                School = "Truong trung hoc pho thong Huong Thuy",
                Diem = "9d",
                HanhKiem = EHanhKiem.Tot
            });
            return ls;
        }
        public static LichSuHocTap Get(string id)
        {
            var dbLichSuHocTap = GetList();
            var lichsu = dbLichSuHocTap.Where(p => p.Id == id).FirstOrDefault();
            return lichsu;
        }
        public enum EHanhKiem
        {
            Yeu,
            Kem,
            Trung_binh,
            Kha,
            Tot
        }

    }
}
