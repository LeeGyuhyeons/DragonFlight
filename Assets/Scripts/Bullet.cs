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
        
        //y축 이동
    }

    //화면 밖으로 나가면 안보일경우 호출이 되는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }

    //트리거
    //콜리전
    //enter 1번 들어올 때
    //stay 계속 충돌 범위안에
    //exit 충돌끝날 때 나가질 때 1번
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪혔다.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //적 지우기
            Destroy(collision.gameObject);


            SoundManager.instance.SoundDie();

            GameObject go = Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(go, 1);

            GameManager.instance.AddScore(100);

            //미사일 자신 지우기
            if (!gameObject.CompareTag("S_Attack"))
            {

                Destroy(gameObject);
            }
        }
    }


}
