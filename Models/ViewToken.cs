using cty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cty.Share.Models
{
    public class ViewToken
    {
        public string Token { get; set; }
        public Student student { get; set; }
    }
}
