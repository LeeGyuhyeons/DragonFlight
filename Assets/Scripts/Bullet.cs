using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 3f;
    public GameObject explosion;


    void Start()
    {

    }

    void Update()
    {
        
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
        
        //y�� �̵�
    }

    //ȭ�� ������ ������ �Ⱥ��ϰ�� ȣ���� �Ǵ� �Լ�
    private void OnBecameInvisible()
    {
        //�̻��� �����
        Destroy(gameObject);
    }

    //Ʈ����
    //�ݸ���
    //enter 1�� ���� ��
    //stay ��� �浹 �����ȿ�
    //exit �浹���� �� ������ �� 1��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� ���� �ε�����.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //�� �����
            Destroy(collision.gameObject);


            SoundManager.instance.SoundDie();

            GameObject go = Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(go, 1);

            GameManager.instance.AddScore(100);

            //�̻��� �ڽ� �����
            if (!gameObject.CompareTag("S_Attack"))
            {

                Destroy(gameObject);
            }
        }
    }


}
