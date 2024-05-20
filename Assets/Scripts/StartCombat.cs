using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCombat : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement pm = collision.GetComponent<PlayerMovement>();
        if (pm)
        {
            pm.enabled = false;
            Enemies enemyType = (Enemies)Random.Range((int)Enemies.GOBLIN, (int)Enemies.SUKAMON);
            Character enemy = null;

            switch (enemyType)
            {
                case Enemies.SUKAMON:
                    enemy = new Sukamon();
                        break;
                case Enemies.GOBLIN:
                    enemy = new Goblin();
                        break;
            }
            CombatController combatController = new CombatController();
            combatController.enemy = enemy;// le pasa el enemigo que ha instanciado
        }
    }






    //public Text playerCharacterNameText;
    //public Text enemyCharacterNameText;

    //void Start()
    //{
    //    // Desactiva la interfaz al inicio
    //    gameObject.SetActive(false);
    //}

    //public void ShowCombatStart(Character playerCharacter, Character enemyCharacter)
    //{
    //    // Muestra los nombres de los personajes en los Textos
    //    playerCharacterNameText.text = playerCharacter.name;
    //    enemyCharacterNameText.text = enemyCharacter.name;


    //    gameObject.SetActive(true);
    //}
}



