using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceController : MonoBehaviour
{

    public GameObject[] arrowPrefab;

    float spawnCoolDown;

    int spawnIndex;
    int temp;

    // Start is called before the first frame update
    void Start()
    {
        spawnCoolDown = 2.0f;
        spawnIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<EventManager>().gameStage == 0)
        {
            spawnCoolDown -= 1.0f * Time.deltaTime;
            if (spawnCoolDown <= 0)
            {
                spawnCoolDown = 5.0f;
                temp = Random.Range(0, arrowPrefab.Length);
                if (spawnIndex != temp)
                {
                    spawnIndex = temp;
                }
                else
                {
                    if (temp < arrowPrefab.Length - 1)
                    {
                        spawnIndex = temp + 1;
                    }
                    else
                    {
                        spawnIndex = temp - 1;
                    }
                }
                Instantiate(arrowPrefab[spawnIndex], arrowPrefab[spawnIndex].transform.position, arrowPrefab[spawnIndex].transform.rotation);
            }
        }
    }
}
