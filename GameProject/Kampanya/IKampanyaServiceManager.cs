using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Kampanya
{
    interface IKampanyaServiceManager
    {
        public void Add(Kampanyam kampanya);
        public void Update(Kampanyam kampanya);
        public void Delete(Kampanyam kampanya);
    }
}
