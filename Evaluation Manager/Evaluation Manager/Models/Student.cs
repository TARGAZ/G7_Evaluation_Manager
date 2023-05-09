using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Evaluation_Manager.Models
{
    public class Student : Person
    {
        public int Grade { get; set; }
    }
}
