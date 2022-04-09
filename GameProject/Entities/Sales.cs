using GameProject.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Sales : SalesManager
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
    }
}
