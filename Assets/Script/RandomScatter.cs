using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2021.08.02 created by HY
// NEED : Trigger, TargetTrigger(measure direction) 
// å Ƣ����� �ڵ�, �θ� ��ü�� ����, enabled�� true���ִ� ���� �����

public class RandomScatter : MonoBehaviour
{
    public float waitSecond = 0; // hy : �� �� �Ŀ� Ƣ��� ���� ����
    public float randomForce = 1; // hy : ������� �������� ����
    public float scatterForce = 1; // hy : Ƣ����� ��
    public int randomPercent = 100; // hy : �󸶳� �������� �����ų��
    public Transform targetTrigger; // hy : ���� �Ǵܿ� ���� Ʈ����
    public GameObject triggerEnter; // hy : ontriggerenter �Ǹ� �۵���
    public bool isStart = false; // hy : �ٷ� �����ϴ��� üũ
    
    private Vector3 direction; // hy : ��ѷ��� ����
    private float force; // hy : ���� ��� ���� ��� ��
    private Transform[] children; // hy : �ڽ� ��ü���� transform��

    // Start is called before the first frame update
    void Start()
    {
        children = gameObject.GetComponentsInChildren<Transform>(); // hy : �ڽ� ��ü transform �ϳ��� �޾ƿ�
        
        if (isStart)
        {
            StartCoroutine(Wait());
        }
        else
        {
            enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wait());
        enabled = false;
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitSecond); // hy : waitSecond��ŭ ��ٸ�
        for (int i = 0; i < transform.childCount; i++)
        {
            if (Random.value * 100 > randomPercent) // hy : Ȯ�� ��� randomPercent���� ũ�� ��ѷ����� ����
                continue;

            direction = targetTrigger.position - children[i].position; // hy : Ƣ��� ����
            force = Random.value * randomForce * scatterForce; // hy : Ƣ����� ��
            //children[i].Translate(direction * force, Space.World);
            Rigidbody rigidBody = children[i].gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
            rigidBody.useGravity = true;
            rigidBody.AddForce(direction * force);
            rigidBody.mass = 1; // Set the GO's mass to 2 via the Rigidbody.
        }
    }
}
