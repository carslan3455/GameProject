using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Kampanya;
using GameProject.Oyun;
using GameProject.Uye;

namespace GameProject.Satis
{
    class SatisManager:ISatisService
    {
        public void SepeteEkle(Konto konto, Game game, ILoggerService loggerService, Kampanyam kampanya)
        {
            Console.WriteLine(konto.FirstName + " isimli kontonuza oyununuz eklenmistir");
            loggerService.Log();

        }

        public void Payment(Konto konto, ILoggerService loggerService)
        {
            Console.WriteLine(konto.FirstName + " kontonuzdan odeme islemi gerceklestirilmistir");
            loggerService.Log();
        }

    }
}
