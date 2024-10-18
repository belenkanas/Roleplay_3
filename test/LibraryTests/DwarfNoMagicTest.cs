using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class DwarfNoMagicTest
{
    [Test]
    public void DwarfNoMagic()
    {
        Character dwarf = new Dwarf("Juan");
        SpellsBook book = new SpellsBook();
        ISpell spell = new SpellOne();
        book.AddSpell(spell);

        Assert.Throws<InvalidOperationException>(() => UseElementMagic(dwarf, book));

        void UseElementMagic(Character character, IMagicalItem item)
        {
            if (!(character is Wizard) && item is SpellsBook)
            {
                throw new InvalidOperationException($"{character.Name} no puede usar magia");
            }
        } 
    }
}