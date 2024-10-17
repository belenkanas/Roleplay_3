using Ucu.Poo.RoleplayGame;

public abstract class Villains : Character
    {
        public int VP {get; set;}
        //El valor inicial es puesto en el costructor, no es inicial como en el caso de Heroes

        public Villains(string name, int vp) : base(name)
        {
            this.VP = vp;
        }
    }