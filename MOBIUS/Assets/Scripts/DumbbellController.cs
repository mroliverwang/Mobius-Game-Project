using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbbellController : MonoBehaviour
{
    float speed = 0.3f;

    public GameObject selectedObject;
    public GameObject eventManager;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.26f;
        eventManager = GameObject.Find("EventManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (eventManager.GetComponent<EventManager>().gameStage == 1)
        {
            transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(0, -speed, 0) * Time.deltaTime);

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
            if (hitData && Input.GetMouseButtonDown(0))
            {
                selectedObject = hitData.transform.gameObject;

                if (selectedObject.tag == "Damage")
                {
                    selectedObject.transform.Translate(Quaternion.Euler(0, 0, transform.rotation.z) * new Vector3(0, 35.0f * speed, 0) * Time.deltaTime);

                }
            }
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
