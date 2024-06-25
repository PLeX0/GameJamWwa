using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{
    public Player player;
    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.inDarkness && !player.isFlashLight)
        {
            timer -= Time.deltaTime;
            if(timer<=0)
            {
                player.health--;
                timer = 5f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!player.isFlashLight)
            player.inDarkness = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.inDarkness = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!player.isFlashLight)
        player.inDarkness = true;
    }
}
