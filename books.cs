using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalTermAssignment
{
    class books
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Edition { get; set; }
    }
}
