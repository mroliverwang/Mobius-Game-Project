using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    float horizontalForce = 25f;
    float jumpForce = 12f;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;
    public GameObject eventManager;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Moving", 0);
        rb.velocity = new Vector2(0.0f, rb.velocity.y);

        if (eventManager.GetComponent<EventManager>().gameStage == 0)
        {
            if (transform.position.x > -8 && Input.GetKey(KeyCode.A))
            {
                rb.AddRelativeForce(Vector3.left * horizontalForce, ForceMode2D.Force);

                spriteRenderer.flipX = false;

                if (transform.position.y < -2)
                {
                    animator.SetInteger("Moving", 1);
                }
            }



            if (transform.position.x < 8 && Input.GetKey(KeyCode.D))
            {
                rb.AddRelativeForce(Vector3.right * horizontalForce, ForceMode2D.Force);

                spriteRenderer.flipX = true;

                if (transform.position.y < -2)
                {
                    animator.SetInteger("Moving", 1);
                }
            }



            if (transform.position.y < -2 && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                animator.SetInteger("Moving", 0);
            }
        }

        /*else
        {
            gameObject.transform.position = new Vector3(0.14f, -2.33f, 0);
        }*/
    }

    

}
