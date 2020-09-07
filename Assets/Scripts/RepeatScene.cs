using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatScene : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontaTam;
    // Start is called before the first frame update
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();

    }
    void Start()
    {
        groundHorizontaTam = groundCollider.size.x  ;
    }

    private void RepositionBackround()
    {
        transform.Translate(Vector2.right * groundHorizontaTam * 2);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontaTam)
        {
            RepositionBackround();
        }
    }
}
