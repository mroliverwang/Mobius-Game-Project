using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Jump1()
    {
        SceneManager.LoadScene(1);
    }
    public void Jump2()
    {
        SceneManager.LoadScene(2);
    }
    public void Jump3()
    {
        SceneManager.LoadScene(3);
    }
    public void Jump4()
    {
        SceneManager.LoadScene(4);
    }
    public void Jump5()
    {
        SceneManager.LoadScene(0);
    }

}