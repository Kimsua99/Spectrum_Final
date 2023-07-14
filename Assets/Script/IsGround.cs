using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hy : It needs 'trigger' beneath the gameObject
// �� Ŭ������ ������Ʈ �Ʒ��� trigger�� �߰��� ����������� -> collider ������ ��, true ��ȯ��
public class IsGround : MonoBehaviour
{
    // hy : ���� ��Ҵ��� �Ǻ� -> ������ true
    public bool isGround = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isGround);
    }
    void OnTriggerEnter(Collider col)
    {
        isGround = true; // hy : ���� ������ true
    }
    void OnTriggerExit(Collider col)
    {
        isGround = false; // hy : ������ �������� false
    }
}
