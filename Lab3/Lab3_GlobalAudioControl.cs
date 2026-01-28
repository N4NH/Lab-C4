using UnityEngine;

public class Lab3_GlobalAudioControl : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    private float normalVolume = 1f;

    void Start()
    {
        // Đặt âm lượng ban đầu (phòng trường hợp trước đó bạn chỉnh)
        AudioListener.volume = normalVolume;
        AudioListener.pause = false;
    }

    void Update()
    {
        // Nhấn M để Mute / Unmute
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;

            if (isMuted)
            {
                AudioListener.volume = 0f;
            }
            else
            {
                AudioListener.volume = normalVolume;
            }
        }

        // Nhấn P để Pause / Resume toàn bộ audio
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                AudioListener.pause = true;
            }
            else
            {
                AudioListener.pause = false;
            }
        }
    }
}
