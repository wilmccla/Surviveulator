using UnityEngine;

public class Interactable : MonoBehaviour
{
    public PlayerData data;
    public Transform interactionTransform;

    public float radius = 3f;
    private bool hasInteracted;

    void Awake()
    {
        data = GameObject.FindWithTag("Player").GetComponent<PlayerData>();
    }
    void Update()
    {
        float distance = Vector3.Distance(data.tf.position, interactionTransform.position);
        if (distance <= radius && hasInteracted == false && Input.GetKey(KeyCode.E))
        {
            Debug.Log("Interact");
            Interact();
            hasInteracted = true;
        }
    }

    public virtual void Interact()
    {

    }

    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
