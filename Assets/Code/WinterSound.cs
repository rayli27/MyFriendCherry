using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterSound : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Winter");
    }
}
