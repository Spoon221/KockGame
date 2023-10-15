using UnityEngine;
using UnityEngine.UI;

public class ESCManager : MonoBehaviour
{
    public Slider volumeSlider;
    private float volume;

    void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            volume = PlayerPrefs.GetFloat("Volume", 1f);
            ApplyVolume();
            volumeSlider.value = volume;
            volumeSlider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    private void ChangeVolume(float newVolume)
    {
        volume = newVolume;
        ApplyVolume();
        PlayerPrefs.SetFloat("Volume", volume);
    }

    private void ApplyVolume()
    {
        AudioListener.volume = volume;
    }
}