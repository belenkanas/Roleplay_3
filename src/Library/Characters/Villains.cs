using Ucu.Poo.RoleplayGame;

public abstract class Villains : Character
    {
        public int VP {get; set;}

        public Villains(string name, int vp) : base(name)
        {
            this.VP=vp;
        }
    }