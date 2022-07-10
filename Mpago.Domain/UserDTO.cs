using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpago.Domain
{
    public class IdentificationDTO
    {
        public string type { get; set; }
        public int number { get; set; }
    }

    public class UserDTO
    {
        public int id { get; set; }
        public string email { get; set; }
        public IdentificationDTO identification { get; set; }
    }
}
