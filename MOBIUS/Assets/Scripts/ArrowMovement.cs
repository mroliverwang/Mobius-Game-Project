using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    float speed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (gameObject.name.Contains("Arrow1"))
        {
            transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        else if (gameObject.name.Contains("Arrow2"))
        {
            transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        else if (gameObject.name.Contains("Arrow3"))
        {
            transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        else if (gameObject.name.Contains("Arrow4"))
        {
            transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        else
        {
            transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        

        if(transform.position.x > 15 || transform.position.x < -15 || transform.position.y < -12 || transform.position.y > 12)
        {
            Destroy(gameObject);
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boy")
        {
            Destroy(gameObject);
        }
    }
}
