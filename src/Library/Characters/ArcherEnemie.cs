using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class ArcherEnemie: Villains
{

    public ArcherEnemie(string name, int vp) : base(name, vp)
    {
        this.Name = name;
        this.VP = vp;

        this.AddItem(new Bow());
        this.AddItem(new Helmet());
    }


}