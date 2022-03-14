using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KManager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] grafiki = new Sprite[3];
    [SerializeField]
    private Button[] pola = new Button[9];
    [SerializeField]
    private int[] ipola = new int[9];
    [SerializeField]
    private int kolejka;
    [SerializeField]
    private GameObject WinPanel;
    [SerializeField]
    private Text WinText;
    [SerializeField]
    private Image TerazKolej;
    void Start()
    {
        kolejka = 1;
        for (int i = 0; i < 9; i++)
        {
            pola[i].image.sprite = grafiki[0];
        }
	TerazKolej.sprite = grafiki[1];
    }

    void Update()
    {
        Wygrana();
    }
    /* Funkcja sprawdzająca czy plansza jest zapełniona*/
    private bool IsFull()
    {
	for(int i = 0; i < 9; i++)
	{
	    if(ipola[i] == 0)
		return false;
	}
	return true;
    }
    /* Funckcja wywoływana gdy gra skończy się remisem */
    private void Draw()
    {
        WinPanel.SetActive(true);
        WinText.text = "Remis!";
    }

    
    public void ChangeField(int which)
    {

        if (kolejka == 1)
        {
            kolejka = 2;
            pola[which].image.sprite = grafiki[1];
	    ipola[which] = 1;
	    TerazKolej.sprite = grafiki[2];
      
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
	    ipola[which] = 2;
            pola[which].image.sprite = grafiki[2];
	    TerazKolej.sprite = grafiki[1];
	}
    }
    public void Wygrana()
    {
        if (ipola[0] == 1 && ipola[1] == 1 && ipola[2] == 1)
        {
            Win(1);
        }
        else if (ipola[3] == 1 && ipola[4] == 1 && ipola[5] == 1)
        {
            Win(1);
        }
        else if (ipola[6] == 1 && ipola[7] == 1 && ipola[8] == 1)
        {
            Win(1);
        }
        else if (ipola[0] == 1 && ipola[3] == 1 && ipola[6] == 1)
        {
            Win(1);
        }
        else if (ipola[1] == 1 && ipola[4] == 1 && ipola[7] == 1)
        {
            Win(1);
        }
        else if (ipola[2] == 1 && ipola[5] == 1 && ipola[8] == 1)
        {
            Win(1);
        }
        else if (ipola[0] == 1 && ipola[4] == 1 && ipola[8] == 1)
        {
            Win(1);
        }
        else if (ipola[2] == 1 && ipola[4] == 1 && ipola[6] == 1)
        {
            Win(1);
        }
	else if(ipola[0] == 1 && ipola[4] == 1 && ipola[8] == 1)
	    Win(1);
	else if(ipola[2] == 1 && ipola[4] == 1 && ipola[6] == 1)
	    Win(1);
        else if (ipola[0] == 2 && ipola[1] == 2 && ipola[2] == 2)
        {
            Win(2);
        }
        else if (ipola[3] == 2 && ipola[4] == 2 && ipola[5] == 2)
        {
            Win(2);
        }
        else if (ipola[6] == 2 && ipola[7] == 2 && ipola[8] == 2)
        {
            Win(2);
        }
        else if (ipola[0] == 2 && ipola[3] == 2 && ipola[6] == 2)
        {
            Win(2);
        }
        else if (ipola[1] == 2 && ipola[4] == 2 && ipola[7] == 2)
        {
            Win(2);
        }
        else if (ipola[2] == 2 && ipola[5] == 2 && ipola[8] == 2)
	    Win(2);
        
        else if (ipola[0] == 2 && ipola[4] == 2 && ipola[8] == 2)
        {
            Win(2);
        }
        else if (ipola[2] == 2 && ipola[4] == 2 && ipola[6] == 2)
        {
            Win(2);
        }
	else if(IsFull())
	    Draw();
    }
    public void Win(int gracz)
    {
        WinPanel.SetActive(true);
        WinText.text = "Wygrał gracz " + gracz + "!";
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);

    }
}
