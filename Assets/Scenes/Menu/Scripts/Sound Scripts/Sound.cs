using UnityEngine;

public enum Type
{
    SFX,
    Music
}

[System.Serializable]
public class Sound
{
    public string name;            //Nome da dare alla clip

    public AudioClip clip;         //Clip da riprodurre

    [Range(0f, 1f)]
    public float volume;           //Volume della clip

    public bool loop;              //Setto se la clip deve andare in loop

    public Type type;              //Tipo di audio

    [HideInInspector]
    public AudioSource source;
}
