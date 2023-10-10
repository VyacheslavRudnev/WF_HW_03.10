using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Domain
{
    public class Insurers
    {
        public List<Client> Collection { get; set; }
        public Insurers()
        {
            Collection = new List<Client>();
        }

    }
}
