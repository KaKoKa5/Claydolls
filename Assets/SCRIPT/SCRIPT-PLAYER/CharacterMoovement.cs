using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharaterMoovement : MonoBehaviour
{
    private bool controlsEnabled = true;

    #region Références
    [Header("Composants")]
    [SerializeField] private CharacterController controller;  // contrôleur de personnage
    [SerializeField] private Transform cameraTransform;       // orientation de la caméra principale
    #endregion

    #region Paramètres de mouvement
    [Header("Vitesse et gravité")]
    [SerializeField] private float walkSpeed = 5f;            // vitesse de marche
    [SerializeField] private float sprintMultiplier = 2f;     // multiplicateur de vitesse pour la course
    [SerializeField] private float gravity = -9.81f;          // force de gravité

    private Vector3 velocity;                                 // composante de vitesse verticale (gravité)
    #endregion

    private void Reset()
    {
        // Initialisation automatique des références
        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main ? Camera.main.transform : null;
    }

    private void Update()
    {

        // Récupération des axes de déplacement (WASD / flèches)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Calcul des directions avant et droite basées sur la caméra
        Vector3 camForward = cameraTransform.forward;
        camForward.y = 0;
        camForward.Normalize();

        Vector3 camRight = cameraTransform.right;
        camRight.y = 0;
        camRight.Normalize();

        // Direction de déplacement relative à la caméra
        Vector3 moveDir = camForward * z + camRight * x;

        // Détection de la touche Shift pour la course
        bool isSprinting = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float currentSpeed = isSprinting ? walkSpeed * sprintMultiplier : walkSpeed;

        if (moveDir.magnitude >= 0.1f)
        {
            // Rotation douce vers la direction de déplacement
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(moveDir),
                Time.deltaTime * 10f
            );

            // Déplacement en fonction de la vitesse courante
            controller.Move(moveDir.normalized * currentSpeed * Time.deltaTime);
        }

        // Application de la gravité
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    public void EnableControls(bool enabled)
    {
        controlsEnabled = enabled;
    }
}
