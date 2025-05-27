using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WalkingLoopHandler : MonoBehaviour
{
    [Header("Clips de marche")]
    public AudioClip grassLoop;
    public AudioClip stoneLoop;

    [Header("Réglages")]
    public float runPitchMultiplier = 2f;
    public string stoneZoneTag = "StoneZone";

    private AudioSource _audio;
    private bool _isOnStone = false;

    void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _audio.loop = true;
        _audio.playOnAwake = false;
        _audio.spatialBlend = 0f;
        _audio.clip = grassLoop;
    }

    void Update()
    {
        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        if (isMoving)
        {
            if (!_audio.isPlaying)
                _audio.Play();

            _audio.pitch = isRunning ? runPitchMultiplier : 1f;
        }
        else
        {
            if (_audio.isPlaying)
                _audio.Pause();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(stoneZoneTag))
        {
            _isOnStone = true;
            ChangeClip(stoneLoop);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(stoneZoneTag))
        {
            _isOnStone = false;
            ChangeClip(grassLoop);
        }
    }

    private void ChangeClip(AudioClip newClip)
    {
        if (_audio.clip == newClip) return;

        bool wasPlaying = _audio.isPlaying;
        _audio.Stop();
        _audio.clip = newClip;
        if (wasPlaying)
            _audio.Play();
    }
}