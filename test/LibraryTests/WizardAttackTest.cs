using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class WizardAttackTest
{
    [Test]
    public void WizardAttack()
    {
        Heroes mago = new Wizard("Pery");
        SpellsBook book = new SpellsBook();
        ISpell spell = new SpellOne();
        book.AddSpell(spell);

        Character archer = new Archer("Bob");
        
        archer.ReceiveAttack(mago.AttackValue);

        int expectedHealth = 100 - (mago.AttackValue - archer.DefenseValue);
        expectedHealth = expectedHealth < 0 ? 0 : expectedHealth;
        
        Assert.That(archer.Health, Is.EqualTo(expectedHealth));
    }
}