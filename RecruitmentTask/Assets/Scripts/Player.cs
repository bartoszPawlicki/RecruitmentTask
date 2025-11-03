using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    public void HandleMoevement()
    {
        Vector2 move = Vector2.zero;
        if (Keyboard.current.wKey.isPressed) move.y += 1;
        if (Keyboard.current.sKey.isPressed) move.y -= 1;
        if (Keyboard.current.aKey.isPressed) move.x -= 1;
        if (Keyboard.current.dKey.isPressed) move.x += 1;

        move = move.normalized * playerSpeed * Time.deltaTime;
        transform.position += (Vector3)move;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().DisableMovement();
        }
        
    }
    private void Update()
    {
        if (GameManager.instance.gameState == GameManager.GameState.GAME)
        {
            HandleMoevement();
        }
    }
}
