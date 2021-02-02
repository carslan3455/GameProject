using GameProject.Uye;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameProject.Adapter
{
    class MernisCheckPerson : IKontoCheckService
    {
        
        public bool CheckIfRealKonto(Konto konto)
        {
           if(konto.DateOfBirth == 1982 && konto.FirstName =="CIGDEM" && 
                konto.LastName == "ARSLAN" && konto.NationalityId == "12345678910")
           {
                return true;
           }
           else
           {
                return false;
           }
        }
    }
}
