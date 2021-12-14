using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeOnLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject HelloMaze;
    void Start()
    {
        HelloMaze.SetActive(true);
    }

    void Update()
    {
        
    }
    public void MazeHide()
    {
        HelloMaze.SetActive(false);
    }
}
