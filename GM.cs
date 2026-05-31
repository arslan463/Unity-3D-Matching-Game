using TMPro;
using UnityEngine;

public class GM : MonoBehaviour
{

    public TextMeshProUGUI ScoreText;
    public Player_Control P;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        ScoreText.text = "Score = " + P.score;
    }

}

