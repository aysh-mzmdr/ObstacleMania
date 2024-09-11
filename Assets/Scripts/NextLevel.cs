using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject panel;

    void NextLevelCaller(){
        FindObjectOfType<GameManager>().NextLevelCaller();
    }
    void Start(){
        panel.SetActive(false);
    }
    void OnTriggerEnter(){
        panel.SetActive(true);
        Invoke("NextLevelCaller",1f);
    }
}
