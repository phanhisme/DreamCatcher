using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour
{
    public List<Card> cardDisplayList = new List<Card>();
    public int thisID;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDes;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI descriptionText;

    //this can use referencing late, there is no need to use all public

    void Start()
    {
        cardDisplayList[0] = CardDataBase.cardList[thisID];
    }

    // Update is called once per frame
    //void Update()
    //{
    //    id = cardDisplayList[0].id;
    //    name = cardDisplayList[0].cardName;
    //    cost = cardDisplayList[0].cost;
    //    power = cardDisplayList[0].power;
    //    cardDes = cardDisplayList[0].cardDes;

    //    //nameText
    //}
}
