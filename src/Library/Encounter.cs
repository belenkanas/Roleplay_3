using System.Net.Sockets;

namespace Ucu.Poo.RoleplayGame
{
    //Mediante esta clase se va a definir la partida entre héroes y villano. En primer lugar se va a presentar un equipo de cada uno
    //(una lista) en la cual uno juega con el otro respectivamente (respetando sus índices en la lista).
    //Esta clase será utilizada en Program, gracias a los principios de delegación.
    public class Encounter
    {
        //Poniendo la lista privada de Heroes nos aseguramos de que no se modifique mediante la partida
        private List<Heroes> heroes;
        
        //Lo mismo con la lista de villanos
        private List<Villains> villains;

        //El constructor necesita conocer a los personajes y debe asegurar que por lo menos haya uno en cada equipo, de lo contrario
        //no se podrá hacer la partida.
        public Encounter(List<Heroes> heroes, List<Villains> villains)
        {
            if (heroes.Count == 0 || villains.Count == 0)
            {
                Console.WriteLine($"Debe estar presente al menos un héroe o un villano para poder iniciar la partida");
            }
            else
            {
                this.heroes = heroes;
                this.villains = villains;
            }
        }

        public void DoEncounter()
        {
            
        }

        //Primero atacan los villanos, se analiza uno por uno la lista del villano y se busca al héroe con mismo índice
        //para luego calcular el daño causado y dárselo al contrincante.
        private void VillainsAttack()
        {
            int indiceHeroeAtacado = 0;

            foreach (Villains villain in villains)
            {
                Heroes heroeAtacado = heroes[indiceHeroeAtacado];

                if (heroeAtacado.Health > 0)
                {
                    int daño = villain.AttackValue;
                    heroeAtacado.ReceiveAttack(daño);

                    Console.WriteLine($"{villain.Name} ha atacado a {heroeAtacado.Name} con {daño}");
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
                            int power = hero.AttackValue;

                            villain.ReceiveAttack(power);

                            Console.WriteLine($"{hero.Name} ha atacado a {villain.Name} con {power}");
                        
                            if (villain.Health <= 0)
                            {
                                hero.AddVp(villain);
                                Console.WriteLine($"{hero.Name} ha derrotado a {villain.Name}. Ha ganado {villain.VP} puntos de victoria");
                            }
                        }
                    }
                }
            }
        }
    }
}