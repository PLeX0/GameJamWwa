using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public Image[] slot = new Image[5];
    public GameObject[] slotGameObj = new GameObject[5];
    public bool[] isEmpty = new bool[5];
    public int[] itemId = new int[5];
    public GameObject[] cDownText = new GameObject[5];
    public bool[] isActivecDownText = new bool[5];
    public bool[] isMusicBoxOnSlot = new bool[5];
    public GameObject flashLight;
    [SerializeField] private float flashLightTime = 5f;
    public float flashLightCdown = 5f;
    public bool isFlashLight;
    public bool isMusicBox;
    public Player player;
    public float scrollCounter;
    public float scrollResetTimer = 1f;
    public bool isOverheated;
    public bool musicBoxIsUsed;

    // Start is called before the first frame update
    void Start()
    {
        slotGameObj[0].SetActive(false);
        slotGameObj[1].SetActive(false);
        slotGameObj[2].SetActive(false);
        slotGameObj[3].SetActive(false);
        slotGameObj[4].SetActive(false);



        flashLightCdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlashLight)
        {

            flashLightTime -= Time.deltaTime;
            if (flashLightTime <= 0)
            {
                flashLightTime = 5f;
                isFlashLight = false;
                flashLight.SetActive(false);
                flashLightCdown = 5f;
            }
        }

        if(isMusicBox)
        {
            if((Input.GetAxis("Mouse ScrollWheel") > 0f || Input.GetAxis("Mouse ScrollWheel") < 0f) && !isOverheated && !musicBoxIsUsed)
            {
                scrollResetTimer = 1f;
                Debug.Log("aaaaaaaa");
                scrollCounter++;
                if(scrollCounter > 600)
                {
                    isOverheated = true;
                }
            }
            else if(Input.GetAxis("Mouse ScrollWheel") == 0f && !isOverheated && !musicBoxIsUsed)
            {
                scrollResetTimer -= Time.deltaTime;
                if(scrollResetTimer<=0)
                {
                    scrollCounter = 0;
                    scrollResetTimer = 1f;
                }
            }
        }
        if (isOverheated)
        {
            scrollCounter -= 0.2f;
            if (scrollCounter <= 0)
            {
                isOverheated = false;
            }
        }
        if(musicBoxIsUsed)
        {
            flashLight.SetActive(true);
            isFlashLight = true;
            scrollCounter -= 0.2f;
            if(scrollCounter <= 0)
            {
                musicBoxIsUsed = false;
                isFlashLight = false;
                flashLight.SetActive(false);
            }
        }

        if (flashLightCdown > 0 && flashLightCdown <= 5f)
        {
            flashLightCdown -= Time.deltaTime;
        }

        for(int i = 0; i < slot.Length; i++)
        {
            if(isActivecDownText[i])
            {
                int flashLightcDownInt = (int)flashLightCdown;
                cDownText[i].GetComponent<TMP_Text>().text = flashLightcDownInt.ToString();
                if (flashLightCdown <= 0)
                    cDownText[i].GetComponent<TMP_Text>().text = " ";
            }
            if(isMusicBoxOnSlot[i])
            {
                int scrollCounterInt = (int)scrollCounter;
                cDownText[i].GetComponent<TMP_Text>().text = ((scrollCounterInt / 6).ToString() + "%");
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            UseItem(itemId[0]);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            UseItem(itemId[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UseItem(itemId[2]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            UseItem(itemId[3]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            UseItem(itemId[4]);
        }
    }

    public void AddItem(int id, Sprite sprite)
    {
        for(int i = 0; i<slot.Length; i++)
        {
            if(isEmpty[i]==true)
            {
                slot[i].sprite = sprite;
                isEmpty[i] = false;
                itemId[i] = id;
                if(i!=0)
                this.gameObject.transform.position += new Vector3(-50f, 0, 0);
                if(id==1)
                {
                    cDownText[i].SetActive(true);
                    isActivecDownText[i] = true;
                }
                else if(id==2)
                {
                    isMusicBox = true;
                    isMusicBoxOnSlot[i] = true;
                    cDownText[i].GetComponent<TMP_Text>().fontSize = 39f;
                }
                slotGameObj[i].SetActive(true);
                break;
            }
        }
    }

    public void UseItem(int id)
    {
        if(id==1 && flashLightCdown<=0)
        {
            flashLight.SetActive(true);
            isFlashLight = true;
            
        }
        else if(id==2 && !isOverheated)
        {
            Debug.Log(id);
            musicBoxIsUsed = true;
        }
        else if (id == 3)
        {
            Debug.Log(id);
        }
        else if (id == 4)
        {
            Debug.Log(id);
        }
        else if (id == 5)
        {
            Debug.Log(id);
        }
    }
}
