using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // hy : �̹��� ��뿡 �ʿ�

// hy : This class must be applied to 'trigger'
// : �� Ŭ������ Ʈ���� ��� �� ���� ��ο����� �Լ��̴�.
public class FadeOut : MonoBehaviour
{
    // 2021.05.xx created by HY
    // Needs : Trigger
    // Field Setting : Directional Light bright(intensity) target value(0~1)

    
    public float startDark = 0;
    public float targetDark = 1; // hy : ��ǥ ��� �� (0 : ����, 1 : ��ο�)
    public Image img; // hy : ��ο����� �� �̹��� ����

    private Color colorT; // hy : ���� ���� ����
    private bool isDarkOn; // hy : ��ο����� ���� ��ư false �⺻
    

    //public float targetIntensity = 0.5f; // hy : ��ǥ �� (0 : ��ο�, 1 : ����)

    void Start()
    {
        colorT = img.color;
        colorT.a = startDark; // hy : ���İ��� ������ �� ���� ����, �ȱ׷��� ����ġ ���� ���� �߻�

        //Debug.Log(img.color.a);
        //colorT.a = 0 ; // hy : �̹����� ������ 0���� �������
        isDarkOn = false;
    }

    void Update()
    {
        if(isDarkOn && colorT.a < targetDark) // hy : ��ο� ��ư On�̰� ������ ��ο���� ��ο����� 
        {
            //Debug.Log(colorT.a);
            //Debug.Log(img.color.a);
            colorT.a += Time.deltaTime; // hy : ������ ���� ���� ����
            img.color = colorT;
        }else if (isDarkOn && colorT.a > targetDark) // hy : ��ǥ ���� �����ϸ� �� update�� �۵� ����
        {
            enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other) // hy : Ʈ���Ÿ� �ϳ� ����ϸ� ��ο����� ��ư on
    {
        img.enabled = true;
        isDarkOn = true;
    }

}
