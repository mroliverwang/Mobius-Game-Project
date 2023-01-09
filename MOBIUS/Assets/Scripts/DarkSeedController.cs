using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkSeedController : MonoBehaviour
{
    public float health;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        
        health = 100.0f;
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        health -= 0.5f * Time.deltaTime;
             
    }
}
