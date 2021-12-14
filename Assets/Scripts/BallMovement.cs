using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody BallRB;
    void Start()
    {
        
        Launch();
    }


    void Update()
    {
        
    }
    void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        BallRB.velocity = new Vector3(speed * x * Time.deltaTime, speed * y * Time.deltaTime, 0f);
    }
}
