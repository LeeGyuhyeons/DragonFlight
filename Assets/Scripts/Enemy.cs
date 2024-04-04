using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //움직일 속도
    public float enemySpeed = 3f;

    List<int> list = new List<int>();
    int n;
    void Start()
    {
        list.Add(-1);
        list.Add(1);
        n = Random.Range(0, 2);
    }


    void Update()
    {
        float distanceY = enemySpeed * Time.deltaTime;

        switch (transform.position.x)
        {
            case >= 2.5f:
                Debug.Log("Left");
                n = 0;
                break;
            case <= -2.5f:
                Debug.Log("Right");
                n = 1;
                break;
        }
        transform.Translate(list[n] * distanceY, -distanceY, 0);

        //if (transform.position.x == 2.4)
        //{
        //    transform.Translate(-distanceY, -distanceY, 0);
        //
        //}
        //if (transform.position.x == -2.4)
        //{
        //    transform.Translate(+distanceY, -distanceY, 0);
        //
        //}
        //else
        //{
        //    transform.Translate(-distanceY, -distanceY, 0);
        //
        //}

        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.6f), transform.position.y, transform.position.z);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
