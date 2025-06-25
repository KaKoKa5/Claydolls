using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PortalSoundPlayer : MonoBehaviour
{
    [Header("Son du portail")]
    public AudioClip portalClip;       // Glisse ton clip dans l'inspector

    private AudioSource audioSource;
    private bool playerInRange = false;

    void Awake()
    {
        // Récupère et configure l'AudioSource  
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0f; // 2D pour toujours entendre
        if (portalClip == null)
            Debug.LogWarning($"[{name}] portalClip non assigné !");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log($"[{name}] Player entered trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log($"[{name}] Player exited trigger");
        }
    }

    void Update()
    {
        // Toujours logger l'appui sur E pour debug
        if (Input.GetKeyDown(KeyCode.E))
            Debug.Log($"[{name}] E pressed (playerInRange={playerInRange})");

        // Jouer le son si le joueur est à portée et appuie sur E
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (portalClip != null)
            {
                Debug.Log($"[{name}] Jouer clip {portalClip.name}");
                audioSource.PlayOneShot(portalClip);
            }
            else
            {
                Debug.LogWarning($"[{name}] portalClip non assigné !");
            }
        }
    }
}
