using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //���ǵ�
    public float moveSpeed = 3.0f;


    void Start()
    {
        
    }

    void Update()
    {
        //x�� �� ���� vector ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //x�� �̵� ����
        transform.Translate(distanceX, 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.6f), transform.position.y, transform.position.z);
    }
}
