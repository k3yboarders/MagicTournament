using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public Text PlayerOneScore;
    [SerializeField]
    public Text PlayerTwoScore;
    [SerializeField]
    public int PlayerOne;
    [SerializeField]
    public int PlayerTwo;
    [SerializeField]
    private GameObject WinPanel;
    [SerializeField]
    private Text WinText;
    void Start()
    {
                
    }


    void Update()
    {
        if(PlayerTwo >= 21)
        {
            WinPanel.SetActive(true);
            WinText.text = "Gracz drugi wygra³";
        }
        else if (PlayerOne >= 21)
        {
            WinPanel.SetActive(true);
            WinText.text = "Gracz pierwszy wygra³";
        }
    }
    
    public void AddScore1()
    {
        PlayerTwo++;
        PlayerTwoScore.text = "Score: " + PlayerTwo.ToString();
    }
    public void AddScore2()
    {
        PlayerOne++;
        PlayerOneScore.text ="Score: " + PlayerOne.ToString();
    }
}
