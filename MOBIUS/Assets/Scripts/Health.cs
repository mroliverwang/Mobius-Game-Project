using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    GameObject offer;
    float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100.0f;
        offer = GameObject.Find("offer");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = health;
        health -= 3.0f * Time.deltaTime;



       
        if(health <= 0)
        {
            offer.GetComponent<ClickToFight>().increasing();
        }

    }
}
