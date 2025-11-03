using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject enemyPrefab, enemies;
    public int EnemiesToSpawn = 1000;

    public GameObject player;

    public GameObject mainMenu, settings;

    public List<GameObject> enemiesList;

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
    public enum GameState
    {
        MENU,
        SETTINGS,
        GAME
    }
    public GameState gameState;

    private void Start()
    {
        gameState = GameState.MENU;
    }

    public void StartGame()
    {
        CreateEnemies();
    }
    private void Update()
    {
        if (instance.gameState == GameState.GAME)
        {
            if (Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                instance.gameState = GameState.MENU;
                instance.mainMenu.SetActive(true);
            }
        }
    }

    public void CreateEnemies()
    {
        for (int i = 0; i < EnemiesToSpawn; i++)
        {
            var temp = Instantiate(enemyPrefab, new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0), Quaternion.identity);
            temp.transform.parent = enemies.transform;
        }
    }
    
}
