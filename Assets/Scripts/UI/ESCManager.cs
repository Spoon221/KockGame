using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ESCManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Slider volumeSlider;
    private float volume;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Мышка находится на кнопке");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Мышка покинула кнопку");
    }

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