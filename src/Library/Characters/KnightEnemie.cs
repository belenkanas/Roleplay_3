using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class KnightEnemie : Villains
{
public KnightEnemie(string name, int vp): base(name, vp)
    {
        this.Name = name;
        this.VP = vp;

        this.AddItem(new Sword());
        this.AddItem(new Armor());
        this.AddItem(new Shield());
    }

}
