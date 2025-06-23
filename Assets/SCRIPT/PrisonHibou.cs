using UnityEngine;

public class PrisonHibou : MonoBehaviour
{
    private bool isOpen = false;
    private bool playerInRange = false;

    public Vector3 closedRotation = new Vector3(0f, 0f, 0f);
    public Vector3 openRotation = new Vector3(0f, 90f, 0f);
    public float rotationSpeed = 2f;

    void Update()
    {
        if (TableauMemoire.prison == true)
        {
            isOpen = true;
        }
        else
        {
            isOpen = false;
        }

        // Smooth rotation
            Quaternion targetRotation = Quaternion.Euler(isOpen ? openRotation : closedRotation);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& TableauMemoire.MaisonHibou==true)
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")&& TableauMemoire.MaisonHibou==true)
        {
            playerInRange = false;
        }
    }
}
