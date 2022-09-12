using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeenTogether.Models
{
    public class Hobby
    {
        public int Id { get; set; }

        public string HobbyText { get; set; }

        public bool HerHis { get; set; }

        public int LoveId { get; set; }

        public Love Love { get; set; }
    }
}
