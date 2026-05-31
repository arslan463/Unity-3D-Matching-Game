using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Cube : MonoBehaviour
{
    public GameObject P;
    public Player_Control S;

    void Start()
    {
        P = GameObject.FindWithTag("Player");
        S = P.GetComponent<Player_Control>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            S.score++;
            gameObject.SetActive(false);
        }
    }
}