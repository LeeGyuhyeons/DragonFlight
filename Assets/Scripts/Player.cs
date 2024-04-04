using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //스피드
    public float moveSpeed = 3.0f;


    void Start()
    {
        
    }

    void Update()
    {
        //x쪽 값 설정 vector 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //x쪽 이동 설정
        transform.Translate(distanceX, 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.6f), transform.position.y, transform.position.z);
    }
}
