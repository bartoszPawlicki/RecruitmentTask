using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.instance.gameState = GameManager.GameState.SETTINGS;
        GameManager.instance.settings.SetActive(true);
        GameManager.instance.mainMenu.SetActive(false);
    }
}
