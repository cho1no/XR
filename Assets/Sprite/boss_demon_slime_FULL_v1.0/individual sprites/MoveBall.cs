using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public int dir = 1;
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
        Invoke("DestroyFX", 3f);
    }
    void Update()
    {
        transform.Translate(new Vector2(-5 * dir * Time.deltaTime, 0));
    }

    void DestroyFX()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) { ani.SetTrigger("doBoom"); }
    }
}
