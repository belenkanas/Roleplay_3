using Ucu.Poo.RoleplayGame;

public abstract class Heroes : Character
    {
        private int vp = 0;
        // Esto es porque comienzan con un valor inicial 0, luego van adquiriendo cuando
        // le ganan a un villano

        public int VP{get; set;}

        public Heroes(string name) : base(name)
        {
        }

        public void AddVP(Villains villano)
        {
            this.VP += villano.VP;
        }
    }