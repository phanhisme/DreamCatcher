using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    //menu scene
    public GameObject titleScene;
    public GameObject charSelectionScene;
    
    //gameplay scene
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
    //BattleManager _battleManager;
    //EndScreen endScreen;
    //SceneFadeEffect sceneFadeEffect;

    public enum Encounter { enemy, boss, restSite}

    private void Awake()
    {
        _gameManager = GetComponent<GameManager>();
        //_battleManager=FindObjectOfType<>
        //endScreen=FindObjectOfType<>
        //sceneFadeEffect=FindObjectOfType<>
    }

    //play button
    public void PlayGame()
    {
        //hide title scene
        titleScene.SetActive(false);
    }

    public void SelectCharacters(int i)
    {
        selectedChar = charList[i];
        //changing the sprite only -> this will not change bg image
        splashArt.sprite = selectedChar.featureImage;
    }

    public void StartGame()
    {
        //load map to choose path
        StartCoroutine(LoadScene("Map"));
        _gameManager.LoadCharacterStats();
    }

    public void SelectScene(string sceneName)
    {
        //StartCoroutine(LoadScene(sceneName));
    }

    public IEnumerator LoadScene(string sceneToLoad)
    {
        //Scene To Load here
        yield return new WaitForSeconds(1f);
    }
}
