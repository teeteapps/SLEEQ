using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Vw_menus")]
    public class Vw_menus
    {
        [NotMapped]
        public static string TableName { get { return "Vw_menus"; } }
        public string MenuName { get; set; }
        public string ActionName { get; set; }
        public string Controller { get; set; }
        public string IconName { get; set; }
        public string OrderBy { get; set; }
        public int ProfileCode { get; set; }
        public int MenuLevel { get; set; }
        public int ParentId { get; set; }
        public int MenuCode { get; set; }
    }
}
