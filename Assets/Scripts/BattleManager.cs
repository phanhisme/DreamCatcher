using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    //cards manager
    public List<Card> deck;
    public List<Card> drawPile = new List<Card>();
    public List<Card> discardPile = new List<Card>();
    public List<Card> cardsInHand = new List<Card>();
    public CardDisplay selectedCard;

    //questionable
    public List<CardDisplay> cardsInHandGO = new List<CardDisplay>();

    //selected char stats 
    public SelectedChar target;
    public SelectedChar player;

    public int maxEnergy;
    public int energy;
    public int drawAmount = 5;
    
    //turn and target
    public Turn turn;
    public enum Turn { Player, Enemy };

    //enemy
    public List<EnemyUnit> enemy;

    //general
    private GameManager gameManager;
    //private CardActions cardActions;
    //PlayerStatsUI playerStatsUI;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        //cardActions = GetComponent<CardActions>();
        //playerStatsUI = FindObjectOfType<PlayerStatsUI>();
    }

    public void StartFight()
    {
        //
    }
}
