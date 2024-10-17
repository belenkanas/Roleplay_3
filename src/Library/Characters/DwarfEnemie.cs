using System.Collections.Generic;

namespace Ucu.Poo.RoleplayGame;

public class DwarfEnemie: Villains
{

    public DwarfEnemie(string name, int vp) : base (name, vp)
    {
        this.Name = name;

        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }

}
