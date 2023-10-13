using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card: ScriptableObject
{
    //basic info of the cards
    public bool isUpgraded;
    public string cardName;
    public CardAmount cardCost;
    public CardAmount cardEffect;
    public CardAmount buffAmount;

    public Sprite cardImage;
    public CardDescription cardDes;

    public CardType cardTyple;
    public CardElement cardElement;
    public CardClass cardClass;
    public CardTargetType cardTarget;

    public enum CardType { Attack, Passive, Defense}
    public enum CardElement { Dream, Reality, Madness}
    public enum CardClass { Dabria, Dealla, Asif, Amias, Maeve, Curse}
    public enum CardTargetType { Self, Enemy }

    public int GetCardCost()
    {
        //handling the card cost of the normal and upgraded version of the card
        if (!isUpgraded)
        {
            return cardCost.baseAmount;
        }
        else
            return cardCost.upgradedAmount;
    }
    public int GetCardEffectAmount()
    {
        if (!isUpgraded)
            return cardEffect.baseAmount;
        else
            return cardEffect.upgradedAmount;
    }
    public string GetCardDescriptionAmount()
    {
        if (!isUpgraded)
            return cardDes.baseAmount;
        else
            return cardDes.upgradedAmount;
    }
    public int GetBuffAmount()
    {
        if (!isUpgraded)
            return buffAmount.baseAmount;
        else
            return buffAmount.upgradedAmount;
    }

    [System.Serializable]
    public struct CardAmount
    {
        public int baseAmount;
        public int upgradedAmount;
    }
    [System.Serializable]
    public struct CardDescription
    {
        public string baseAmount;
        public string upgradedAmount;
    }
    [System.Serializable]
    public struct CardBuffs
    {
        //public Buff.Type buffType;
        public CardAmount buffAmount;
    }
}

//public Card(int ID,string CardName,int Cost,int Power,string CardDes)
//{
//id = ID;
//cardName = CardName;
//cardCost = Cost;
//cardDes = CardDes;
//}
