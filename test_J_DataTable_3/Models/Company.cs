using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_J_DataTable_3.Models
{
    /// <summary>
    /// Company class contains information that shoudl be shown in table
    /// </summary>
    public class Company
    {
        static int nextID = 17;

        public Company()
        {
            ID = nextID++;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
    }
}