using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject enemyPrefab;
    public int EnemiesToSpawn = 1000;

    public GameObject player;

    public GameObject mainMenu, settings;

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
            Instantiate(enemyPrefab);
        }
    }
    
}
