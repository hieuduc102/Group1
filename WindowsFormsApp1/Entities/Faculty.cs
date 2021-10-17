using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Faculty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public static List<Faculty> GetList()
        {
            List<Faculty> list = new List<Faculty>();
            list.Add(new Faculty
            {
                Id="1",
                Name="cntt"
            });
            list.Add(new Faculty
            {
                Id = "2",
                Name = "hoa"
            });
            list.Add(new Faculty
            {
                Id = "3",
                Name = "ly"
            });
            list.Add(new Faculty
            {
                Id = "4",
                Name = "toan"
            });
            return list;
        }
    }
}
