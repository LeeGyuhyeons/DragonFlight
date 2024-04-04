using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    public GameObject k_Bullet;

    void Start()
    {
        //("�Լ��̸�", �ʱ� ���� �ð�, ������ �ð�)
        InvokeRepeating("Shoot", 0, 0.1f);
        InvokeRepeating("K_Shoot", 0, 0.1f);
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            //�̻��� ������, ���� ������, ���� �� ����
            Instantiate(bullet, transform.position, Quaternion.identity);

            //���� �÷���
            SoundManager.instance.PlayerSound();
        }

    }

    void K_Shoot()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 k_shoot = new Vector3(0, transform.position.y, 0);
            //�̻��� ������, ���� ������, ���� �� ����
            Instantiate(k_Bullet, k_shoot, Quaternion.identity);

            //���� �÷���
            SoundManager.instance.PlayerSound();
        }
    }
    void Update()
    {

    }
}
