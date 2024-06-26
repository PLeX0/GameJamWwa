using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerGameObject;
    public float enemySpeed;
    public float timer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerGameObject.transform.position, enemySpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerGameObject.TryGetComponent<Player>(out Player player)&&collision.gameObject.tag == "Player")
        {
            player.inDarkness = true;
        }
        if(collision.gameObject.tag == "Lake")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (playerGameObject.TryGetComponent<Player>(out Player player))
        {
            player.inDarkness = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (playerGameObject.TryGetComponent<Player>(out Player player))
        {
            player.inDarkness = false;
        }
    }
}
