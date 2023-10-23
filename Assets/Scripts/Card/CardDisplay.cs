using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    //display
    public Card card;
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI descriptionText;
    
    //data
    public int cost;
    public int power;

    public Image cardIcon;
    public GameObject discardEffect;
    private BattleManager _battleManager;
    private Animator cardAnim;

    //this can use referencing late, there is no need to use all public

    void Start()
    {
        //reference
        _battleManager = FindObjectOfType<BattleManager>();
        cardAnim = GetComponent<Animator>();
        
        //cardDisplayList[0] = CardDataBase.cardList[thisID];
    }

    private void OnEnable()
    {
        //stay still
        cardAnim.Play("Idle");
    }

    public void LoadCard(Card loadedCard)
    {
        card = loadedCard;
        gameObject.GetComponent<RectTransform>().localScale = new Vector2(1, 1);

        cardName.text = card.cardName;
        descriptionText.text = card.GetCardDescriptionAmount();
        costText.text = card.GetCardCost().ToString();
        cardIcon.sprite = card.cardImage;
    }

    public void SelectedCard()
    {
        Debug.Log(name + " is selected");
        _battleManager.selectedCard = this;

        //play an animation (can add in some effect like drag and target system later)
    }

    public void DeselectCard()
    {
        _battleManager.selectedCard = null;
        cardAnim.Play("Idle");
    }
}
