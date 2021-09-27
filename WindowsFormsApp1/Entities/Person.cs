using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    class Person
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
                Sex = EGioiTinh.Nam
            });
            ls.Add(new Person
            {
                Id = "2",
                FirstName = "asqư",
                LastName = "a12",
                DOB = new DateTime(2000, 5, 12),
                QueQuan = "da nang",
                Sex = EGioiTinh.Nam
            });

            return ls;
        }
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
