using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Knight: Heroes
{

    public Knight(string name): base(name)
    {
        this.Name = name;

        this.AddItem(new Sword());
        this.AddItem(new Armor());
        this.AddItem(new Shield());
    }

    
}
