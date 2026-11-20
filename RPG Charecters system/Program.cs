namespace RPG_Charecters_system;

class Program
{
    static void Main(string[] args)
    {
        Character[] characters = new Character[]
        {
            new Warrior("Артур", 1, 100, 50),
            new Mage("Гендальф", 3, 70, 150),
            new Warrior("Бором", 2, 120, 60)
        };

        foreach (Character character in characters)
        {
            
            if (character is Warrior warrior)
            {
                Console.WriteLine("--- Это Воин ---");
                warrior.DisplayInfo();
                warrior.ShieldBash();
            }
            else if (character is Mage mage)
            {
                Console.WriteLine("--- Это Маг ---");
                mage.DisplayInfo();
                mage.CastSpell();
            }

            Console.WriteLine(); 
        }
        
    }

    class Character
    {
        public Character(string name, int level, int health)
        {
            this.name = name;
            this.level = level;
            this.health = health;
        }

        protected string name;
        protected int health;
        protected int level;

        protected void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Health: {health}");
        }
    }

    class Warrior : Character
    {
        protected int armor;

        public Warrior(string name, int level, int health, int armor) : base(name, level, health)
        {
            this.armor = armor;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Armor: {armor}");
        }

        public void ShieldBash()
        {
            Console.WriteLine($"Shield Bash");
        }
    }

    class Mage : Character
    {
        protected int mana;

        public Mage(string name, int level, int health, int mana) : base(name, level, health)
        {
            this.mana = mana;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Mana: {mana}");
        }

        public void CastSpell()
        {
            Console.WriteLine($"Cast Spell");
        }
    }
}