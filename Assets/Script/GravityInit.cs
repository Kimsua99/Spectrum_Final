using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem; // Put at top of script to access Dialogue System stuff. ... 


// 2021.07.13 created by HY
// Needs : Trigger 
// �߷� �ʱ�ȭ Ŭ����

public class GravityInit : MonoBehaviour
{
    public int jumpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // hy : ���̾�α� �ý��� ���� ������ �߷� �ʱ�ȭ��Ű�� �޼ҵ�
    private void OnTriggerStay(Collider other) // hy : �÷��̾ �� �ִ� ���� ��� ����ž���(������ true�� �Ǵ� ������ ĳġ�ؾ� �ϹǷ�)
    {
        if (other.tag == "Player")
        {
            if (DialogueLua.GetVariable("isTrue").asBool) // hy : ���� �޽����� �������� �� ������ true�� �����
            {
                PlayerController playerController = GameObject.Find("Player").GetComponent<PlayerController>();
                playerController.jumpForce = jumpForce;// hy : �߷� �ʱ�ȭ ����
            }
        }

    }
}
