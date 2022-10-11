using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialNote : MonoBehaviour
{

    public static bool noteUp = false;
    public GameObject noteUI;
    private GameMaster gm;


    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (noteUp == false)
            {
                Open();
            }
        }
    }

    void Open()
    {
        noteUI.SetActive(true);
        Time.timeScale = 0f;
        noteUp = true;
        FindObjectOfType<AudioManager>().Play("Note");
    }

    public void Close()
    {
        noteUI.SetActive(false);
        Time.timeScale = 1f;
        noteUp = false;
        FindObjectOfType<AudioManager>().Play("Note");
    }
}
