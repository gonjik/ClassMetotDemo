using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimilation
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine("Profiliniz Eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Profiliniz Silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Profiliniz güncellendi");
        }
    }
}
