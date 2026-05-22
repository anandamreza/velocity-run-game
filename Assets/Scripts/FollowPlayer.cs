using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;
    public Vector3 offset;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
