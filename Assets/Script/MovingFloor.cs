using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{
    Vector3 pos; //������ġ
    public float delta; // ��(��)�� �̵������� (x)�ִ밪
    public float speed; // �̵��ӵ�

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        GameObject Player = GameObject.Find("Player");

        if (gameObject.name == "upDownPlate")
        {
            UpDownMove();
        }

        else if (gameObject.name == "BluePlate1")
        {
            LeftRightMove();
        }
        else if (gameObject.name == "BluePlate2")
        {
            UpDownMove();
        }

        else if (gameObject.name == "BluePlate3")
        {
            LeftRightMove();
        }

        else if (gameObject.name == "BluePlate4")
        {
            UpDownMove();
        }

        else if (gameObject.name == "BluePlate5")
        {
            LeftRightMove();
        }

        else if (gameObject.name == "BluePlate6")
        {
            ZLeftRightMove();
        }

        else if (gameObject.name == "BluePlate7")
        {
            UpDownMove();
        }

        else if (gameObject.name == "BluePlate8")
        {
            ZLeftRightMove();
        }

        else if (gameObject.name == "BluePlate9")
        {
            UpDownMove();
        }

        else if (gameObject.name == "BluePlate10")
        {
            UpDownMove();
        }

        else if (gameObject.name == "BluePlate11")
        {
            ZLeftRightMove();
        }

        if (Player.GetComponent<PlayerController>().isJump)
        {
            Debug.Log("�ڽ� ����");
            Player.transform.parent = null;// �÷��̾ ������ �ٸ� ���ǰ� �÷��̾��� �θ��ڽ� ���谡 Ǯ���� �÷��̾� ���� �̵��� �����ϰ� ��. 
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject Player = GameObject.Find("Player");
        Player.transform.SetParent(this.transform); // �¿� ������ ��� ���� �ڽ� �ݶ��̴��� �־ �ݶ��̴� ���͸� ������ �÷��̾��� �θ�� �ö� ������ �� �÷��̾ ���� �����̰� ��. 
    }

    public void UpDownMove()// ���Ʒ� ������ �ݶ��̴� ���� ���� ���� �ʰ� �ν����Ϳ� ���� �־��ָ� ��.
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

    public void LeftRightMove()// �¿� ������ ���� �ڽ� �ݶ��̴�(�� �۰�) �־��ְ� �ν����Ϳ� �� �־��ָ� ��.
    {
        Vector3 v = pos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

    public void ZLeftRightMove()// �¿� ������ ���� �ڽ� �ݶ��̴�(�� �۰�) �־��ְ� �ν����Ϳ� �� �־��ָ� ��.
    {
        Vector3 v = pos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

}
