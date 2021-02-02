using GameProject;
using GameProject.Kampanya;
using GameProject.Oyun;
using GameProject.Uye;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Satis
{
    interface ISatisService
    {
        void SepeteEkle(Konto konto, Game game, ILoggerService loggerService, Kampanyam kampanya);
        void Payment(Konto konto, ILoggerService loggerService);
    }
}
