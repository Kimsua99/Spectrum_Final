using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2021.07.23 created by HY
// Needs : Trigger , sizeRatio(Default : 1.0)
// �÷��̾� ������ ���� Ŭ����

public class PlayerSize : MonoBehaviour
{
    public float sizeRatio = 1.0f; // hy : �ν����Ϳ��� ���ϴ� ������ ����
    Vector3 size; // hy : transform�� ���� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        size = new Vector3(sizeRatio, sizeRatio, sizeRatio); // hy : transform�� ���� ���� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.localScale = size; // hy : ������ ���� �ڵ� ����
        }
    }
}
