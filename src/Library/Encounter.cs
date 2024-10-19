using System.Net.Sockets;

namespace Ucu.Poo.RoleplayGame
{
    //Mediante esta clase se va a definir la partida entre héroes y villano. En primer lugar se va a presentar un equipo de cada uno
    //(una lista) en la cual uno juega con el otro respectivamente (respetando sus índices en la lista).
    //Esta clase será utilizada en Program, gracias a los principios de delegación.
    public class Encounter
    {
        //Poniendo la lista privada de Heroes nos aseguramos de que no se modifique mediante la partida
        public List<Heroes> heroes = new List<Heroes>();
        
        //Lo mismo con la lista de villanos
        public List<Villains> villains = new List<Villains>();

        public int TotalHeroes => heroes.Count;
        public int TotalVillanos => villains.Count;

        public void AddHeroe(Heroes heroe)  //Agrega Heroe y suma uno al total
        {
            this.heroes.Add(heroe);
            Console.WriteLine($"{heroe.Name} ha sido añadido al equipo de Héroes");
        }

        public void AddVillano(Villains villano)    //Agrega Villano y suma uno al total
        {
            this.villains.Add(villano);
            Console.WriteLine($"{villano.Name} ha sido añadido al equipo de Villanos");
            
        }
        

        public void DoEncounter()
        {
            while (TotalHeroes > 0 && TotalVillanos > 0)
            {
                VillainsAttack();
                HeroesAttack();
                RemoveHeroe();
                RemoveVillano();
                CheckEndGame();

            }
        }

        //Primero atacan los villanos, se analiza uno por uno la lista del villano y se busca al héroe con mismo índice
        //para luego calcular el daño causado y dárselo al contrincante.
        private void VillainsAttack()
        {
            int indiceHeroeAtacado = 0;

            foreach (Villains villain in villains)
            {

                if (this.heroes[indiceHeroeAtacado].Health > 0)
                {
                    this.heroes[indiceHeroeAtacado].ReceiveAttack(villain.AttackValue);

                    Console.WriteLine($"{villain.Name} ha atacado ⚔️ a {this.heroes[indiceHeroeAtacado].Name} con {villain.AttackValue}");
                }

                indiceHeroeAtacado += 1;
            }

            if (indiceHeroeAtacado >= heroes.Count)
            {
                indiceHeroeAtacado = 0;
            }
        }

        //Los héroes atacan después de los villanos, por lo que, además de usar una lógica parecida, primero se tiene que
        //asegurar que el héroe siga vivo. En caso de que derrote por completo al enemigo, recibe los puntos de victoria.
        private void HeroesAttack()
        {
            foreach (Heroes hero in heroes)
            {
                if (hero.Health > 0)
                {
                    foreach(Villains villain in villains)
                    {
                        if (villain.Health > 0)
                        {

                            villain.ReceiveAttack(hero.AttackValue);

                            Console.WriteLine($"{hero.Name} ha atacado ⚔️ a {villain.Name} con {hero.AttackValue}");
                        
                            if (villain.Health <= 0)
                            {
                                hero.AddVp(villain);
                                Console.WriteLine($"{hero.Name} ha derrotado a {villain.Name}. Ha ganado {villain.VP} puntos de victoria");
                                if (villain.VP >= 5)
                                {
                                    hero.Cure();
                                    Console.WriteLine($"{hero.Name} ha sido curado");
                                }
                            }
                        }
                    }
                }
            }
        }

        public void CheckEndGame()
        {
            if (TotalHeroes < 1)
            {
                Console.WriteLine("Los héroes han sido derrotados");
            }
            else if (TotalVillanos < 1)
            {
                Console.WriteLine("Los enemigos han sido derrotados");
            }
            else
            {
                Console.WriteLine("Continúa el juego");
            }
        }

        public void RemoveHeroe()   //Remueve Heroe
        {
            foreach (Heroes heroe in this.heroes)
            {
                if (heroe.Health<=0)
                {
                    this.heroes.Remove(heroe);
                    Console.WriteLine
                    ($"{heroe.Name} ya no puede continuar, Heroes restantes : {TotalHeroes}");
                }
            }
        }
        public void RemoveVillano() //Remueve Villano
        {
            foreach (Villains villano in this.villains)
            {
                if(villano.Health <= 0)
                {
                    this.villains.Remove(villano);
                    Console.WriteLine
                    ($"{villano.Name} ha sido aniquilado, Villanos restantes {TotalVillanos}");
                }
            }
        }
    }
}