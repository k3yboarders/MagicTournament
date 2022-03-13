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

        questions.Add(new Question("Jakiego rodzaju czarodziejskiej krwi był H. Potter?", new string[] { "Pełnej krwi", "Półkrwi", "Był mugolem", "Nie wiadomo" }, 1));
        questions.Add(new Question("Jak nazywał się ojciec Harrego Pottera?", new string[] { "James", "Jacob", "Jason", "Jerry" }, 0));
        questions.Add(new Question("Jak nazywała się matka Harrego Pottera?", new string[] { "Lily", "Margaret", "Julie", "Jenny" }, 0));
        questions.Add(new Question("Jak nazywa się główny wróg Harrego Pottera?", new string[] { "Lord Voldemort", "Lord Jacobson", "Lord Vampire", "Lord McCallister" }, 0));
        questions.Add(new Question("Do jakiego domu w Hogwarcie należał Harry Potter?", new string[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" }, 3));
        questions.Add(new Question("W jakim wieku Harry dowiedział się o swoim pochodzeniu?", new string[] { "12 lat", "10 lat", "11 lat", "13 lat" }, 2));
        questions.Add(new Question("Kim był Albus Dumbledore?", new string[] { "Dyrektorem Hogwartu", "Ministrem magii", "Mugolem", "Wędrownym czarodziejem" }, 0));
        questions.Add(new Question("Nazwisko rodziny zastępczej Harrego Pottera to:", new string[] { "Smith", "Dursley", "Walker", "Potter" }, 1));
        questions.Add(new Question("Co robi zaklęcie Aguamenti?", new string[] { "Wytwarza strumień ognia", "Sprawia, że coś jest niewidzialne", "Tworzy strumień wody", "Zamienia w królika" }, 2));
        questions.Add(new Question("Co czyni eliksir wielosokowy?", new string[] { "Zamienia osobę pijącą w kogoś innego", "Daje niewidzialność", "Leczy rany", "Dodaje energii" }, 0));
        questions.Add(new Question("Czym jest nieśmiałek?", new string[] { "Nieśmiały czarodziej", "Niewielkie stworzenie pilnujące drzew", "Zaklęcie leczące nieśmiałość", "Wstydliwe zwierzę" }, 1));
        questions.Add(new Question("Ile piłek jest wykorzystywanych w grze Quidditch?", new string[] { "5", "10", "1", "4" }, 3));
        questions.Add(new Question("Na jakiej pozycji grał Harry Potter w Quidditchu?", new string[] { "Obrońca", "Szukający", "Pałkarz", "Kapitan" }, 1));
        questions.Add(new Question("Co powoduje zaklęcia Bombardia?", new string[] { "Małą eksplozję", "Dużo eksplozję", "Wyczrowanie bomby", "Zamienienie czegoś w bombę" }, 0));
        questions.Add(new Question("Czym jest złoty znicz?", new string[] { "Najważniejszym elementem Quidditcha", "Przedmiotem w centrum Hogwartu", "Różdżką Harrego", "Nagrodą za dobre oceny" }, 0));
        questions.Add(new Question("Kim jest dementor?", new string[] { "Osoba dementująca plotki", "Straszny, obrzydliwy demon", "Osoba dementująca przedmioty", "Sędziowie Quidditcha" }, 1));
        questions.Add(new Question("Co przydziela Tiara przydziału?", new string[] { "Ucznia do pokoju", "Zaklęcie do nauki", "Różdżkę dla ucznia", "Ucznia do domu" }, 3));
        questions.Add(new Question("Na czym poruszają się zawodnicy Quidditcha?", new string[] { "Na koniach", "Na miotłach", "Na nogach", "Teleportują się" }, 1));
        questions.Add(new Question("Jaki efekt powoduje zaklęcie Sectumsempra?", new string[] { "Krwotoki w miejscu trafienia.", "Odebranie zdolności mówienia", "Zablokowanie różdżki", "Utratę wzroku" }, 0));
        questions.Add(new Question("Hogwart znajduje się na terytorium:", new string[] { "Irlandii", "Niemiec", "Wielkiej Brytanii", "Francji" }, 2));
        questions.Add(new Question("Jak nazywa się najbardziej znana ulica czarodziejów?", new string[] { "Długa", "Krótka", "Magiczna", "Pokątna" }, 3));
        questions.Add(new Question("Jaki kolor włosów ma Hermiona Granger?", new string[] { "Rudy", "Czarny", "Brązowy", "Różowy" }, 0));
        questions.Add(new Question("Do jakiego domu należał Draco Malfoy?", new string[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" }, 0));
        questions.Add(new Question("Jaką mocą cechował się Kamień Filozoficzny?", new string[] { "Tworzył złoto", "Zmieniał w żabę", "Dawał nieskończoną moc", "Dawał niewidzialność" }, 0));
        questions.Add(new Question("Jak miał na imię pan Snape?", new string[] { "Seweryn", "Severus", "Simon", "Luke" }, 1));
        questions.Add(new Question("Jaki pseudonim posiadają członkowie domu Slytherin?", new string[] { "Puchacze", "Kujony", "Mięśniaki", "Ślizgoni" }, 3));
        questions.Add(new Question("Kto grał Harrego Pottera w serii filmów?", new string[] { "Johnny Depp", "Leonardo DiCaprio", "Daniel Radcliffe", "Brad Pitt" }, 2));
        questions.Add(new Question("Jak nazywa się popularna firma produkująca miotły sportowe?", new string[] { "Nimbus", "Szajbus", "Sportus", "Dobra miotła" }, 0));
        questions.Add(new Question("Harry Potter i więzień Azkabanu to część numer:", new string[] { "1", "2", "3", "4" }, 2));
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
