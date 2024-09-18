using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    
    void Start()
    {
        Vector2 position = new();
        position.y = Camera.main.orthographicSize + 1;

        position.x = Random.Range(-5, 5);

        transform.position = position;
    }

    
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        
        if(transform.position.y > -Camera.main.orthographicSize + 1)
        {
            Destroy(this.gameObject);
        }

    }
}
