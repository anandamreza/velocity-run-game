using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    PlayerMovement player;

    private void Awake()
    {
         player = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            player.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
