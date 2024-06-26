using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public AudioSource audioSource;
    public Animator animator;
    public Player player; 

    // Start is called before the first frame update
    void Start()
    {

        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!player.isDead)
        {
            Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            playerRb.velocity = (movement * speed * Time.deltaTime);

            if (playerRb.velocity.x != 0)
            {
                animator.SetBool("isMoving", true);
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
            else if (playerRb.velocity.y != 0)
            {
                animator.SetBool("isMoving", true);
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
            else
            {
                audioSource.Stop();
                animator.SetBool("isMoving", false);
            }
        }
        else if(player.isDead)
        {
            playerRb.velocity = new Vector2(0, 0);
            audioSource.Stop();
        }
       

       
        





    }
}
