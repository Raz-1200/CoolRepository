using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public int flap;
    public Score Score;
    public bool birdısAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Score = GameObject.FindGameObjectWithTag("Bone").GetComponent<Score>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdısAlive)
        {
            rigidBody.velocity = Vector2.up * flap;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score.GameOver();
        birdısAlive = false;
    }
}
