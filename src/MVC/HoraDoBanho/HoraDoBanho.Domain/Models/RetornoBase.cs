using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Domain.Models
{
    public class RetornoBase
    {
        public string MsgRetorno { get; set; }
        public bool Sucesso { get; set; }
    }
}
