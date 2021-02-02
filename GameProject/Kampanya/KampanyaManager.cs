using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Kampanya
{
    class KampanyaManager :IKampanyaServiceManager
    {
        public void Add(Kampanyam kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " Kampanyasi Sisteme Eklendi...");
        }

        public void Update(Kampanyam kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " Kampanyasinda Güncelleme Yapildi...");

        }

        public void Delete(Kampanyam kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " Kampanyasi Sistemden Silindi...");

        }
    }
}
