using System;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // create Hero
            Character hero = new Character
            {
                Name = "Superman",
                Health = 500,
                DamageMaximum = 100,
                AttackBonus = true
            };

            // create Monster
            Character monster = new Character
            {
                Name = "Bizarro",
                Health = 500,
                DamageMaximum = 100,
                AttackBonus = false
            };

            // hero attacks monster, monster defends
            int damage = hero.Attack();
            monster.Defend(damage);           

            // monster attacks hero, hero defends defends
            damage = monster.Attack();
            hero.Defend(damage);           

            // display results
            displayStats(hero);
            displayStats(monster);
        }

        private void displayStats(Character character) => 
                msgLabel.Text += String.Format("{0}'s Stats:<br>Health: {1}<br> Max Damage: {2}<br> Attack Bonus: {3}<br><br>",
                character.Name, character.Health, character.DamageMaximum, Convert.ToString(character.AttackBonus));
    }

    class Character
    {
        // properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        // randomly determine damage the character inflicted and return the value
        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(1, this.DamageMaximum);
            return damage;
        }

        // deduct damage from the character's health
        public void Defend(int damage)
        {
            this.Health -= damage;                
        }
    }
}