using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cheeries = 0;

    [SerializeField] public Text cheeriesText;

    [SerializeField] private AudioSource collectionSoundEffect;

    void Update()
    {
        cheeriesText.text = "Score: " + cheeries;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("cheeries"))
        {

            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cheeries += 10;
            cheeriesText.text = "Cherries: " + cheeries;
            
        }
    }
}