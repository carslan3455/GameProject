using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Oyun
{
    class GameManager:IGameServiceManeger
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.OyunAdi + " Sisteme Eklendi...");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.OyunAdi + " Güncelleme Yapildi...");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.OyunAdi + " Sistemden Silindi...");

        }
    }
}
