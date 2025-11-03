using UnityEngine;
using UnityEngine.InputSystem;

public class BackButton : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.instance.gameState = GameManager.GameState.SETTINGS;
        GameManager.instance.settings.SetActive(false);
        GameManager.instance.mainMenu.SetActive(true);
    }

    private void Update()
    {
        if (GameManager.instance.gameState == GameManager.GameState.SETTINGS)
        {
            if (Keyboard.current.escapeKey.wasPressedThisFrame) OnClick();
        }
    }
}
