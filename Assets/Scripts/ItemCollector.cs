using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    private int melon = 0;

    [SerializeField] private Text melonText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.gameObject.CompareTag("Melon"))
        {
            Destroy(collision.gameObject);
            melon = melon + 1;
            melonText.text = "melon: " + melon;
                
        }
     
    }

    
}
