using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    //Texty
    [SerializeField]
    private Text TitleText;
    [SerializeField]
    private Text QuestionText;
    [SerializeField]
    private Text AnswerA;
    [SerializeField]
    private Text AnswerB;
    [SerializeField]
    private Text AnswerC;
    [SerializeField]
    private Text AnswerD;
    [SerializeField]
    private Text AnswerTitle;
    [SerializeField]
    private Text GoodAnswer;
    [SerializeField]
    private Text ScoreText;
    //Inne obiekty
    [SerializeField]
    private Image CorrectAnswerImage;
    [SerializeField]
    private Sprite[] Answers = new Sprite[4];
    //Zmienne
    [SerializeField]
    private int[] pytania = new int[10];
    private int[] losowanie = new int[30];
    private int temp;
    List<Question> questions = new List<Question>();
    private System.Random rnd = new System.Random();
    [SerializeField]
    private int ActualQuestion;
    [SerializeField]
    private int PlayerScore;
    [SerializeField]
    private int actualtextint = 1;
    //Panele
    [SerializeField]
    private GameObject QuestionPanel;
    [SerializeField]
    private GameObject AnswerPanel;
    [SerializeField]
    private GameObject EndPanel;

    void Start()
    {
        StartQuiz();

    }
    public void StartQuiz()
    {
        actualtextint = 1;
        PlayerScore = 0;
        ActualQuestion = 0;
        LoadQuestions();
        RandomizeQuestions(10);
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(pytania[i]);
        }
        AnswerPanel.SetActive(false);
        EndPanel.SetActive(false);
        QuestionPanel.SetActive(true);
        UpdateQuestion(pytania[ActualQuestion]);
    }
    public void RandomizeQuestions(int ile)
    {

        for (int i = 0; i < ile; i++)
        {
            temp = rnd.Next(0, 30);
            if (losowanie[temp] == 0)
            {
                losowanie[temp] = 1;
                pytania[i] = temp;
            }
            else if (losowanie[temp] == 1)
            {
                while (losowanie[temp] == 1)
                {
                    temp = rnd.Next(0, 30);
                    if (losowanie[temp] == 0)
                    {
                        losowanie[temp] = 1;
                        pytania[i] = temp;
                        break;
                    }
                }
            }
        }
    }
    public void LoadQuestions()
    {
        questions.Add(new Question("Jakiego rodzaju czarodziejskiej krwi by� H. Potter?", new string[] { "Pe�nej krwi", "P�krwi", "By� mugolem", "Niewiadomo" }, 1));
        questions.Add(new Question("Jak nazywa� si� ojciec Harrego Pottera?", new string[] { "James", "Jacob", "Jason", "Jerry" }, 0));
        questions.Add(new Question("Jak nazywa�a si� matka Harrego Pottera?", new string[] { "Lily", "Margaret", "Julie", "Jenny" }, 0));
        questions.Add(new Question("Jak nazywa si� g��wny wr�g Harrego Pottera?", new string[] { "Lord Voldemort", "Lord Jacobson", "Lord Vampire", "Lord McCallister" }, 0));
        questions.Add(new Question("Do jakiego domu w Hogwarcie nale�a� Harry Potter?", new string[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" }, 3));
        questions.Add(new Question("W jakim wieku Harry dowiedzia� si� o swoim pochodzeniu?", new string[] { "12 lat", "10 lat", "11 lat", "13 lat" }, 2));
        questions.Add(new Question("Kim by� Albus Dumbledore?", new string[] { "Dyrektorem Hogwartu", "Ministrem magii", "Mugolem", "W�drownym czarodziejem" }, 0));
        questions.Add(new Question("Nazwisko rodziny zast�pczej Harrego Pottera to:", new string[] { "Smith", "Dursley", "Walker", "Potter" }, 1));
        questions.Add(new Question("Co robi zakl�cie Aguamenti?", new string[] { "Wytwarza strumie� ognia", "Sprawia, �e co� jest niewidzialne", "Tworzy strumie� wody", "Zamienia w kr�lika" }, 2));
        questions.Add(new Question("Co czyni eliksir wielosokowy?", new string[] { "Zamienia osob� pij�c� w kogo� innego", "Daje niewidzialno��", "Leczy rany", "Dodaje energii" }, 0));
        questions.Add(new Question("Czym jest nie�mia�ek?", new string[] { "Nie�mia�y czarodziej", "Niewielkie stworzenie pilnuj�ce drzew", "Zakl�cie lecz�ce nie�mia�o��", "Wstydliwe zwierze" }, 1));
        questions.Add(new Question("Ile pi�ek jest wykorzystywanych w grze Quidditch?", new string[] { "5", "10", "1", "4" }, 3));
        questions.Add(new Question("Na jakiej pozycji gra� Harry Potter w Quidditchu?", new string[] { "Obro�ca", "Szukaj�cy", "Pa�karz", "Kapitan" }, 1));
        questions.Add(new Question("Co powoduje zakl�cia Bombardia?", new string[] { "Ma�� eksplozj�", "Du�o eksplozj�", "Wyczrowanie bomby", "Zamienienie czego� w bomb�" }, 0));
        questions.Add(new Question("Czym jest z�oty znicz?", new string[] { "Najwa�niejszym elementem Quidditcha", "Przedmiotem w centrum Hogwartu", "R�d�k� Harrego", "Nagrod� za dobre oceny" }, 0));
        questions.Add(new Question("Kim jest dementor?", new string[] { "Osoba dementuj�ca plotki", "Straszny, obrzydliwy demon", "Osoba dementuj�ca przedmioty", "S�dzie Quidditcha" }, 1));
        questions.Add(new Question("Co przydziela Tiara przydzia�u?", new string[] { "Ucznia do pokoju", "Zakl�cie do nauki", "R�d�k� dla ucznia", "Ucznia do domu" }, 3));
        questions.Add(new Question("Na czym poruszaj� si� zawodnicy Quidditcha?", new string[] { "Na koniach", "Na miot�ach", "Na nogach", "Teleportuj� si�" }, 1));
        questions.Add(new Question("Jaki efekt powoduje zakl�cie Sectumsempra?", new string[] { "Krwotoki w miejscu trafienia.", "Odebranie zdolno�ci m�wienia", "Zablokowanie r�d�ki", "Utrat� wzroku" }, 0));
        questions.Add(new Question("Hogwart znajduje si� na terytorium:", new string[] { "Irlandii", "Niemiec", "Wielkiej Brytanii", "Francji" }, 2));
        questions.Add(new Question("Jak nazywa si� najbardziej znana ulica czarodziej�w?", new string[] { "D�uga", "Kr�tka", "Magiczna", "Pok�tna" }, 3));
        questions.Add(new Question("Jaki kolor w�os�w ma Hermiona Granger?", new string[] { "Rudy", "Czarny", "Br�zowy", "R�owy" }, 0));
        questions.Add(new Question("Do jakiego domu nale�a� Draco Malfoy?", new string[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" }, 0));
        questions.Add(new Question("Jak� moc� cechowa� si� Kamie� Filozoficzny?", new string[] { "Tworzy� z�oto", "Zmienia� w �ab�", "Dawa� niesko�czon� moc", "Dawa� niewidzialno��" }, 0));
        questions.Add(new Question("Jak mia� na imi� pan Snape?", new string[] { "Seweryn", "Severus", "Simon", "Luke" }, 1));
        questions.Add(new Question("Jaki pseudonim posiadaj� cz�onkowie domu Slytherin?", new string[] { "Puchacze", "Kujony", "Mi�niaki", "�lizgoni" }, 3));
        questions.Add(new Question("Kto gra� Harrego Pottera w serii film�w?", new string[] { "Johnny Depp", "Leonardo DiCaprio", "Daniel Radcliffe", "Brad Pitt" }, 2));
        questions.Add(new Question("Jak nazywa si� popularna firma produkuj�ca miot�y sportowe?", new string[] { "Nimbus", "Szajbus", "Sportus", "Dobra miot�a" }, 0));
        questions.Add(new Question("Harry Potter i wi�zie� Azkabanu to cz�� numer:", new string[] { "1", "2", "3", "4" }, 2));
    }
    void Update()
    {

    }
    public void Next()
    {
        actualtextint++;
        if (ActualQuestion < 9)
        {
            ActualQuestion++;
            UpdateQuestion(pytania[ActualQuestion]);
            AnswerPanel.SetActive(false);
            QuestionPanel.SetActive(true);
        }
        else
            EndQuiz();

    }
    public void BackToMenu()
    {
        QuestionPanel.SetActive(false);
        AnswerPanel.SetActive(false);
        EndPanel.SetActive(false);
    }
    public void ChooseA()
    {
        CheckCorrectAnswer(0, questions[pytania[ActualQuestion]].good);
    }
    public void ChooseB()
    {
        CheckCorrectAnswer(1, questions[pytania[ActualQuestion]].good);

    }
    public void ChooseC()
    {
        CheckCorrectAnswer(2, questions[pytania[ActualQuestion]].good);

    }
    public void ChooseD()
    {
        CheckCorrectAnswer(3, questions[pytania[ActualQuestion]].good);

    }
    public void CheckCorrectAnswer(int udzielona, int poprawna)
    {
        QuestionPanel.SetActive(false);
        AnswerPanel.SetActive(true);
        AnswerTitle.text = "Pytanie nr. " + actualtextint.ToString();
        CorrectAnswerImage.sprite = Answers[poprawna];
        GoodAnswer.text = questions[pytania[ActualQuestion]].answers[poprawna];
        int temp = 0;
        if (ActualQuestion < 10)
        {
            if (udzielona == poprawna)
            {
                PlayerScore++;
            }
        }
        else
        {
            EndQuiz();
        }

    }
    public void EndQuiz()
    {
        AnswerPanel.SetActive(false);
        QuestionPanel.SetActive(false);
        EndPanel.SetActive(true);
        ScoreText.text = PlayerScore.ToString() + "/10";
    }
    public void UpdateQuestion(int number)
    {
        TitleText.text = "Pytanie nr. " + actualtextint.ToString();
        QuestionText.text = questions[number].question_text;
        AnswerA.text = questions[number].answers[0];
        AnswerB.text = questions[number].answers[1];
        AnswerC.text = questions[number].answers[2];
        AnswerD.text = questions[number].answers[3];
    }
}
class Question
{
    public string question_text;
    public string[] answers = new string[4];
    public int good;
    public Question(string txt, string[] a, int g)
    {
        question_text = txt;
        for (int i = 0; i < 4; i++)
            answers[i] = a[i];
        good = g;
    }

}
