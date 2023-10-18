using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    //scenes reference 
    public GameObject titleScene;
    public GameObject charSelectionScene;
    public GameObject battleScene;
    public GameObject chestScene;
    public GameObject restScene;

    //public GameObject idleScene;
    public GameObject mapScene;

    //char selection UI
    public Image splashArt;
    public GameObject charSelectionObjects;

    //char selection
    public List<Character> charList;
    public Character selectedChar;
    public GameObject playerIcon;

    GameManager _gameManager;
}
