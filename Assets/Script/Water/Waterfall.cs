using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterfall : MonoBehaviour
{
    GameObject waterFall1;
    GameObject waterFall2;
    GameObject waterFall3;
    GameObject waterFall4;
    GameObject waterFall5;

    public AudioSource waterfallSound;//����� �ҽ�



    void Start()
    {
        /*
        waterFall1 = GameObject.Find("WaterFall1");

        waterFall2 = GameObject.Find("WaterFall2");

        waterFall3 = GameObject.Find("WaterFall3");

        waterFall4 = GameObject.Find("WaterFall4");

        waterFall5 = GameObject.Find("WaterFall5");
        */
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("����");
        if (other.tag == "Player") 
        {
            //Debug.Log("�ߵ���");
            //waterFall1.SetActive(true);

            waterfallSound.Play(); // hy : ���� �������� �Ҹ�
            gameObject.transform.GetChild(0).gameObject.SetActive(true); // hy : ������ �ڽĿ��ٰ� �־ �ڽ��� setactive������
            GetComponent<BoxCollider>().enabled = false; // �� ���� ����ǰ� ����
        }
    }
}
