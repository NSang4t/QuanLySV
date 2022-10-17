using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]

        public string RoleName { get; set; }
    }
}
