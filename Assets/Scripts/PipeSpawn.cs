using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float pipeOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnPipe();
        }
    }


    void spawnPipe()
    {

        float lowestPoint = transform.position.y - pipeOffset;
        float heighestPoint = transform.position.y + pipeOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
