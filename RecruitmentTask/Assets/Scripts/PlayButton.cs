using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.instance.gameState = GameManager.GameState.GAME;
        GameManager.instance.mainMenu.SetActive(false);
        GameManager.instance.StartGame();
        GameManager.instance.canvasController.SetEventSystemFirstSelected(null);
    }
}
