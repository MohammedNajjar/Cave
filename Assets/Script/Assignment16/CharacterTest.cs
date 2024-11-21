using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
        
            Officer officer = new Officer("Captain Smith", 100, new Position(1, 1, 1));

              Soldier soldier = new Soldier(); 

    
              Character[] characters = { officer, soldier };

           
            Debug.Log("Initial character information:");

       for (int i = 0; i < characters.Length; i++)
{
    characters[i].DisplayInfo();
}

        
            Debug.Log($"\nSoldier health before attack: {soldier.Health}");
            officer.Attack(30, soldier, "shooting");
            Debug.Log($"Soldier health after attack: {soldier.Health}");
        }
    }
}
