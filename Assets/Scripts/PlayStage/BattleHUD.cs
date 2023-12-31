using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public Slider hpSlider;

    public void SetHUD( PlayerUnit playerUnit)
    {
        nameText.text = playerUnit.unitName;
        hpSlider.maxValue = playerUnit.unitMaxHP;
        hpSlider.value = playerUnit.currentHP;
    }

    public void SetHP (int hp)
    {
        hpSlider.value = hp;
    }
}
