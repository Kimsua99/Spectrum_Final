using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLightControl : MonoBehaviour
{
    // 2021.05.17 created by HY
    // Needs : Trigger
    // Field Setting : Directional Light bright(intensity) target value(0~1)

    public float targetIntensity = 0.5f; // hy : ��ǥ �� (0 : ��ο�, 1 : ����)
    
    //private bool isExecute; // hy : �� ���� ���� ��ư false �⺻
    private GameObject[] directionals; // hy : ��� directional light ���� ����

    void Start()
    {
        //isExecute = false;
    }

    void Update()
    {
        /*if (isExecute)
        {
            foreach(GameObject light in directionals) // hy : ��� directional light���� ���� ������
            {
                light.GetComponent<Light>().intensity = targetIntensity;
            }
        }*/
    }

    private void OnTriggerEnter(Collider other) // hy : Ʈ���Ÿ� �ϳ� ����ϸ� �� ���� ��ư on
    {
        //isExecute = true;
        if (other.tag == "Player")
        {
            directionals = GameObject.FindGameObjectsWithTag("DirectionalLight"); // hy : �𷺼ų� ����Ʈ ���� �������

            foreach (GameObject light in directionals) // hy : ��� directional light���� ���� ������
            {
                light.GetComponent<Light>().intensity = targetIntensity;
            }

        }
    }
}
