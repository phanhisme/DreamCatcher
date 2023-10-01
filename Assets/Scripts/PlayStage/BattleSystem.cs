using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//stating all stages of a game
public enum BattleStage { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public BattleStage stage;

    //battle stations - used to hold the enemy/player
    public GameObject enemyPrefab;
    public GameObject playerPrefab;

    //locations of the stations
    public Transform playerStation;
    public Transform enemyStation;

    public TextMeshProUGUI dialogueText;

    public BattleHUD playerHUD;

    void Start()
    {
        //default start of the stage
        stage = BattleStage.START;
        
        StartCoroutine(SetUpBattle());
    }

    IEnumerator SetUpBattle()
    {
        //get the logic of the player into the gameObject spawned
        GameObject playerGO = Instantiate(playerPrefab, playerStation);
        PlayerUnit playerScript = playerGO.GetComponent<PlayerUnit>(); //PlayerUnit is the script handling the stat of the player (this will be changed later)

        //spawning the enemy
        GameObject enemyGO = Instantiate(enemyPrefab, enemyStation); ;
        EnemyUnit enemyScript = enemyGO.GetComponent<EnemyUnit>();
        //EnemyUnit is the script handling the stat of the enemy, more enemy will be added in the future so take this as a reference piece for the basic enemy type - corrupted moon elves

        dialogueText.text = "A wild " + enemyScript.unitName + " approaches...";

        playerHUD.SetHUD(playerScript);

        yield return new WaitForSeconds(2f);

        stage = BattleStage.PLAYERTURN;
        PlayerTurn();

    }   

    void PlayerTurn()
    {
        dialogueText.text = "Choose an action";

    }

}
