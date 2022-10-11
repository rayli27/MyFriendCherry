using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumeMoney : MonoBehaviour
{
    public Player player;
    public MoneyProgress progress;
    public int doughMade;
    public bool pickedUp = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !pickedUp)
        {
            pickedUp = true;
            Destroy(gameObject);
            player.money += doughMade;
            FindObjectOfType<AudioManager>().Play("Money");
        }
        progress.SetMoney(player.money);
    }
}
