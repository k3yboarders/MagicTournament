using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bramka1Script : MonoBehaviour
{
    [SerializeField]
    private GameObject GameManager;
    [SerializeField]
    private GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            GameManager.GetComponent<GameManager>().AddScore1();
            Ball.transform.position = new Vector3(0, 0, 0);
        }
    }
}
