using GameProject.Adapter;
using GameProject.Uye;
using GameProject.Oyun;
using System;
using GameProject.Satis;
using GameProject.Kampanya;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto
            {
                Id = 1,
                DateOfBirth = 1982,
                FirstName = "CIGDEM",
                LastName = "ARSLAN",
                NationalityId = "12345678910"

            };

            KontoManager kontoManager = new KontoManager(new MernisCheckPerson());
            kontoManager.Add(konto1);

            Game game1 = new Game
            {
                OyunId = 1,
                OyunAdi = "LoL",
                Price = 100,
                StokAdedi =10
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Kampanyam kampanya1 = new Kampanyam
            {
                KampanyaId = 1,
                KampanyaAdi = "Yaz indirimi",
                IndirimOrani = 10
            };

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(kampanya1);

            SatisManager satisManager = new SatisManager();
            satisManager.SepeteEkle(konto1, game1, (new FileLoggerService()),kampanya1);
            satisManager.Payment(konto1, (new SmsLoggerService()));



            Console.ReadLine();
        }

       
    }
}
