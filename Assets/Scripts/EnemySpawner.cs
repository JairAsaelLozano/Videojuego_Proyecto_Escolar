using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timer = 0f;
    public GameObject Enemytype; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2)
        {

            var randomNumber = Random.Range(0, 3);
            var side=0.0f;
            var height = Random.Range(-5.0f, 5.0f);
            if (randomNumber > 1)
            {
                side = 12;
            }
            else
            {
                side = -12;
            }

                Instantiate(Enemytype, new Vector3(side, height, 0), Quaternion.identity);
            timer = 0;
        }

    }
}
