using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    public GameObject k_Bullet;

    void Start()
    {
        //("함수이름", 초기 지연 시간, 지연할 시간)
        InvokeRepeating("Shoot", 0, 0.1f);
        InvokeRepeating("K_Shoot", 0, 0.1f);
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            //미사일 프리팹, 런쳐 포지션, 방향 값 없음
            Instantiate(bullet, transform.position, Quaternion.identity);

            //사운드 플레이
            SoundManager.instance.PlayerSound();
        }

    }

    void K_Shoot()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 k_shoot = new Vector3(0, transform.position.y, 0);
            //미사일 프리팹, 런쳐 포지션, 방향 값 없음
            Instantiate(k_Bullet, k_shoot, Quaternion.identity);

            //사운드 플레이
            SoundManager.instance.PlayerSound();
        }
    }
    void Update()
    {

    }
}
