  using System;

namespace ArenaRPG
    {
      
        public class Jukumari : SerMitologico
        {
            public Jukumari()
            {
                Nombre = "Jukumari";
                Vida = 100; 
            }
            public override void Atacar()
            {
                Console.WriteLine($"{Nombre} lanza un potente zarpazo con fuerza descomunal!");
            }
            public void RugidoFeroz()
            {
                Console.WriteLine($"{Nombre} emite un rugido que intimida a todos en la región andina.");
            }
        }
    }
}
}
