using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

// Clase abstracta Character que define un personaje
public abstract class Character
{
    private int health = 100;                           // Guarda la vida del personaje, con un valor inicial de 100

    public List<IItem> items = new List<IItem>();       // Lista de items que tiene el personaje

    public Character(string name)                       // Constructor que recibe el nombre del personaje
    {
        this.Name = name;
    }

    public string Name { get; set; }                    // Nombre del personaje

    // Propiedad que calcula el valor de ataque del personaje en base a los items de ataque que tenga
    public virtual int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IAttackItem)
                {
                    value += (item as IAttackItem).AttackValue;
                }
            }
            return value;
        }
    }

    // Propiedad que calcula el valor de defensa del personaje en base a los items de defensa que tenga
    public virtual int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IDefenseItem)
                {
                    value += (item as IDefenseItem).DefenseValue;
                }
            }
            return value;
        }
    }

    // Propiedad que se encarga de la vida del personaje 
    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;        // Si la vida es menor a cero se establecerá en cero
        }
    }

    // Método donde el personaje recibe un ataque con poder de un enemigo y su vida disminuye si su defensa es menor 
    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    // Método que cura al personaje y establece su vida al máximo
    public void Cure()
    {
        this.Health = 100;
    }

    // Método que agrega items a la lista de items del personaje
    public void AddItem(IItem item)
    {
        this.items.Add(item);
    }

    // Método que elimina items de la lista de items del personaje
    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }
}