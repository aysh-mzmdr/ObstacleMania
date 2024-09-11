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
    void Update(){
        if(Input.touchCount > 0){
            Touch touch=Input.GetTouch(0);
            Vector3 objectPosition=getPositionByTouch();
            objectPosition.z=transform.position.z;
            objectPosition.y=transform.position.y;

            switch(touch.phase){
                case TouchPhase.Began:
                    transform.position=objectPosition;
                    break;

                case TouchPhase.Moved:
                case TouchPhase.Stationary:
                    // Lerp means linear Interpolation; draws a line from transform.position to objectPosition
                    transform.position=Vector3.Lerp(transform.position,objectPosition,Time.deltaTime * 10f);
                    break;
            }   
        }
    }
    Vector3 getPositionByTouch(){
        Vector3 getPositionOfTouch=Input.GetTouch(0).position;
        Vector3 sendPositionOfTouch=Camera.main.ScreenToWorldPoint(new Vector3(getPositionOfTouch.x,1.1f,0));
        return sendPositionOfTouch;
    }
}
