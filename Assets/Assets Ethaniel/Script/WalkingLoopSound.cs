using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WalkingLoopSound : MonoBehaviour
{
    [Header("Clips de marche")]
    public AudioClip grassLoopClip;
    public AudioClip stoneLoopClip;

    [Header("Détection")]
    public string stoneZoneTag = "StoneZone"; 

    private AudioSource _audioSource;
    private bool _isMoving = false;
    private bool _isOnStone = false;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.loop = true;
        _audioSource.playOnAwake = false;
        _audioSource.spatialBlend = 0f;
        _audioSource.clip = grassLoopClip; // clip par défaut
    }

    void Update()
    {
        _isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (_isMoving)
        {
            if (!_audioSource.isPlaying)
                _audioSource.Play();
        }
        else
        {
            if (_audioSource.isPlaying)
                _audioSource.Pause();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(stoneZoneTag))
        {
            _isOnStone = true;
            ChangeFootstepClip(stoneLoopClip);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(stoneZoneTag))
        {
            _isOnStone = false;
            ChangeFootstepClip(grassLoopClip);
        }
    }

    private void ChangeFootstepClip(AudioClip newClip)
    {
        if (_audioSource.clip == newClip) return;

        bool wasPlaying = _audioSource.isPlaying;
        _audioSource.Stop();
        _audioSource.clip = newClip;
        if (wasPlaying) _audioSource.Play();
    }
}