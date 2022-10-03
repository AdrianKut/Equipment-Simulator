using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] _audioClips;
    private AudioSource _audioSource;

    public static AudioManager Instance;
    private AudioManager() { }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

            _audioSource = this.gameObject.GetComponent<AudioSource>();
        }
    }

    public void PlayRandomAudioClip()
    {
        var randomClip = Random.Range(0, _audioClips.Length);
        _audioSource.PlayOneShot(_audioClips[randomClip]);
    }
}
