using Ucu.Poo.RoleplayGame;

// Clase abstracta Heroes que hereda de Character, y representa a un personaje héroe
public abstract class Heroes : Character
    {
        private int vp = 0;
        // Los punto de victoria comienzan con un valor inicial 0, luego van adquiriendo cuando
        // le ganan a un villano

        public int Vp {get; set;}
        
        // Constructor que recibe el nombre del héroe
        public Heroes(string name) : base(name) 
        {
        }

        // Método para que cuando un villano es derrotado (vida = 0), los puntos de victoria se le agreguen al héroe
        public void AddVp(Villains villano)
        {
            if (villano.Health == 0)
            {
                vp += villano.VP;
            }
        }
    }