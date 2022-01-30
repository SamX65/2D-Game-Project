using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject Dino;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Dino.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Dino.transform.position + offset;
        /*Vector3 pos = transform.position;
        transform.Translate(0.1f, 0, 0);
        if (pos.x > 22)
        {
            pos.x = -2;
            transform.position = pos;
        }*/
        
    }
}

