using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.Model
{
    class MenuChildModel
    {
        public string t_menu_id { get; set; }
        public string menu_code { get; set; }
        public string menu_name { get; set; }
        public string menu_desc { get; set; }
        public string parent { get; set; }
        public string sequence_parent { get; set; }
        public string sequence_child { get; set; }
        public string type { get; set; }
        public string user_entry { get; set; }
        public string date_entry { get; set; }
        public string user_last_maintenance { get; set; }
        public string date_last_maintenance { get; set; }
        public string level { get; set; }
        public string PathApp { get; set; }
    }
}
