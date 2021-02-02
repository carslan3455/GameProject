using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Uye
{
    interface IKontoManager
    {
        void Add(Konto konto);
        void Update(Konto konto);
        void Delete(Konto konto);
    }
}
