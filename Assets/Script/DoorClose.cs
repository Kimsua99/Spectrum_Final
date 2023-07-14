using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    // 2021.06.19 created by HY
    // Needs : Trigger, DoorOpen Component
    // Field Setting : speed, time
    // Start is called before the first frame update

    public float speed = 3f; // hy : ������ �ӵ� ����
    public float time = 3f; // hy : �� �� ���� �������� ����

    private Transform parentDoor; // hy : ��ǥ�� �� �� ��ü�� Ʈ������ ������ �޾ƿ�
    private DoorOpen doorOpen; // hy : �� ���� �ڵ� ������Ʈ ���� ����
    private Vector3 originPos; // hy : �� ���� ��ġ �޾ƿ� ����
    private Vector3 tmp;
    private float timer = 0f; // hy : Ÿ�̸� 0�ʺ��� time�ʱ��� �۵��� ����
    private int direction; // hy : ���� ���� ����ؼ� ���� ����
    private bool isOperate = false; // hy : ���� �۵��Ұ��� üũ

    void Start()
    {
        parentDoor = gameObject.transform.parent.transform;
        doorOpen = gameObject.transform.parent.GetComponentInChildren<DoorOpen>(); // �θ� �Ʒ��� dooropen �ڵ尡 �� �� ������ ������ 
        this.originPos = doorOpen.originalPos;
        //Debug.Log(originPos);
        tmp = new Vector3(0f, 0f, 0f);
        direction = doorOpen.directionNumber; // hy : �� ������ �� ������ �����̶� �ݴ� �������� �־���� ��

        if(direction % 2 == 1) // hy : ������ (-)�����̸� (+)�������� �ٲ���
        {
            direction = direction - 1;
        }else // hy : ������ (+)�����̸� (-)�������� �ٲ��� -> ���� �Ȱ��� DoorOpen�� directionNumber���� ���� ����
        {
            direction = direction + 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < time && isOperate) // hy : 3�� �̳��� �� �۵���Ŵ
        {
            switch (direction)
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
        else if(isOperate) // hy : �ð� �ʰ��ϸ� �� ���� ��ġ�� �̵�
        {
            isOperate = false;
            parentDoor.position = originPos;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") // hy : �÷��̾ ������ �� �۵� On 
        {
            isOperate = true;
        }
    }
}
