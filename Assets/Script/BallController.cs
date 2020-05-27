using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private GameObject obj;
    private Rigidbody2D rb;
    public float thrust;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        rb = obj.GetComponent<Rigidbody2D>();
        thrust = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("Mouse position: " + Input.mousePosition);
        //    if (Input.mousePosition.x > 50)
        //    {
        //        rb.AddForce(new Vector2(thrust, 0));
        //    }
        //    else
        //    {
        //        rb.AddForce(new Vector2(-thrust, 0));
        //    }
        //}

        if (Input.touchCount > 0)
        {
            Debug.Log("Mouse position: " + Input.mousePosition);
        }
    }
}
