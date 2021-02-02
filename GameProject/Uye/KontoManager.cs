using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Uye
{
    class KontoManager:IKontoManager
    {
        private IKontoCheckService _kontoCheckService;
       

        public KontoManager(IKontoCheckService kontoCheckService)
        {
            _kontoCheckService = kontoCheckService;
        }

        public void Add(Konto konto)
        {
            if (_kontoCheckService.CheckIfRealKonto(konto))  // Bilgilerin Mernis den dogrulamasi yapilacak 
            {
                // _kontoManager.Add(konto);
                Console.WriteLine("Yeni kayit yapildi...");
            } 
            else 
            {
                Console.WriteLine("Not a valid person");
            }
        }

        public void Update(Konto konto)
        {
            Console.WriteLine("Kayit guncelleme yapildi...");

        }

        public void Delete(Konto konto)
        {
            Console.WriteLine("Kayit silindi...");

        }

      
    }
}
