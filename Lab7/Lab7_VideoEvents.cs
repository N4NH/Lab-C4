using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Lab7_VideoEvents : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Nếu bạn muốn hiện UI khi video kết thúc
    public GameObject endPanel;

    // Nếu bạn muốn chuyển scene khi video kết thúc
    public bool loadSceneWhenFinished = false;
    public string nextSceneName = "GameplayScene";

    private void Start()
    {
        if (endPanel != null)
        {
            endPanel.SetActive(false);
        }

        // Đăng ký sự kiện
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        // Bắt đầu chuẩn bị video (quan trọng)
        videoPlayer.Prepare();
    }

    private void OnVideoPrepared(VideoPlayer source)
    {
        // Video đã chuẩn bị xong → phát
        source.Play();
        Debug.Log("Video prepared completed: Started playing.");
    }

    private void OnVideoFinished(VideoPlayer source)
    {
        Debug.Log("Video finished: loopPointReached triggered.");

        if (loadSceneWhenFinished)
        {
            // Chuyển scene
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            // Hiện UI
            if (endPanel != null)
            {
                endPanel.SetActive(true);
            }
        }
    }

    private void OnDestroy()
    {
        // Hủy đăng ký sự kiện để tránh lỗi khi đổi scene hoặc tắt object
        if (videoPlayer != null)
        {
            videoPlayer.prepareCompleted -= OnVideoPrepared;
            videoPlayer.loopPointReached -= OnVideoFinished;
        }
    }

    // Hàm này để bạn gắn vào nút Continue nếu muốn
    public void Continue()
    {
        if (loadSceneWhenFinished)
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            if (endPanel != null)
            {
                endPanel.SetActive(false);
            }
        }
    }
}
