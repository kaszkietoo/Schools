using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Data.Utils
{
    public class EmailConfirmationPair
    {
        public string Code { get; set; }
        public string ValueToSend { get; set; }
    }
}
