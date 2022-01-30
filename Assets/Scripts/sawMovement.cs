using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sawMovement : MonoBehaviour
{
    public Vector2 pos1;
    public Vector2 pos2;
    public Vector2 posDiff = new Vector2(6f, 0f);
    float speed = 0.5f;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = transform.position;
        pos2 = pos1 + posDiff;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        transform.Rotate(0, 0, 4f);

    }

    IEnumerator diye()
    {
        yield return new WaitForSeconds(3f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.name.StartsWith("Player"))
        {
            StartCoroutine(diye());

            SceneManager.LoadScene(4);

        }
    }
}