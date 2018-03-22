using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // declaration
            int damage;

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
                AttackBonus = true
            };

            Dice dice = new Dice();

            // perform bonus attacks and display results if characters have a AttackBonus
            if (hero.AttackBonus || monster.AttackBonus)
            {
                if (hero.AttackBonus)
                {
                    msgLabel.Text += "*** Bonus Attack by Hero ***<br>";
                    // hero attacks monster, monster defends
                    damage = hero.Attack(dice);
                    monster.Defend(damage);
                };

                if (monster.AttackBonus)
                {
                    msgLabel.Text += "*** Bonus Attack by Monster ***<br>";
                    // monster attacks hero, hero defends defends
                    damage = monster.Attack(dice);
                    hero.Defend(damage);
                };

                DisplayResult(hero, monster);
            }

            // perform the battle
            do
            {
                // hero attacks monster, monster defends
                damage = hero.Attack(dice);
                monster.Defend(damage);

                // monster attacks hero, hero defends defends
                damage = monster.Attack(dice);
                hero.Defend(damage);

                // display results
                DisplayResult(hero, monster);

            } while (hero.Health > 0 && monster.Health > 0);
        }

        private void DisplayStats(Character character) =>
                msgLabel.Text += String.Format("{0}'s Health: {1}   (Max Damage: {2} Attack Bonus: {3})<br>",
                character.Name, character.Health, character.DamageMaximum, Convert.ToString(character.AttackBonus));

        private void DisplayResult(Character opponent1, Character opponent2)
        {
            DisplayStats(opponent1);
            DisplayStats(opponent2);
            msgLabel.Text += "-------------------------------------------------------------------------------------------<br>";

            if (opponent1.Health > 0 && opponent2.Health > 0) return;
            else if (opponent1.Health <= 0 && opponent2.Health <= 0) msgLabel.Text += "<br><em>Both hero and monster lose!</em>";
            else if (opponent1.Health <= 0) msgLabel.Text += "<br><em>****************** Monster wins! ******************</em>";
            else if (opponent2.Health <= 0) msgLabel.Text += "<br><em>****************** Hero wins! ******************</em>";
        }
    }

    class Character
    {
        // properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        // randomly determine damage the character inflicted and return the value
        public int Attack(Dice dice)
        {
            dice.Sides = this.DamageMaximum;
            return dice.Roll();
        }

        // deduct damage from the character's health
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }

    class Dice
    {
        // number of possible results 
        public int Sides { get; set; }

        // declare random
        Random random = new Random();

        // returns random number rolled
        public int Roll()
        {            
            int damage = random.Next(1, this.Sides);
            return damage;
        }
    }
}