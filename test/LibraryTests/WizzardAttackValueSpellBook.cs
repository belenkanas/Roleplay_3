using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class WizzardAttackValueSpellBook
{
    [Test]
    public void WizardAttackValueSB()
    {
        Wizard hermione = new Wizard("Hermione");
        SpellsBook spellbook = new SpellsBook();
        ISpell spell = new SpellOne();
        spellbook.AddSpell(spell);
        hermione.AddItem(spellbook);

        int attackValue = hermione.AttackValue;
        int expectedAttackV = 170; // Valor de staff ya incorporado en Wizard junto con el valor del spell.
        
        Assert.That(attackValue, Is.EqualTo(expectedAttackV));
    }
}