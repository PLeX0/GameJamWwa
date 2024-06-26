using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject spanishStart;
    public GameObject spanishQuit;
    public GameObject englishStart;
    public GameObject englishQuit;
    public GameObject english;
    public GameObject spanish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void English()
    {
        englishStart.SetActive(true);
        englishQuit.SetActive(true);
        spanishStart.SetActive(false);
        spanishQuit.SetActive(false);
        english.SetActive(false);
        spanish.SetActive(false);
    }
    public void Spanish()
    {
        englishStart.SetActive(false);
        englishQuit.SetActive(false);
        spanishStart.SetActive(true);
        spanishQuit.SetActive(true);
        english.SetActive(false);
        spanish.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
