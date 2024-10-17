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

        private void VillainsAtaque()
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
            }
        }
    }
}