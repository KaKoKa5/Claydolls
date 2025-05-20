using UnityEngine;

/// <summary>
/// Gère l'orbite de la caméra autour d'une cible (généralement le joueur).
/// </summary>
public class CameraOrbit : MonoBehaviour
{
    [Header("Référence Player")]
    public Transform target;                // Transform de l'objet à suivre

    [Header("Position de départ")]
    public Vector3 offset = new Vector3(0f, 1.5f, -3f); // Décalage initial par rapport à la cible

    [Header("Sensibilités souris")]
    public float sensitivityX = 4f;         // Sensibilité de la rotation horizontale
    public float sensitivityY = 2f;         // Sensibilité de l'inclinaison verticale

    [Header("Limites d'inclinaison")]
    public float minYAngle = -30f;          // Angle minimum de pitch (regard vers le bas)
    public float maxYAngle =  60f;          // Angle maximum de pitch (regard vers le haut)

    private float yaw;    // Angle de rotation autour de l'axe Y
    private float pitch;  // Angle d'inclinaison autour de l'axe X

    void Start()
    {
        // Initialise yaw et pitch à la rotation actuelle de la caméra
        Vector3 angles = transform.eulerAngles;
        yaw   = angles.y;
        pitch = angles.x;

        // Verrouille et masque le curseur pour capturer la souris
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible   = false;
    }

    void LateUpdate()
    {
        // Arrêt de l'orbite si le jeu est en pause (Time.timeScale == 0)
        if (Time.timeScale == 0f)
            return;

        // Ne pas exécuter si aucune cible n'est assignée
        if (target == null)
            return;

        // Ajuste yaw et pitch selon le mouvement de la souris
        yaw   += Input.GetAxis("Mouse X") * sensitivityX;
        pitch -= Input.GetAxis("Mouse Y") * sensitivityY;

        // Limite l'inclinaison entre les angles min et max
        pitch = Mathf.Clamp(pitch, minYAngle, maxYAngle);

        // Calcule la rotation désirée de la caméra
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);

        // Calcule la position désirée : position cible + offset tourné
        Vector3 desiredPos = target.position + rotation * offset;

        // Applique la position et la rotation
        transform.position = desiredPos;
        transform.rotation = rotation;
    }
}
