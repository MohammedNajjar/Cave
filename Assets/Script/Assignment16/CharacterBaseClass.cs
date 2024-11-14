using UnityEngine;

namespace Assignment18
{
    public class Character
    {
    
        public string name;         
        private int health;        
        protected Position position; 

      
        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); } 
        }

      
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.Health = health;
            this.position = position;
        }


        public Character() : this("No name", 100, new Position(0, 0, 0))
        {
        }

   
        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}");
            Debug.Log($"Health: {Health}");
            position.PrintPosition();
        }

        public void Attack(int damage, Character target)
        {
            PerformAttack(damage, target, null);
        }
       
        public void Attack(int damage, Character target, string attackType)
        {
            PerformAttack(damage, target, attackType);
        }

        private void PerformAttack(int damage, Character target, string attackType)
        {
            target.Health -= damage;
            string attackMessage = $"{name} attacked {target.name} for {damage} damage";
            if (!string.IsNullOrEmpty(attackType))
            {
                attackMessage += $" by {attackType}";
            }
            Debug.Log(attackMessage);
        }
    }
}