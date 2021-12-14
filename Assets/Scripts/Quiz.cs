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
        questions.Add(new Question("Jakiego rodzaju czarodziejskiej krwi by³ H. Potter?", new string[] { "Pe³nej krwi", "Pó³krwi", "By³ mugolem", "Niewiadomo" }, 1));
        questions.Add(new Question("Jak nazywa³ siê ojciec Harrego Pottera?", new string[] { "James", "Jacob", "Jason", "Jerry" }, 0));
        questions.Add(new Question("Jak nazywa³a siê matka Harrego Pottera?", new string[] { "Lily", "Margaret", "Julie", "Jenny" }, 0));
        questions.Add(new Question("Jak nazywa siê g³ówny wróg Harrego Pottera?", new string[] { "Lord Voldemort", "Lord Jacobson", "Lord Vampire", "Lord McCallister" }, 0));
        questions.Add(new Question("Do jakiego domu w Hogwarcie nale¿a³ Harry Potter?", new string[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" }, 3));
        questions.Add(new Question("W jakim wieku Harry dowiedzia³ siê o swoim pochodzeniu?", new string[] { "12 lat", "10 lat", "11 lat", "13 lat" }, 2));
        questions.Add(new Question("Kim by³ Albus Dumbledore?", new string[] { "Dyrektorem Hogwartu", "Ministrem magii", "Mugolem", "Wêdrownym czarodziejem" }, 0));
        questions.Add(new Question("Nazwisko rodziny zastêpczej Harrego Pottera to:", new string[] { "Smith", "Dursley", "Walker", "Potter" }, 1));
        questions.Add(new Question("Co robi zaklêcie Aguamenti?", new string[] { "Wytwarza strumieñ ognia", "Sprawia, ¿e coœ jest niewidzialne", "Tworzy strumieñ wody", "Zamienia w królika" }, 2));
        questions.Add(new Question("Co czyni eliksir wielosokowy?", new string[] { "Zamienia osobê pij¹c¹ w kogoœ innego", "Daje niewidzialnoœæ", "Leczy rany", "Dodaje energii" }, 0));
        questions.Add(new Question("Czym jest nieœmia³ek?", new string[] { "Nieœmia³y czarodziej", "Niewielkie stworzenie pilnuj¹ce drzew", "Zaklêcie lecz¹ce nieœmia³oœæ", "Wstydliwe zwierze" }, 1));
        questions.Add(new Question("Ile pi³ek jest wykorzystywanych w grze Quidditch?", new string[] { "5", "10", "1", "4" }, 3));
        questions.Add(new Question("Na jakiej pozycji gra³ Harry Potter w Quidditchu?", new string[] { "Obroñca", "Szukaj¹cy", "Pa³karz", "Kapitan" }, 1));
        questions.Add(new Question("Co powoduje zaklêcia Bombardia?", new string[] { "Ma³¹ eksplozjê", "Du¿o eksplozjê", "Wyczrowanie bomby", "Zamienienie czegoœ w bombê" }, 0));
        questions.Add(new Question("Czym jest z³oty znicz?", new string[] { "Najwa¿niejszym elementem Quidditcha", "Przedmiotem w centrum Hogwartu", "Ró¿d¿k¹ Harrego", "Nagrod¹ za dobre oceny" }, 0));
        questions.Add(new Question("Kim jest dementor?", new string[] { "Osoba dementuj¹ca plotki", "Straszny, obrzydliwy demon", "Osoba dementuj¹ca przedmioty", "Sêdzie Quidditcha" }, 1));
        questions.Add(new Question("Co przydziela Tiara przydzia³u?", new string[] { "Ucznia do pokoju", "Zaklêcie do nauki", "Ró¿d¿kê dla ucznia", "Ucznia do domu" }, 3));
        questions.Add(new Question("Na czym poruszaj¹ siê zawodnicy Quidditcha?", new string[] { "Na koniach", "Na miot³ach", "Na nogach", "Teleportuj¹ siê" }, 1));
        questions.Add(new Question("Jaki efekt powoduje zaklêcie Sectumsempra?", new string[] { "Krwotoki w miejscu trafienia.", "Odebranie zdolnoœci mówienia", "Zablokowanie ró¿d¿ki", "Utratê wzroku" }, 0));
        questions.Add(new Question("Hogwart znajduje siê na terytorium:", new string[] { "Irlandii", "Niemiec", "Wielkiej Brytanii", "Francji" }, 2));
        questions.Add(new Question("Jak nazywa siê najbardziej znana ulica czarodziejów?", new string[] { "D³uga", "Krótka", "Magiczna", "Pok¹tna" }, 3));
        questions.Add(new Question("Jaki kolor w³osów ma Hermiona Granger?", new string[] { "Rudy", "Czarny", "Br¹zowy", "Ró¿owy" }, 0));
        questions.Add(new Question("Do jakiego domu nale¿a³ Draco Malfoy?", new string[] { "Slytherin", "Ravenclaw", "Hufflepuff", "Gryffindor" }, 0));
        questions.Add(new Question("Jak¹ moc¹ cechowa³ siê Kamieñ Filozoficzny?", new string[] { "Tworzy³ z³oto", "Zmienia³ w ¿abê", "Dawa³ nieskoñczon¹ moc", "Dawa³ niewidzialnoœæ" }, 0));
        questions.Add(new Question("Jak mia³ na imiê pan Snape?", new string[] { "Seweryn", "Severus", "Simon", "Luke" }, 1));
        questions.Add(new Question("Jaki pseudonim posiadaj¹ cz³onkowie domu Slytherin?", new string[] { "Puchacze", "Kujony", "Miêœniaki", "Œlizgoni" }, 3));
        questions.Add(new Question("Kto gra³ Harrego Pottera w serii filmów?", new string[] { "Johnny Depp", "Leonardo DiCaprio", "Daniel Radcliffe", "Brad Pitt" }, 2));
        questions.Add(new Question("Jak nazywa siê popularna firma produkuj¹ca miot³y sportowe?", new string[] { "Nimbus", "Szajbus", "Sportus", "Dobra miot³a" }, 0));
        questions.Add(new Question("Harry Potter i wiêzieñ Azkabanu to czêœæ numer:", new string[] { "1", "2", "3", "4" }, 2));
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
