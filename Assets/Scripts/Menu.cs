using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayPanel;
    [SerializeField]
    private GameObject AboutPanel;
    [SerializeField]
    private GameObject OptionsPanel;
    [SerializeField]
    private GameObject MainPanel;
    [SerializeField]
    private float volume;
    [SerializeField]
    private Slider VolumeSlider;
    [SerializeField]
    private GameObject MenuObject;
    [SerializeField]
    private GameObject QuizObject;
    [SerializeField]
    private Canvas canvas;
    void Start()
    {
        DefaultPanel();
        volume = PlayerPrefs.GetFloat("Volume");
        VolumeSlider.value = volume;
    }

    void Update()
    {

    }
    public void DefaultPanel()
    {
        MenuObject.SetActive(true);
        QuizObject.SetActive(false);
        MainPanel.SetActive(true);
        PlayPanel.SetActive(false);
        OptionsPanel.SetActive(false);
        AboutPanel.SetActive(false);
    }
    public void Play()
    {
        MainPanel.SetActive(false);
        PlayPanel.SetActive(true);
    }
    public void Maze()
    {
        SceneManager.LoadScene(1);
    }
    public void Rubik()
    {
        
    }
    public void Quidditch()
    {
        SceneManager.LoadScene(2);
    }
    public void Quiz()
    {
        QuizObject.SetActive(true);
        MenuObject.SetActive(false);
        canvas.GetComponent<Quiz>().StartQuiz();
    }
    public void Options()
    {
        MainPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }
    public void About()
    {
        MainPanel.SetActive(false);
        AboutPanel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    public void ChangeVolume()
    {
        volume = VolumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
