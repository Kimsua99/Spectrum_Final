using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    // 2021.07.07 created by HY
    // Needs : Trigger, Target Position(Create Trigger)
    public GameObject targetPos; // hy : ��Ż�� ���� �̵���ų ��ġ ����(Ʈ���Ÿ� ����°� ������ ��ǥ����)
    public AudioSource teleport;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            teleport.Play();
            other.transform.position = targetPos.transform.position; // hy : �÷��̾ ��Ż�� ������ ��ġ �̵���Ŵ
            other.transform.rotation = targetPos.transform.rotation;
        }
    }
}
