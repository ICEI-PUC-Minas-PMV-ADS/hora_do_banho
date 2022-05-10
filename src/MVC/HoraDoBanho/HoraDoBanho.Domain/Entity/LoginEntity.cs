using HoraDoBanho.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Domain.Entity
{
    [Table("Login")]
    public class LoginEntity : BaseEntity
    {
        public string userName { get; set; }

        public string password { get; set; }
    }
}
