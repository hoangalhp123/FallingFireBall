using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossBarMove : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject obj;
    public float speedMove;
    public float maxX;
    public float minX;
    private float oldPosition;

    void Start()
    {
        obj = gameObject;
        speedMove = 5;
        minX = -1.65f;
        maxX = 0.65f;
        oldPosition = -9;
        obj.transform.position = new Vector3(Random.Range(minX, maxX + 1), obj.transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(0, 1 * Time.deltaTime * speedMove, 0));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("ResetCrossBar"))
        {
            obj.transform.position = new Vector3(Random.Range(minX, maxX + 1), oldPosition, 0);
        }

    }
}
