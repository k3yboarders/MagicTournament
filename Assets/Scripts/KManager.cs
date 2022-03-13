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
	TerazKolej.overrideSprite = grafiki[1];
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

    
    public int ChangePole(int ktore, int grafika)
    {

        if (kolejka == 1)
        {
            kolejka = 2;
            pola[ktore].image.sprite = grafiki[1];
      
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            pola[ktore].image.sprite = grafiki[2];
        }
        return 0;
    }
    public void zmienpole1(int na_co)
    {
        if (kolejka == 1)
        {
            kolejka = 2;
            pola[1].image.sprite = grafiki[1];
            ipola[1] = 1;
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            pola[1].image.sprite = grafiki[2];
            ipola[1] = 2;
        }
    }
    public void zmienpole0(int na_co)
    {
        if (kolejka == 1)
        {
            kolejka = 2;
            pola[0].image.sprite = grafiki[1];
            ipola[0] = 1;
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            pola[0].image.sprite = grafiki[2];
            ipola[0] = 2;
        }
    }
    public void zmienpole2(int na_co)
    {
        if (kolejka == 1)
        {
            kolejka = 2;
            ipola[2] = 1;
            pola[2].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            pola[2].image.sprite = grafiki[2];
            ipola[2] = 2;
        }
    }
    public void zmienpole3(int na_co)
    {
        if (kolejka == 1)
        {
            ipola[3] = 1;
            kolejka = 2;
            pola[3].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            ipola[3] = 2;
            pola[3].image.sprite = grafiki[2];
        }
    }
    public void zmienpole4(int na_co)
    {
        if (kolejka == 1)
        {
            ipola[4] = 1;
            kolejka = 2;
            pola[4].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            ipola[4] = 2;
            pola[4].image.sprite = grafiki[2];
        }
    }
    public void zmienpole5(int na_co)
    {
        if (kolejka == 1)
        {
            ipola[5] = 1;
            kolejka = 2;
            pola[5].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            ipola[5] = 2;
            pola[5].image.sprite = grafiki[2];
        }
    }
    public void zmienpole6(int na_co)
    {

        if (kolejka == 1)
        {
            ipola[6] = 1;
            kolejka = 2;
            pola[6].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            pola[6].image.sprite = grafiki[2];
            ipola[6] = 2;
        }
    }
    public void zmienpole7(int grafik)
    {


        if (kolejka == 1)
        {
            ipola[7] = 1;
            kolejka = 2;
            pola[7].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            ipola[7] = 2;
            pola[7].image.sprite = grafiki[2];
        }
    }
    public void zmienpole8(int grafik)
    {

        if (kolejka == 1)
        {
            ipola[8] = 1;
            kolejka = 2;
            pola[8].image.sprite = grafiki[1];
        }
        else if (kolejka == 2)
        {
            kolejka = 1;
            ipola[8] = 2;
            pola[8].image.sprite = grafiki[2];
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
