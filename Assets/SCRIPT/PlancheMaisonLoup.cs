using UnityEngine;

public class PlancheMaisonLoup : MonoBehaviour
{
    private bool playerInRange = false;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        playerInRange = false;
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E)&& TableauMemoire.AmiChien==true)
        {
            rb.useGravity = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& TableauMemoire.AmiChien==true)
        {
            playerInRange = true;
            Debug.Log("tombe");
        }
    }
    private void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player")&& TableauMemoire.AmiChien==true)
    {
        playerInRange = false;
    }
}

    

}
