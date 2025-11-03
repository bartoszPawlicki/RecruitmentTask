using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool moving = true;
    public float speed = 2;

    public void DisableMovement()
    {
        moving = false;
    }
    void Update()
    {
        if(GameManager.instance.gameState == GameManager.GameState.GAME && moving)
        {
            Vector3 dir = transform.position - GameManager.instance.player.transform.position;
            transform.position += speed * Time.deltaTime * dir.normalized;
        }
    }
}
