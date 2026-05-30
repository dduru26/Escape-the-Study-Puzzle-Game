using UnityEngine;

public class FinalLever : MonoBehaviour, IInteractable
{
    public PuzzleManager puzzleManager;
    public int puzzleIndex = 4;        // line 5 on the checklist
    public int requiredBefore = 4;     // first 4 puzzles must be done first
    public DoorController door;
    public Light readyLight;           // optional: red until ready, then green
    public AudioSource lockedSound;    // optional: buzz when pulled too early

    private bool pulled = false;

    void Update()
    {
        // glow green once the other four are done (the clue that it's ready)
        if (readyLight != null && !pulled)
            readyLight.color = puzzleManager.AreTasksDone(requiredBefore) ? Color.green : Color.red;
    }

    public void Interact()
    {
        if (pulled) return;

        if (!puzzleManager.AreTasksDone(requiredBefore))
        {
            Debug.Log("Not ready - solve the other puzzles first");
            if (lockedSound != null) lockedSound.Play();
            return;
        }

        pulled = true;
        Debug.Log("Lever pulled - opening door!");
        puzzleManager.CompleteTask(puzzleIndex);
        if (door != null) door.Open();
    }
}