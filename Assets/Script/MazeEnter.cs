using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // hy : �÷��̾����� Ȯ�� �����ָ� �� �������ڸ��� ����Ǿ����(�� �׷����� ��..)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().jumpForce = 0;
            //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().runSpeed = 0;
            Debug.Log("����");
        }
    }
}
