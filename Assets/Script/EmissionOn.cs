using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionOn : MonoBehaviour
{
    // 2021.05.20 created by HY
    // Needs : Trigger, children who want emission

    private Renderer[] renderers; // hy : emission on ��ų ��ü�� ��� ���� ����

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // hy : Ʈ���Ÿ� ����ϸ� �ڽ� ��ü���� emission on
    {
        if (other.tag == "Player")
        {
            renderers = gameObject.transform.GetComponentsInChildren<Renderer>(); // hy : �ڽ��� renderer�� ��� ����

            foreach (Renderer renderer in renderers)
            {
                renderer.material.EnableKeyword("_EMISSION"); // hy : �ڽĵ��� material�� �ϳ��� �����Ͽ� emission�� on��Ŵ
            }
        }
    }
}
