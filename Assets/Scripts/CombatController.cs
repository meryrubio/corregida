using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public Character character;
    public Character enemy;

    private SpriteRenderer _spriteRenderer;




    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();


    }




























    //    public Character playerCharacter;
    //    public Character enemyCharacter;

    //    // M�todo para manejar el turno del jugador
    //    public void PlayerTurn()
    //    {
    //        if (Input.GetMouseButtonDown(0)) // Bot�n izquierdo del rat�n para atacar
    //        {
    //            playerCharacter.Attack();
    //        }
    //        else if (Input.GetMouseButtonDown(1)) // Bot�n derecho del rat�n para curarse
    //        {
    //            playerCharacter.Heal();
    //        }
    //    }

    //    // M�todo para manejar el turno del enemigo
    //    public void EnemyTurn()
    //    {
    //        int randomNumber = Random.Range(0, 2); // 0 para atacar, 1 para curarse 
    //        if (randomNumber == 0)
    //        {
    //            enemyCharacter.Attack();
    //        }
    //        else
    //        {
    //            enemyCharacter.Heal();
    //        }
    //    }

    //public bool CheckForLoss(Character character)
    //{
    //    if (character.health <= 0)
    //    {
    //        Debug.Log(character.name + " ha perdido.");

    //        return true;
    //    }
    //    return false;
    //}

    //// M�todo para alternar entre los turnos del jugador y del enemigo
    //public void NextTurn()
    //    {
    //     PlayerTurn(); 
    //    if (!CheckForLoss(playerCharacter)) // Verifica si el jugador ha perdido antes de pasar al turno del enemigo
    //    {

    //        if (!CheckForLoss(enemyCharacter)) // Verifica si el enemigo ha perdido antes de pasar al turno del jugador
    //        {
    //            EnemyTurn(); // Luego el turno del enemigo
    //        }
    //    }

    //}
}

    //if (Input.GetMouseButtonDown(0)) // ataca
    //{

    //    //Attack(player, enemy);
    //    playerTurn = false;
    //    //Invoke("EnemyTurn", 1f); 
    //}
    //else if (Input.GetMouseButtonDown(1)) // curarse
    //{
    //    //Heal(player);
    //    playerTurn = false;
    //  /*  Invoke("EnemyTurn", 1f);*/ 
    //}


    //int randomAction = Random.Range(0, 2); // 0  para atacar, 1 curarse
    //if (randomAction == 0)
    //{
    //    //Attack(enemy, player);
    //}
    //else
    //{
    //    //Heal(enemy);
    //}
    //playerTurn = true;




