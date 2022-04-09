using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstract
{
    public interface ISaleService
    {
        void Sell(Sales sales, Gamer gamer, Campaign campaign);
    }
}
