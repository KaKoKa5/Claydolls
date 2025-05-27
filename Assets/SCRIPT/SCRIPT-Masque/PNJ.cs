using UnityEngine;

public class PNJ : MonoBehaviour
{
    
    [SerializeField] private float distanceToInteract = 3f; 
    private Transform player; 
    private bool isInRange = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
     void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < distanceToInteract)
        {
            if (!isInRange)
            {
                Debug.Log("apparait");
                isInRange = true;
                InteractIcon1.Instance.SetCurrentNPC(this);
            }


            if (Input.GetKeyDown(KeyCode.E))
            {

                InteractIcon1.Instance.ClearCurrent();
            }
        }
        else
        {
            if (isInRange)
            {
                isInRange = false;
                Debug.Log("diparait");
                InteractIcon1.Instance.ClearCurrent();
                return;
            }
            
        }
    }



}
