using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //components
    private Rigidbody playerRB;
    Transform playerAvatar;
    Animator playerAnimation;
    //movement
    [SerializeField]
    private float speed;
    [SerializeField]
    private float speedValue;
    [SerializeField]
    private float runSpeedValue;
    private float Vertical1;
    private float Horizontal1;
    [SerializeField]
    private int score;
    [SerializeField]
    private Text WinText;
    [SerializeField]
    public Text PlayerOneScore;
    [SerializeField]
    public Text PlayerTwoScore;
    [SerializeField]
    public int PlayerOne;
    [SerializeField]
    public int PlayerTwo;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAvatar = transform.GetChild(0);
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player")
        {
            Vertical1 = Input.GetAxisRaw("Vertical1");
            Horizontal1 = Input.GetAxisRaw("Horizontal1");
            Vector2 MovementInput = new Vector2(Horizontal1, Vertical1);
            if (MovementInput.x != 0)
            {
                playerAvatar.localScale = new Vector2(Mathf.Sign(MovementInput.x), 1);
            }
            if (Input.GetButtonDown("Run"))
            {
                speed = runSpeedValue;
            }
            if (Input.GetButtonUp("Run"))
            {
                speed = speedValue;
            }
            playerAnimation.SetFloat("Speed", MovementInput.magnitude);
        }
        if(score == 6)
        {
            if (PlayerOne == 6)
            {
                Win(1);
            }
            else if (PlayerTwo == 6)
            {
                Win(2);
            }
        }
    }
    private void FixedUpdate()
    {
        if (this.tag == "Player")
        {
            playerRB.velocity = new Vector2(Horizontal1 * speed * Time.deltaTime, Vertical1 * speed * Time.deltaTime);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "score")
        {
            score++;
        }
    }
    public void Win(int player)
    {
        if (player == 1)
        {
            WinText.text = "Wygra³ gracz nr. 1!";
        }
        else if (player == 2)
        {
            WinText.text = "Wygra³ gracz nr. 2!";

        }
    }
}

