using GameProject.Business.Abstract;
using GameProject.Entities;
using Kimlik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    public class GamerManager
    {


        public void Add(Gamer gamer)
        {
            bool sonuc = false;
            using (KPSPublicSoapClient servis = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                sonuc = servis.TCKimlikNoDogrulaAsync(long.Parse(gamer.NationallyId), gamer.FirstName, gamer.LastName, int.Parse(gamer.BirthYear)).GetAwaiter().GetResult().Body.TCKimlikNoDogrulaResult;

            }
            if (sonuc == true)
            {
                Console.WriteLine(gamer.FirstName + " added ");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " not added. your credentials did not match  ");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated ");
        }
    }
}
