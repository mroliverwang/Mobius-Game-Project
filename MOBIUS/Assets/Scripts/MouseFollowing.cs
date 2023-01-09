using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowing : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject eventManager;


    // Start is called before the first frame update
    void Start()
    {
        eventManager = GameObject.Find("EventManager");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(eventManager.GetComponent<EventManager>().gameStage == 1)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            transform.position = Camera.main.ScreenToWorldPoint(mousePos);

            if(transform.position.x > 8.5)
            {
                transform.position = new Vector3(8.5f, transform.position.y, transform.position.z);
            }
            if (transform.position.x < -8.3)
            {
                transform.position = new Vector3(-8.3f, transform.position.y, transform.position.z);
            }
            if (transform.position.y > 4.7)
            {
                transform.position = new Vector3(transform.position.x, 4.7f, transform.position.z);
            }
            if (transform.position.y < -4.4)
            {
                transform.position = new Vector3(transform.position.x, -4.4f, transform.position.z);
            }


            float horizontal = Input.GetAxis("Mouse X");
            if(horizontal > 0)
            {
                spriteRenderer.flipX = false;
            }
            if (horizontal < 0)
            {
                spriteRenderer.flipX = true;
            }

        }
    }
}
