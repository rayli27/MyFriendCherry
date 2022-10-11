using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringSound : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Spring");
    }
}
