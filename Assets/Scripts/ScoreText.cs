using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    Transform player; 
    public TextMeshProUGUI score;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        float absX = Mathf.Abs(player.position.x);
        score.text = absX.ToString("0");
    }
}
