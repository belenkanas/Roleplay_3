using Ucu.Poo.RoleplayGame;

//
public abstract class Villains : Character
    {
        public int VP {get; set;}
        // El valor inicial es puesto en el costructor, no es inicial como en el caso de Heroes

        // Constructor del villano y sus puntos de victoria
        public Villains(string name, int vp) : base(name)
        {
            this.VP = vp;
        }

        // Método que pone en cero los puntos de victoria si el personaje es derrotado por el héroe
        public void ReceiveHeroeAttack()
        {
        if (this.VP > 0 && this.Health == 0)
        {
            this.VP = 0;
        }
        }

    }