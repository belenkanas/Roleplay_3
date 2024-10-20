using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class EncounterAddCharacterTests
{
    [Test]
    public void EncuentroAddCharacterTests()
    {
        Encounter _encounter = new Encounter();
        
        Heroes _gimil = new Archer("Gimil");
        
        Villains _gandalf = new DwarfEnemie("Gandalf", 50);

        _encounter.AddHeroe(_gimil);
        _encounter.AddVillano(_gandalf);
        
        Assert.That(_encounter.heroes, Contains.Item(_gimil));
        Assert.That(_encounter.villains, Contains.Item(_gandalf));
    }
    
}