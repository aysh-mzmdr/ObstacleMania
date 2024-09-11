using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    void Update()
    {
        score.text=player.position.z.ToString("0");
    }
}
