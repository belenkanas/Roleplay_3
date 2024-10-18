using System;

namespace Ucu.Poo.RoleplayGame.Program;

class Program
{
    static void Main(string[] args)
    {
        Encounter encuentro = new Encounter();
        
        Heroes gimli = new Archer("Gimli");
        Heroes peter = new Dwarf("Peter");
        Heroes harry = new Wizard("Harry");
        Heroes ron = new Knight("Ron");
        Heroes hermione = new Wizard("Hermione");
        
        IAttackItem axe = new Axe();
        gimli.AddItem(axe);
        peter.AddItem(axe);
        IAttackItem bow = new Bow();
        gimli.AddItem(bow);
        IAttackItem staff = new Staff();
        hermione.AddItem(staff);
        harry.AddItem(staff);
        IDefenseItem helmet = new Helmet();
        gimli.AddItem(helmet);
        IDefenseItem staffdef = new Staff();
        ron.AddItem(staffdef);
        
        Villains gandalf = new WizardEnemie("Gandalf", 50);
        Villains draco = new WizardEnemie("Draco", 80);
        Villains voldemort = new DwarfEnemie("Voldemort", 30);
        Villains luna = new KnightEnemie("Luna", 20);
        Villains snape = new ArcherEnemie("Snape", 50);
        
        SpellsBook book = new SpellsBook();
        ISpell hechizo = new SpellOne();
        book.AddSpell(hechizo);
        
        //gandalf.AddItem(book); no me deja
        IAttackItem sword = new Sword();
        gandalf.AddItem(sword);
        draco.AddItem(axe);
        luna.AddItem(axe);
        voldemort.AddItem(bow);
        IDefenseItem armor = new Armor();
        gandalf.AddItem(armor);
        snape.AddItem(helmet);
        draco.AddItem(staffdef);
        
        encuentro.AddHeroe(gimli);
        encuentro.AddHeroe(harry);
        encuentro.AddHeroe(peter);
        encuentro.AddHeroe(hermione);
        encuentro.AddHeroe(ron);
        
        Console.WriteLine();
        
        encuentro.AddVillano(gandalf);
        encuentro.AddVillano(draco);
        encuentro.AddVillano(voldemort);
        encuentro.AddVillano(luna);
        encuentro.AddVillano(snape);
        
        Console.WriteLine();
        
        encuentro.DoEncounter();
    }
}
