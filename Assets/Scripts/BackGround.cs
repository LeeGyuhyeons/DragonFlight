using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    //��ũ���� �Ǵ� ��׶���
    public float scrollSpeed = 1.0f;
    private Material myMaterial;

    void Start()
    {
        //���͸��� ������ ����
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //������ ���͸��󿡼� ��������
        Vector2 newOffset = myMaterial.mainTextureOffset;

        //���Ӱ� offset�� �ٲ��ְڽ��ϴ�.
        //y�κа��� �ӵ��� ������ �����ؼ� �����ݴϴ�.
        newOffset.Set(0,newOffset.y + (scrollSpeed * Time.deltaTime));
        //���͸��� �����¿� ���� �־��ش�.
        myMaterial.mainTextureOffset = newOffset;
    }
}
