using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedChar : MonoBehaviour
{
    // this holds the stats of the characters

    public int currentHP;
    public int maxHP;
    public int currentBlock = 0;

    //healthbar
    //public HealthBar charHealthBar;

    //buffs/debuffs
    public Effect overHeal;


    //ref
    public GameObject effectPrefabs;
    public GameObject damageIndicator;
    public Transform effectParent;
    public bool isPlayer;
    
    //check this ref
    private EnemyUnit enemy;
    private BattleManager battleManager;
    private GameManager gameManager;

    private void Awake()
    {
        enemy = GetComponent<EnemyUnit>();
        battleManager = GetComponent<BattleManager>();
        gameManager = GetComponent<GameManager>();

        currentHP = maxHP;
        //healthbar.slider -> update later
    }

    public void TakeDamage(int damage)
    {
        if (currentBlock > 0)
        {
            Debug.Log("you have taken " + damage + " damage");
            //amount of block enough to neutralize damage
            damage = BlockDamage(damage);
        }

        if (currentHP <= 0)
        {
            if (enemy != null)
            {
                //battleManager.EndFight(true);
            }
            else
            {
                //battleManager.EndFight(false);
            }

            //player dies
        }
    }

    public int BlockDamage(int damage)
    {
        if (currentBlock >= damage)
        {
            //if the player can block all -> take no damage
            currentBlock -= damage;
            damage = 0;
        }
        else
        {
            //if they cant block all, take the remaining damage, reset block to 0
            damage -= currentBlock;
            currentBlock = 0;
        }

        //fighterHealthBar.DisplayBlock(currentBlock);
        return damage;
    }

    //blocking action
    public void AddBlock(int blockAmount)
    {
        currentBlock += blockAmount;
    }

    //add buff here
}
