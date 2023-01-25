using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToFight : MonoBehaviour
{
    Vector3 click;
    Vector3 opponet;
    float v;
    float increase;
    // Start is called before the first frame update
    void Start()
    {
        increase = 0.00001f;
        v = 0.3f;
        click = new Vector3(v, 0f, 0f);
        opponet = new Vector3(-4.3f * v, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        opponet.x -= increase;
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(click);
        }


        transform.Translate(opponet*Time.deltaTime);

        if(transform.position.x > 7.8f)
        {
            increasing();
        }

        if (transform.position.x < -8f)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void increasing()
    {
        increase += 0.01f;
    }
}
