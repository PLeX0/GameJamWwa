using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColector : MonoBehaviour
{
    public Inventory inventory;
    public int itemId;
    public Sprite itemSprite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inventory.AddItem(itemId, itemSprite);
        Destroy(this.gameObject);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
