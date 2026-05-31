using System;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody rb;
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.W)))
        {
            // transform.Translate(Vector3.forward * speed * Time.deltaTime);
            rb.AddForce(Vector3.forward, ForceMode.Impulse);
        }

        if ((Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.S)))
        {
            // transform.Translate(Vector3.back * speed * Time.deltaTime);
            rb.AddForce(Vector3.back, ForceMode.Impulse);
        }

        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.A)))
        {
            // transform.Translate(Vector3.left * speed * Time.deltaTime);
            rb.AddForce(Vector3.left, ForceMode.Impulse);
        }

        if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.D)))
        {
            // transform.Translate(Vector3.right * speed * Time.deltaTime);
            rb.AddForce(Vector3.right, ForceMode.Impulse);
        }
    }
}