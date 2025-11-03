using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.instance.gameState = GameManager.GameState.SETTINGS;
        GameManager.instance.settings.SetActive(false);
        GameManager.instance.mainMenu.SetActive(true);
    }
}
