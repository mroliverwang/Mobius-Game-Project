using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventManager : MonoBehaviour
{
    public int gameStage;
    public GameObject darkseed;
    public TextMeshProUGUI text;
    public TextMeshProUGUI instruction;
    float timer = 120.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameStage = 0;
        timer = 120.0f;
        instruction.SetText("Dodge the hurtful words");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStage == 0 || gameStage == 1)
        {
            timer -= Time.deltaTime;
        }
        text.SetText("Time: " + timer.ToString("f1") + "s");

        if(darkseed.GetComponent<DarkSeedController>().health < 55 && gameStage != 1)
        {
            gameStage = 1;
            Destroy(GameObject.Find("Boy"));
            GameObject.Find("CryingBoy").transform.position = new Vector3(0.14f, -2.8f, 0);
            instruction.SetText("Move the teddy bear with your mouse and click the weights to fight back");

            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Damage"))
            {
                if (obj.name.Contains("Arrow"))
                {
                    Destroy(obj);
                }
            }
        }

        if (timer <= 0)
        {
            //win
            gameStage = -1;

            instruction.SetText("You win!");

            //clear
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Damage"))
            {               
                Destroy(obj);              
            }

        }

        if (darkseed.GetComponent<DarkSeedController>().health <=0)
        {
            //reload the scene
        }
    }
}
