using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.Models
{
    public class CuentaBancaria
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string AccountNumber { get; set; }
        public string Description { get; set; }
    }

}
