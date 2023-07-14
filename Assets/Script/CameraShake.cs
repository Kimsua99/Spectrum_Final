using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // 2021.05.10 created by HY
    // �� Ŭ������ �ٸ� Ŭ�������� ȣ���Ͽ� ���
    public float shakeAmount = 0.1f; // hy : ī�޶� ��鸱 ���� ����
    //public bool isShake; // hy : ��鸲 �۵� �ܺ� Ŭ�������� ���� true����
    private GameObject camera;

    void Start()
    {
        //shakeAmount = 0.1f;
        //isShake = false;
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        /*if (isShake) // hy : ī�޶� ��鸲 �۵�
        {
            //Debug.Log("shake it");
            //Debug.Log(GameObject.FindGameObjectWithTag("MainCamera").transform.position);
            //Debug.Log(Random.insideUnitSphere);
            //Debug.Log(shakeAmount);
            camera.transform.position += Random.insideUnitSphere * shakeAmount;
        }else // hy : ī�޶� ��ġ �ٽ� ����
        {
            //Debug.Log("stop shake it");
            camera.transform.localPosition = new Vector3(0, 1, 0);
        }
        */
        camera.transform.position += Random.insideUnitSphere * shakeAmount;
    }
}
