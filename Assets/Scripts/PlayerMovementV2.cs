using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private BoxCollider2D collider;
    private SpriteRenderer sprite;
    private Animator anim;

    
    private LayerMask jumpableGround;
    private AudioSource jumpSoundEffect;

    private MovementState state = MovementState.idle;
    private MovementState state = MovementState.running;
    private MovementState state = MovementState.jumping;
    private MovementState state = MovementState.falling;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    kayitpozisyon oyuncuVerisi;
    private void Awake() 
    {
        oyuncuVerisi = FindObjectOfType<kayitpozisyon>();//veri cekme saveload islem kismi
        oyuncuVerisi.pozYukleme();
    } 



    private void Update()
    {
        //Debug.Log("Hello");

        hareketInput = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(hareketInput * 7f, rigidbody.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpSoundEffect.Play();
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 14f);
        }

        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (hareketInput > 0f){
            anim.SetBool("running", true);

        }
        else if (hareketInput < 0f){
            anim.SetBool("running", true)
        }
        else{
            anim.SetBool("running", true);
        }
        if(rigidbody.velocity.y > .1f){
            anim.SetBool("jumping", true);
        }
        else if (rigidbody.velocity.y < -.1f){
            anim.SetBool("falling", true);
        }
        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
       return Physics2D.BoxCast(Vector2.down, .1f, jumpableGround);
    }

    

}
