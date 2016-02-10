namespace Exercise_Inheritance_and_Abstraction
{
    public class Mage : Character
    {
        public Mage(int health, int mana, int damage)
            : base(100, 300, 75)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= 2 * this.Damage;
        }
    }
}
