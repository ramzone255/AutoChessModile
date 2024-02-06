using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess
{
    [Table("Sportsmans")]
    public class Sportsmans
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Birth { get; set; }
        public string Category { get; set; }
        public string Place { get; set; }
    }
}
