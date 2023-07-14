using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            GameObject.Find("HealthController").GetComponent<HealthController>().TakeDamageAll();
            //Debug.Log("�״� ȭ������ �̾�����");
            SceneManager.LoadScene("GameOver");
        }

    }
}
