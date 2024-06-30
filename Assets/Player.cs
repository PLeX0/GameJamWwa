using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 5;
    public bool inDarkness = false;
    public Inventory inventory;
    public bool isFlashLight;
    public Sprite[] bloodSprite = new Sprite[5];
    public Image bloodImage;
    public bool isDead;
    public int soundId;
    public int soundIdMemory;
    public AudioSource[] audioSource = new AudioSource[5];
   // [SerializeField]private Animator deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;   
    }

    // Update is called once per frame
    void Update()
    {
        isFlashLight = inventory.isFlashLight;

        if(health == 4)
        {
            bloodImage.sprite = bloodSprite[0];
        }
        else if(health == 3)
        {
            bloodImage.sprite = bloodSprite[1];
        }
        else if (health == 2)
        {
            bloodImage.sprite = bloodSprite[2];
        }
        else if (health == 1)
        {
            bloodImage.sprite = bloodSprite[3];
        }
        else if (health <= 0)
        {
            bloodImage.sprite = bloodSprite[4];
            isDead = true;
            //deathScreen.SetBool("isDead", true);
        }
        else if(health == 5)
        {
            bloodImage.sprite = bloodSprite[0];

        }


        //if(deathScreen.GetBool("isDead")==true)
        //{
        //    Debug.Log("zgon");
           

        //}
    }
}
