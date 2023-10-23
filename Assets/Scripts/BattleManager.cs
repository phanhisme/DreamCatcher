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
    public List<Card> cardsInHandGO = new List<Card>();
}
