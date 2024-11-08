using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRB;
    public float jumpPower = 10;
    public LogicManager logicSript;
    public bool birdIsAlive = true;

    private int boundY = 16;

    // Start is called before the first frame update
    void Start()
    {
        logicSript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRB.velocity = Vector3.up * jumpPower;
        }

        if (transform.position.y > boundY || transform.position.y < -boundY)
        {
            if (birdIsAlive)
            {
                logicSript.gameOver();
                birdIsAlive = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            logicSript.gameOver();
            birdIsAlive = false;
        }
    }
}
