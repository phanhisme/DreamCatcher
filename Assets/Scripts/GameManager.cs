using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public Character character;
	public List<Card> playerDeck = new List<Card>();
	public List<Card> cardLibrary = new List<Card>();
	public List<Equipment> equips = new List<Equipment>();
	public List<Equipment> equipStorage = new List<Equipment>();
	public int floorNumber = 1;
	public int goldAmount;
	
	//display stat on canvas
	//PlayerStatsUI playerStatsUI;

	private void Awake()
	{
		//display stats
		//playerStatsUI = FindObjectOfType<PlayerStatsUI>();
	}
	public void LoadCharacterStats()
	{
		equips.Add(character.startingEqipment);
		//playerStatsUI.playerStatsUIObject.SetActive(true);
		//playerStatsUI.DisplayRelics();
	}
	public bool CheckEquipment(string eName)
	{
		foreach (Equipment item in equips)
		{
			if (item.itemName == eName)
				return true;
		}
		return false;
	}
	public void UpdateFloorNumber()
	{
		floorNumber += 1;
		//playerStatsUI.floorText.text = floorNumber + " Floor";
	}
	public void UpdateGoldNumber(int newGold)
	{
		goldAmount += newGold;
		//playerStatsUI.moneyAmountText.text = goldAmount.ToString();
	}
	public void DisplayHealth(int healthAmount, int maxHealth)
	{
		//playerStatsUI.healthDisplayText.text = $"{healthAmount} / {maxHealth}";
	}
}
