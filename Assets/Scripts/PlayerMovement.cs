using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float forwardForce;
    public float LRForce;

    private void Awake()
    {
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() // kalo physics pake fixedupdate aja dibandingkan update.
    {
        // Time.deltaTime dipake buat nyeimbangin frame rate sama detik.
        // Ini add force ke depan.
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0); 

        if(Input.GetKey("d"))
        {
            rb.AddForce(0, 0, LRForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -LRForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(rb.position.y<1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
