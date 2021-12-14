using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
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
    private float Vertical;
    private float Horizontal;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAvatar = transform.GetChild(0);
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vertical = Input.GetAxisRaw("Vertical");
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 MovementInput = new Vector2(Horizontal, Vertical);
        if (MovementInput.x != 0)
        {
            playerAvatar.localScale = new Vector2(Mathf.Sign(MovementInput.x), 1);
        }
        if(Input.GetButtonDown("Run"))
        {
            speed = runSpeedValue;
        }
        if (Input.GetButtonUp("Run"))
        {
            speed = speedValue;
        }
        playerAnimation.SetFloat("Speed", MovementInput.magnitude);
    }
    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(Horizontal * speed, Vertical * speed);
    }
}
