using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private int soundId;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.audioSource[player.soundIdMemory].Stop();
        player.soundIdMemory = soundId;
        player.soundId = soundId;
        player.audioSource[soundId].loop = true;
        player.audioSource[soundId].Play();
        Debug.Log("asdadawdawdawdada");
    }
}