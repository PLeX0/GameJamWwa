using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Image[] slot = new Image[5];
    public GameObject[] slotGameObj = new GameObject[5];
    public bool[] isEmpty = new bool[5];
    public int[] itemId = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        slotGameObj[0].SetActive(false);
        slotGameObj[1].SetActive(false);
        slotGameObj[2].SetActive(false);
        slotGameObj[3].SetActive(false);
        slotGameObj[4].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
                slotGameObj[i].SetActive(true);
                break;
            }
        }
    }

    public void UseItem(int id)
    {
        if(id==1)
        {
            Debug.Log(id);
        }
        else if(id==2)
        {
            Debug.Log(id);
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
