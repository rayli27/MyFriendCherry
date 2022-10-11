using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private GameMaster gm;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = gm.lastCheckPointPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
