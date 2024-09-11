using UnityEngine;

public class checkCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collionInfo){
        if(collionInfo.collider.tag == "ObstacleTag"){
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
