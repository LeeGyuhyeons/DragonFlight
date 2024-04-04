using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public Text startText;

    int score = 0;

    private void Awake()
    {
        if(instance == null) //nullüũ
            instance = this; //�ڱ��ڽ� �ν��Ͻ��ؼ� ����
    }

    public void AddScore(int num)//������ �߰����ִ� �Լ�
    {
        score += num;
        scoreText.text = "Score : " + score;
    }

    void Start()
    {
        StartCoroutine("StartGame");
    }

    IEnumerator StartGame()
    {
        int i = 3;

        while (i > 0) 
        {
            startText.text = i.ToString();
            yield return new WaitForSeconds(1);

            i--;

            if(i == 0)
            {
                startText.gameObject.SetActive(false);
            }
        }
    }

}
