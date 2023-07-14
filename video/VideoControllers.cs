using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video; // video player �ҷ��� �� �ʿ�

// 2021.08.30 created by HY
// NEED : video(Rander Texture), video clip(video player)
// ���� �����ϴ� ��ũ��Ʈ

public class VideoControllers : MonoBehaviour
{

    //public GameObject myVideo; // render texture
    public VideoPlayer videoClip; // video player
    public string nextSceneName; // hy : ���� �� �̸� �Է��ϱ�

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        // hy : video�� ���� ���� ���� ���� ������ �Ѿ��.
        if(videoClip.time > 63.6f)
        {
            //Debug.Log("���� ������ �Ѿ��");
            videoClip.Pause();
            SceneManager.LoadScene(nextSceneName);
        }
    }

    public void OnPlayVideo() // Play : ������ ����մϴ�.
    {
        //myVideo.SetActive(true);
        videoClip.Play();
    }

    public void OnPauseVideo() // Pause : ������ �����մϴ�.
    {
        //myVideo.SetActive(false);
        videoClip.Pause();
    }

    public void OnResetVideo()
    {
        videoClip.time = 0f; // time : ������ ��������� ���� �����մϴ�.
        videoClip.playbackSpeed = 1f;
    }

    public void OnFastVideo(float speed) // playbackspeed : ������ ��� �ӵ��� �����մϴ�.
    {
        videoClip.playbackSpeed = speed;
    }

    //hy : ���� Ŭ�� Skip ��ư
    public void SkipVideo()
    {
        videoClip.time = 58.55f; // hy : ���� Ŭ�� ��� ������ ���� ������ �����.
        videoClip.playbackSpeed = 1f;
        //Debug.Log("��ŵ �Լ� ����");
        
    }

}
