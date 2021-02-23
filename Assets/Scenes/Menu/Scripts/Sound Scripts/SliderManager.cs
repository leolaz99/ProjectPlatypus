using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public float master = 1f;
    [SerializeField] Slider masterSlider;

    public float music = 1f;
    [SerializeField] Slider musicSlider;

    public float sfx = 1f;
    [SerializeField] Slider sfxSlider;

    public void ChangeMasterSlider()
    {
        master = masterSlider.value;
        PlayerPrefs.SetFloat("MasterVolume", master);
    }

    public void ChangeMusicSlider()
    {
        music = musicSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", music);
    }

    public void ChangeSfxSlider()
    {
        sfx = sfxSlider.value;
        PlayerPrefs.SetFloat("SfxVolume", sfx);
    }


    private void Awake()
    {
        master = PlayerPrefs.GetFloat("MasterVolume", 1f);
        masterSlider.value = master;

        music = PlayerPrefs.GetFloat("MusicVolume", 1f);
        musicSlider.value = music;

        sfx = PlayerPrefs.GetFloat("SfxVolume", 1f);
        sfxSlider.value = sfx;
    }

    void Update()
    {
        ChangeMasterSlider();
        ChangeMusicSlider();
        ChangeSfxSlider();

        AudioManager.instance.ChangeSfxVolume(PlayerPrefs.GetFloat("SfxVolume"), PlayerPrefs.GetFloat("MasterVolume"));
        AudioManager.instance.ChangeMusicVolume(PlayerPrefs.GetFloat("MusicVolume"), PlayerPrefs.GetFloat("MasterVolume"));
    }
}
