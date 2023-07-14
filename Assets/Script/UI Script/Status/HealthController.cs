using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthController : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;

    public Image[] hearts;

    public Image bloodScreen;
    public AudioSource death;


    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                if (i + 0.5 == currentHealth)
                {
                    hearts[i].sprite = halfHeart;
                }
                else
                {
                    hearts[i].sprite = fullHeart;
                }
            }
            else 
            {
                hearts[i].sprite = emptyHeart;
            }
        }

        if (currentHealth < maxHealth)
        {
            InvokeRepeating("RegenHealth", 7f, 7f); // regenhealth �޼ҵ带 2�� �ڿ� �ڵ����� ��������ִ� �κ�ũ �Լ� ����.
        }
    }
 
    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth -= 0.5f; // ������ ���� �� ���� 0.5 = ��Ʈ �ݰ��� ����
            StartCoroutine(ShowBloodScreen()); //������ ������ ȭ���� �� ���� �� ó�� ���̰� �ڷ�ƾ �Լ� ����. ���߿� ���⿡ ī�޶� ��鸲 �ְ� ������ ���� �����ؾ� �ϴ��� �𸣰���,, ī�޶� ����ũ ��ũ��Ʈ�� �Լ��� ������Ʈ ���̶�.

            if (currentHealth < 0)
            {
                currentHealth = 0; // ��Ʈ �� ���̸� �״� ȭ������ �̾����� ���߿� �����ϱ�!
                Debug.Log("����");
                SceneManager.LoadScene("GameOver");
            }
        }

    }
    public void TakeDamageSecond()
    {
        currentHealth -= 2.0f;
        StartCoroutine(ShowBloodScreen());
 
        if (currentHealth < 0)
        {
            currentHealth = 0; // ��Ʈ �� ���̸� �״� ȭ������ �̾����� ���߿� �����ϱ�!
            SceneManager.LoadScene("GameOver");
        }
    }

    public void TakeDamageAll()
    {
        currentHealth -= 6.0f;
        StartCoroutine(ShowBloodScreen());
        currentHealth = 0;
        SceneManager.LoadScene("GameOver");
    }

    public void TakeDamageThird()
    {
        currentHealth -= 3.0f;
        StartCoroutine(ShowBloodScreen());
        if (currentHealth < 0)
        {
            currentHealth = 0; // ��Ʈ �� ���̸� �״� ȭ������ �̾����� ���߿� �����ϱ�!
            SceneManager.LoadScene("GameOver");
        }
    }

    public void TakeDamageNone()
    {
        currentHealth -= 0.0f;
    }
    public void Heal()
    {
        if (currentHealth > 0)
        {
            currentHealth += 0.5f; // �� �Ҷ����� 0.5 = ��Ʈ �ݰ��� �ö�

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth; 
            }
        }
    }

    public void RegenHealth()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += 0.5f;
            CancelInvoke("RegenHealth"); //�������� �κ�ũ �Լ� ����
        }
    }

    IEnumerator ShowBloodScreen()//��ũ���� �̹����� ������ִ� �Լ��� �ڷ�ƾ���� �����ϱ� ���ؼ� ����.
    {
        bloodScreen.color = new Color(1, 0, 0, Random.Range(0.5F, 0.7F)); //�̹����� ���� ����, ������ 0.2���� 0.3 ������ ���� ���� ���.
        yield return new WaitForSeconds(0.1f); //0.1�ʰ� �̹����� ���� �� �ٽ� �̹����� �����ϰ� ����.
        bloodScreen.color = Color.clear;
    }
}
