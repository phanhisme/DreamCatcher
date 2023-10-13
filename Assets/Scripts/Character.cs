using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Character : ScriptableObject
{
    public enum CharacterClass { Dabria, Daella, Asif, Amias, Maeve }
    public CharacterClass characterClass;

    public GameObject characterPrefab;
    public Equipment startingEqipment;
    public Sprite featureImage;
    public List<Card> startingDeck;
}
