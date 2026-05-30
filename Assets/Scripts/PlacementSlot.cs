using UnityEngine;

public class PlacementSlot : MonoBehaviour, IInteractable
{
    public Pickup requiredObject;     // which item belongs here
    public Transform snapPoint;       // where it should sit
    public PuzzleManager puzzleManager;
    public int puzzleIndex = 3;       // line 4 on the checklist
    public GameObject highlight;      // drag the PlacementHighlight here

    private bool filled = false;

    public void Interact()
    {
        if (filled) return;

        if (Pickup.held != null && Pickup.held == requiredObject)
        {
            Pickup placed = Pickup.held;
            placed.transform.SetParent(null);
            placed.transform.position = snapPoint.position;
            placed.transform.rotation = snapPoint.rotation;
            placed.gameObject.layer = LayerMask.NameToLayer("Default");
            Pickup.held = null;
            filled = true;

            if (highlight != null) highlight.SetActive(false);   // hide the blue pad

            Debug.Log("Placed correctly!");
            puzzleManager.CompleteTask(puzzleIndex);
        }
        else
        {
            Debug.Log("Wrong item, or hands empty");
        }
    }
}