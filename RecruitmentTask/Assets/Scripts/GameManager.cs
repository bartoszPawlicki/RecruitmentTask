using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        MENU,
        SETTINGS,
        GAME
    }

    public static GameManager instance;

    public GameObject enemyPrefab, enemies, player, mainMenu, settings, markedAsFirstSelected;
   
    public CanvasController canvasController;
    public int EnemiesToSpawn = 1000;
    public GameState gameState;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    private void Start()
    {
        gameState = GameState.MENU;
    }
    private void Update()
    {
        if (instance.gameState == GameState.GAME)
        {
            if (Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                instance.gameState = GameState.MENU;
                instance.mainMenu.SetActive(true);
                ResetGame();
                instance.canvasController.SetEventSystemFirstSelected(markedAsFirstSelected);
            }
        }
    }
    public void StartGame()
    {
        CreateEnemies();
        player.SetActive(true);
    }

    private void ResetGame()
    {
        player.SetActive(false);
        for (int i = 0; i < enemies.transform.childCount; i++)
        {
            enemies.transform.GetChild(i).gameObject.SetActive(false);
            enemies.transform.GetChild(i).position = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
            enemies.transform.GetChild(i).GetComponent<Enemy>().moving = true;
        }
    }
    
    public void CreateEnemies()
    {
        for (int i = 0; i < EnemiesToSpawn; i++)
        {
            var temp = Instantiate(enemyPrefab, new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0), Quaternion.identity);
            temp.transform.parent = enemies.transform;
            temp.SetActive(true);
        }
    }
}
