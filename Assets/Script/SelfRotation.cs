using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float speed = 30.0f;         //ȸ���ӵ�
    private void Update()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
    
}
