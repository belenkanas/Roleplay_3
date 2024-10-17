using Ucu.Poo.RoleplayGame;

public abstract class Heroes : Character
    {
        private int vp = 0;

        public int VP
        {
            get
            {
                return this.vp;
            }
            set
            {
                this.vp=value;
            }
        }

        public Heroes(string name) : base(name)
        {
        }

        public void AñiadirVP(Villians villano)
        {
            this.VP= this.VP+villano.VP;
        }
    }