using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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
}
