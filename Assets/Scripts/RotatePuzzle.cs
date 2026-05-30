using UnityEngine;

public class RotatePuzzle : MonoBehaviour, IInteractable
{
    public Vector3 rotationAxis = Vector3.up;   // which way it spins
    public int positions = 4;                   // number of stops (4 = quarter turns)
    public int correctPosition = 2;             // which stop is the right one
    public PuzzleManager puzzleManager;
    public int puzzleIndex = 2;                 // line 3 on the checklist

    private int current = 0;
    private Quaternion startRotation;
    private bool solved = false;

    void Start()
    {
        startRotation = transform.localRotation;   // remember the starting pose
    }

    public void Interact()
    {
        if (solved) return;

        current = (current + 1) % positions;       // step to the next stop, loop around
        float step = 360f / positions;
        transform.localRotation = startRotation * Quaternion.AngleAxis(current * step, rotationAxis);

        Debug.Log("Rotated to stop " + current);

        if (current == correctPosition)
        {
            solved = true;
            Debug.Log("Rotate puzzle solved!");
            puzzleManager.CompleteTask(puzzleIndex);
        }
    }
}