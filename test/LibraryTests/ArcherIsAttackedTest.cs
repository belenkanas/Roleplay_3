using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class ArcherIsAttackedTest
{
    [Test]
    public void ArcherAttacked()
    {
        Heroes archer = new Archer("Harry");
        IDefenseItem helmet = new Helmet();
        archer.AddItem(helmet);

        Villains knight = new KnightEnemie("Ron", 60);
        IAttackItem axe = new Axe();
        knight.AddItem(axe);

        int excpectedHealth = 100 - (knight.AttackValue - archer.DefenseValue);
        
        archer.ReceiveAttack(knight.AttackValue);

        Assert.That(archer.Health, Is.EqualTo(excpectedHealth));
    }
}