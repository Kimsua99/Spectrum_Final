using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // 2021.05.10 created by HY
    // Needs : Trigger, Child(Target)
    // Field Setting : Local Direction Number(x, -x, y, -y, z, -z => 0 ~ 5), speed, time
    public int directionNumber=0;
    public float speed = 3f; // hy : ������ �ӵ� ����
    public float time = 3f; // hy(06_19) : �� �� ���� �������� ����
    public Vector3 originalPos; // hy(06_19) : ���� ���� ��ġ �����ؼ� DoorClose���� �� ����

    private Transform parentDoor; // hy(06_19) : ��ǥ�� �� �� ��ü�� Ʈ������ ������ �޾ƿ�
    private Vector3 tmp;
    private float timer = 0f; // hy : Ÿ�̸� 0�ʺ��� time�ʱ��� �۵��� ����
    public bool isOperate; // hy : ���� �۵��Ұ��� üũ

    void Start()
    {
        parentDoor = gameObject.transform.parent.transform;
        originalPos = parentDoor.position; // hy(06_19) : ���� ���� ��ġ ����, �� �ڵ忡�� �Ⱦ��̰� DoorClose.cs���� ����
        //Debug.Log(gameObject.transform.parent+"\n"+originalPos);// hy(06_19) : �� �� ���� inspector�� �־�� DoorClose ���� �۵���
        tmp = new Vector3(0f, 0f, 0f);
        isOperate = false; // hy : ���� ���۵�
    }

    
    void Update()
    {
        //Debug.Log(timer);
        if (timer < time && isOperate) // hy : 3�� �̳��� �� �۵���Ŵ
        {
            switch (directionNumber)
            {
                case 0:
                    tmp.x = Time.deltaTime; // hy : tmp�� x������ �̵���Ű�� ���� ��
                    break;
                case 1:
                    tmp.x = -Time.deltaTime; // hy : tmp�� -x������ �̵���Ű�� ���� ��
                    break;
                case 2:
                    tmp.y = Time.deltaTime; // hy : tmp�� y������ �̵���Ű�� ���� ��
                    break;
                case 3:
                    tmp.y = -Time.deltaTime; // hy : tmp�� -y������ �̵���Ű�� ���� ��
                    break;
                case 4:
                    tmp.z = Time.deltaTime; // hy : tmp�� z������ �̵���Ű�� ���� ��
                    break;
                case 5:
                    tmp.z = -Time.deltaTime; // hy : tmp�� -z������ �̵���Ű�� ���� ��
                    break;
            }
            timer += Time.deltaTime;
            parentDoor.localPosition += tmp * speed; // hy : ���÷� �̵���Ű�� �ڵ�
        }
        else if(isOperate) // hy(06_19) : �ð� �ʰ��ϸ� �״�� ����(������ �ͱ���-> ������ �ڵ�� DoorClose.cs)
        {
            //shake.enabled = false; // hy : ī�޶� ��鸮�� �ڵ� ����
            isOperate = false;
        }
    }
   
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player") // hy : �÷��̾ ������ �� �۵� On 
        {
            isOperate = true;
        }
    }
}
