using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    void FixedUpdate()
    {
        rb.AddForce(0,0,1000*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(25*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-25*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(player.position.y <=-0.5){
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
