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
        if(instance == null) //null체크
            instance = this; //자기자신 인스턴스해서 저장
    }

    public void AddScore(int num)//점수를 추가해주는 함수
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
