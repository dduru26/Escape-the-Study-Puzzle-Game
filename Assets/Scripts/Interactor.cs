using UnityEngine;

public class Interactor : MonoBehaviour
{
    public float range = 80f;
    public Camera cam;

    void Start()
    {
        if (cam == null) cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed");

            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(ray, out RaycastHit hit, range))
            {
                Debug.Log("HIT: " + hit.collider.name);

                IInteractable obj = hit.collider.GetComponentInParent<IInteractable>();
                if (obj != null)
                {
                    obj.Interact();
                }
                else
                {
                    Debug.Log(hit.collider.name + " has no interactable script");
                }
            }
            else
            {
                Debug.Log("Hit nothing within range " + range);
            }
        }
    }
}