using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Score Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Bone").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.AddScore();
    }
}
