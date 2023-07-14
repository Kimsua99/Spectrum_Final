using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2021.07.31 created by HY
// NEED : Trigger 
// �� �������� �ڵ�, Ʈ���� ����ϸ� ���۵�


public class BlinkBlink : MonoBehaviour
{
    public bool isOperate; // hy : true�� �۵� �ٷ� ����
    private GameObject[] directionals; // hy : ��� Directional Light ���� ����
    public float interval = 0.5f; // hy : �� �ʿ� �� ���� �����̰� �� ����(ex 0.5) 
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        isOperate = false;
        timer = interval;
        directionals = GameObject.FindGameObjectsWithTag("DirectionalLight"); // hy : �𷺼ų� ����Ʈ ���� �������
    }

    // Update is called once per frame
    void Update()
    {
        if (isOperate)
        {
            timer -= Time.deltaTime; 

            if (timer < 0) { // 0���� �۾����� Ÿ�̸� �ʱ�ȭ, �� 0�� 1 �ٲٱ�
                timer = interval; // hy : Ÿ�̸� �ʱ�ȭ
                foreach (GameObject light in directionals) // hy : ��� directional light���� ���� ������
                {
                    light.GetComponent<Light>().intensity = 1 - light.GetComponent<Light>().intensity; // hy : ���� 0�̸� 1, 1�̸� 0��
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isOperate = true; // hy : �÷��̾ Ʈ���ſ� ���� �۵� ������
        }
    }
}
