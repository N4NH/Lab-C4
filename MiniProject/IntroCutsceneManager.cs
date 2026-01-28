using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroCutsceneManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource bgmAudio;

    void Start()
    {
        // Bắt đầu phát nhạc nền
        bgmAudio.Play();

        // Khi video kết thúc → tự vào gameplay
        videoPlayer.loopPointReached += OnVideoEnd;

        // Phát video
        videoPlayer.Play();
    }

    // Hàm bấm Skip
    public void SkipIntro()
    {
        bgmAudio.Stop();
        videoPlayer.Stop();

        SceneManager.LoadScene("GameplayScene");
    }

    // Event khi video hết
    void OnVideoEnd(VideoPlayer vp)
    {
        bgmAudio.Stop();
        SceneManager.LoadScene("GameplayScene");
    }
}
