using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string scene;
    public float timer;
    float time;

    void Start()
    {
        time = timer; 
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            change();
        }
    }

    void change()
    {
        SceneManager.LoadScene(scene); 
    }
}