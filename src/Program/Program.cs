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
        Wizard hermione = new Wizard("Hermione");
        
        IAttackItem axe = new Axe();
        gimli.AddItem(axe);
        peter.AddItem(axe);
        IAttackItem bow = new Bow();
        harry.AddItem(bow);
        IAttackItem staff = new Staff();
        hermione.AddItem(staff);
        harry.AddItem(staff);
        IDefenseItem helmet = new Helmet();
        peter.AddItem(helmet);
        IDefenseItem staffdef = new Staff();
        ron.AddItem(staffdef);

        SpellsBook bookHermione = new SpellsBook();
        ISpell hechizoHermione1 = new SpellOne();
        ISpell hechizoHermione2 = new SpellOne();
        bookHermione.AddSpell(hechizoHermione1);
        bookHermione.AddSpell(hechizoHermione2);
        hermione.AddItem(bookHermione); 
        
        WizardEnemie gandalf = new WizardEnemie("Gandalf", 50);
        Villains draco = new WizardEnemie("Draco", 80);
        Villains voldemort = new DwarfEnemie("Voldemort", 30);
        Villains luna = new KnightEnemie("Luna", 20);
        Villains snape = new ArcherEnemie("Snape", 50);
        
        SpellsBook bookGandalf = new SpellsBook();
        ISpell hechizoGandalf1 = new SpellOne();
        bookGandalf.AddSpell(hechizoGandalf1);
        gandalf.AddItem(bookGandalf);
        
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
