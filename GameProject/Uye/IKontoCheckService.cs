using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Uye
{
    interface IKontoCheckService
    {
        bool CheckIfRealKonto(Konto konto);
    }
}
