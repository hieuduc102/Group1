using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Person
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// họ
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public EGioiTinh Sex { get; set; }
        /// <summary>
        /// Que quan
        /// </summary>        
        public string QueQuan { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
        public string IdFaculty { get; set; }
        public static List<Person> GetList()
        {
            var ls = new List<Person>();
            ls.Add(new Person
            {
                Id = "1",
                FirstName = "Duc Hieu",
                LastName = "Nguyen",
                DOB = new DateTime(2000, 2, 10),
                QueQuan = "Quang Nam",
                Sex = EGioiTinh.Nam,
                IdFaculty="1"
            });
            ls.Add(new Person
            {
                Id = "2",
                FirstName = "Phủ",
                LastName = "A",
                DOB = new DateTime(2000, 5, 12),
                QueQuan = "Sơn La",
                Sex = EGioiTinh.Nam,
                IdFaculty="2"
            });
            ls.Add(new Person
            {
                Id = "3",
                FirstName = "Nở",
                LastName = "Thị",
                DOB = new DateTime(2000, 6, 30),
                QueQuan = "Hà Nam",
                Sex = EGioiTinh.Nu,
                IdFaculty = "3"
            });

            return ls;
        }


        /// <summary>
        /// Lay ds sv cua 1 khoa
        /// </summary>
        /// <param name="idFaculty"> Ma kho can lay</param>
        /// <returns>Ds sv cua khoa</returns>
        public static List<Person> GetList(string idFaculty)
        {
            var ls = GetList();
            var rs = ls.Where(e => e.IdFaculty == idFaculty).ToList();
            return rs;
        }

        /// <summary>
        /// Lay 1 sv tu csdl
        /// </summary>
        /// <param name="id">Ma sinh vien can lay</param>
        /// <returns></returns>
        public static Person Get(string id)
        {
            var dbPerson = GetList();
            var person = dbPerson.Where(p => p.Id == id).FirstOrDefault();
            return person;
        }



        public enum EGioiTinh
        {
            Nam,
            Nu
        }

    }
}
