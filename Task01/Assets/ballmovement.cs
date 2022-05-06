using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Transform[] target;
    public Transform ball;
    public float speed = 10f;

    int k = 0;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ball.transform.position = Vector2.MoveTowards(transform.position, target[k].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, target[k].position) < 0.1f)
            {
                k++;
                if (k >= target.Length)
                {
                    k = 0;
                }
            }
        }
    }
} 
