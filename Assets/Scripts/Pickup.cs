using UnityEngine;

public class Pickup : MonoBehaviour, IInteractable
{
    public static Pickup held;            // whatever is currently being carried
    public GameObject highlightToShow;    // the blue pad for this item's slot

    public void Interact()
    {
        if (held != null) return;         // already carrying something

        held = this;
        transform.SetParent(Camera.main.transform);
        transform.localPosition = new Vector3(0f, -0.2f, 0.8f);
        gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");

        if (highlightToShow != null) highlightToShow.SetActive(true);   // show the pad

        Debug.Log("Picked up " + name);
    }
}