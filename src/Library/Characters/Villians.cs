using Ucu.Poo.RoleplayGame;

public abstract class Villians : Character
    {
        public int VP {get; set;}

        public Villians(string name, int vp) : base(name)
        {
            this.VP=vp;
        }
    }