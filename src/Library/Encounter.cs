using System.Net.Sockets;

namespace Ucu.Poo.RoleplayGame
{
    public class Encounter
    {
        private List<Heroes> heroes;
        private List<Villains> villains;

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