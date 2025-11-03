using UnityEngine;
using UnityEngine.InputSystem;

public class SettingsButton : MonoBehaviour
{
    public GameObject markedAsFirstSelected;
    public void OnClick()
    {
        GameManager.instance.gameState = GameManager.GameState.SETTINGS;
        GameManager.instance.settings.SetActive(true);
        GameManager.instance.mainMenu.SetActive(false);
        GameManager.instance.canvasController.SetEventSystemFirstSelected(markedAsFirstSelected);
    }
}
