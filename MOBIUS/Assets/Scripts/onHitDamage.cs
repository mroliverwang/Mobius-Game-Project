using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHitDamage : MonoBehaviour
{
    public GameObject darkseed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            if (collision.gameObject.name.Contains("Weight"))
            {
                darkseed.GetComponent<DarkSeedController>().health -= 25.0f;
                
            }
            darkseed.GetComponent<DarkSeedController>().health -= 15.0f;
        }
    }
}
