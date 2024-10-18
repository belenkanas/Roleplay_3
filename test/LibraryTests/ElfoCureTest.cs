using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class ElfoCureTest
{
    [Test]
    public void ElfoCure()
    {
        Character elfo = new Knight("Lucho");
        
        elfo.ReceiveAttack(50);
        
        elfo.Cure();
        
        Assert.That(100, Is.EqualTo(elfo.Health));
    }
}