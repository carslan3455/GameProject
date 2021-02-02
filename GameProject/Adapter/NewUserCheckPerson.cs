using GameProject.Uye;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    class NewUserCheckPerson : IKontoCheckService
    {
        public bool CheckIfRealKonto(Konto konto)
        {
            return true;
        }
    }
}
