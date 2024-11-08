using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    public BirdController birdScript;

    private float timer = 0;
    private float heightOff = 10;

    // Start is called before the first frame update
    void Start()
    {
        birdScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdController>();

        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (birdScript.birdIsAlive)
            {
                spawnPipe();
                timer = 0;
            }
        }

    }

    void spawnPipe()
    {
        float maxY = transform.position.y - heightOff;
        float minY = transform.position.y + heightOff;

        Instantiate(pipe, new Vector2(transform.position.x, Random.Range(minY, maxY)), transform.rotation);
    }
}
