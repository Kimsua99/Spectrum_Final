using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffChildrenLight : MonoBehaviour
{
    // 2021.05.17 created by HY
    // Needs : Trigger

    private Light[] lights; // hy : ������ ���� ��, ���� ����Ʈ ����Ʈ ��� ���⿡ ����
    private Renderer[] renderers; // hy : emission off ��ų ��ü�� ��� ���� ����

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            lights = gameObject.transform.GetComponentsInChildren<Light>(); // hy : �ڽ��� Light ������Ʈ���� ��� ����
            renderers = gameObject.transform.GetComponentsInChildren<Renderer>(); // hy : �ڽ��� renderer�� ��� ����

            foreach (Light light in lights)
            {
                light.enabled = false;
            }
            foreach (Renderer renderer in renderers)
            {
                renderer.material.DisableKeyword("_EMISSION"); // hy : �ڽĵ��� material�� �ϳ��� �����Ͽ� emission�� off��Ŵ
                renderer.material.shader = Shader.Find("Standard"); // hy : ���̴��� �ٲ����(����������)

                renderer.material.color = new Color(0f, 0f, 0f, 0.5f); // hy : �ٲ� ���̴��� ���� ������ ��
            }
        }
    }
}
