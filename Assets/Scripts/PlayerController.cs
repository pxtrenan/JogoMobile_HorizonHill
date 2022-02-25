using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Animator Anime;
    public Rigidbody2D playerRigidBody;
    private int forceJump;

    public bool jump;

    public Transform GroundCheck;
    public bool grounded;
    public LayerMask whatIsGround;

    internal static void Update(string tap)
    {
        throw new NotImplementedException();
    }

    public GameObject colisor;

    public AudioSource som;
    public AudioClip soundJump;

    public static int pontuacao;
    public UnityEngine.UI.Text txtPontos;

    void Awake()
    {
        som.ignoreListenerPause = true;
    }
    // Use this for initialization
 
        public void MusicEffectON()
    {
        

    }

    // Update is called once per frame
    public void Update()
    {
        forceJump = 197;
        if (Input.GetMouseButtonDown(0) && grounded == true)
        {
            playerRigidBody.AddForce(new Vector2(0, forceJump));

            som.PlayOneShot(soundJump);

        }

        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);

        Anime.SetBool("jump", !grounded);

    }
    public void Move (float moveInput)
    {
        
    }
    public void JumpButton()
    {
        forceJump = 195;
        if (grounded == true)
        {
            playerRigidBody.AddForce(new Vector2(0, forceJump));

            som.PlayOneShot(soundJump);
        }
        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);

        Anime.SetBool("jump", !grounded);
    }

    
      

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            LevelManager.levelManager.SetCoins();

                    }

    }
}


