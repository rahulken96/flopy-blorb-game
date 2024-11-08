using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleController : MonoBehaviour
{
    public LogicManager logicSript;
    public int addScore;

    // Start is called before the first frame update
    void Start()
    {
        logicSript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logicSript.addScore(addScore);
        }
    }
}
