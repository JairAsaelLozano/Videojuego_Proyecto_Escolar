using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    bool side;

    void Start()
    {
        if ((Mathf.Sign(transform.position.x)) == 1)
        {
            side = true;
        }
        else
        {
            side = false;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (side)
        {
            if (transform.position.x <= -12)
            {
                Destroy(gameObject);
            }
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            if (transform.position.x >= 12)
            {
                Destroy(gameObject);
            }
            transform.position = new Vector3(transform.position.x+speed*Time.deltaTime, transform.position.y, transform.position.z);

        }

      
    }
}
