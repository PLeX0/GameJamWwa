using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Player player;
    public GameObject resetWindow;
    // Start is called before the first frame update
    void Start()
    {
        resetWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(player.health<=0)
        {
            resetWindow.SetActive(true);
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
