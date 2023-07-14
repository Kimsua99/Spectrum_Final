using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // hy : �̹��� ��뿡 �ʿ�

// hy : This class must be applied to 'trigger'
// : �� Ŭ������ Ʈ���� ��� �� �̹����� ���İ��� 0���� ����� �ִ� �Լ��̴�. (����������)

public class FadeIn : MonoBehaviour
{
    public float start = 1.0f; // hy : ó�� �� �Է� 1�� ����
    public float target = 0.0f; // hy : ��ǥ ���� �� (0 : ����, 1 : ������)
    public Image img; // hy : ���������� �� �̹��� ����

    private Color colorT; // hy : ���� ���� ����
    private bool isDarkOff; // hy : ��ο� ���� ��ư false �⺻

    // Start is called before the first frame update
    void Start()
    {
        colorT = img.color;
        colorT.a = start; // hy : �̹����� �̹� ������ ����
        isDarkOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDarkOff && colorT.a > target) // hy : ��ο� ��ư Off�̰� ������ ����ŭ ���������� 
        {
            colorT.a -= Time.deltaTime; // hy : ������ ���� ���� ����
            img.color = colorT;
        }else if (isDarkOff && colorT.a < target) // hy : ��ǥ ���� �����ϸ� �� update�� �۵� ����
        {
            img.canvas.gameObject.SetActive(false);
            enabled = false;
        }
     
    }

    private void OnTriggerEnter(Collider other) // hy : Ʈ���Ÿ� �ϳ� ����ϸ� ���������� ��ư on
    {
        isDarkOff = true;
    }

}