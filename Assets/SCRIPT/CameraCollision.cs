using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public Transform target;         // Le joueur ou l'objet suivi
    public float minDistance = 0.5f; // Distance minimale à garder
    public float maxDistance = 4f;   // Distance maximale de la caméra
    public float smooth = 10f;       // Lissage du mouvement
    public LayerMask collisionMask;  // Couches que la caméra ne doit pas traverser

    private Vector3 dollyDir;
    private float currentDistance;

    void Start()
    {
        dollyDir = transform.localPosition.normalized;
        currentDistance = transform.localPosition.magnitude;
    }

    void Update()
    {
        Vector3 desiredCameraPos = target.position + target.TransformDirection(dollyDir * maxDistance);
        RaycastHit hit;

        if (Physics.Raycast(target.position, desiredCameraPos - target.position, out hit, maxDistance, collisionMask))
        {
            currentDistance = Mathf.Clamp(hit.distance, minDistance, maxDistance);
        }
        else
        {
            currentDistance = maxDistance;
        }

        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * currentDistance, Time.deltaTime * smooth);
    }
}
