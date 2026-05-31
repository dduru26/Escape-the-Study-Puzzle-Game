using UnityEngine;

public class Interactor : MonoBehaviour
{
    public float range = 8f;
    public float radius = 0.3f;
    public Camera cam;
    public GameObject interactPrompt;     // the "Press E" UI to show/hide

    private IInteractable current;

    void Start()
    {
        if (cam == null) cam = Camera.main;
        if (interactPrompt != null) interactPrompt.SetActive(false);
    }

    void Update()
    {
        // every frame: figure out what we're looking at
        current = null;
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.SphereCast(ray, radius, out RaycastHit hit, range))
        {
            current = hit.collider.GetComponentInParent<IInteractable>();
        }

        // show the prompt only when an interactable is under the crosshair
        if (interactPrompt != null)
            interactPrompt.SetActive(current != null);

        // press E to interact with whatever we're looking at
        if (current != null && Input.GetKeyDown(KeyCode.E))
        {
            current.Interact();
        }
    }
}