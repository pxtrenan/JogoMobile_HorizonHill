using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Animator Anime;
    public Rigidbody2D playerRigidBody;
    public int forceJump;

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

  
	// Use this for initialization
	void Start () {

        
        
	}

    // Update is called once per frame
    public void Update()
    {

        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            playerRigidBody.AddForce(new Vector2(0, forceJump));

            som.PlayOneShot(soundJump);
    
        }
      


        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);

        Anime.SetBool("jump", !grounded);
        
    }

   

}


