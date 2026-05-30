using UnityEngine;

public class LampSwitch : MonoBehaviour, IInteractable
{
    public Light[] roomLights;          // all the OTHER lamps go here
    public PuzzleManager puzzleManager;
    private bool isOn = false;

    void Start()
    {
        // make the room start dark - turn the other lamps off
        foreach (Light l in roomLights)
            l.enabled = false;
    }

    public void Interact()
    {
        Debug.Log("Lamp clicked!");     // proof the click worked
        if (isOn) return;

        isOn = true;
        foreach (Light l in roomLights)
            l.enabled = true;           // power the whole room on
        puzzleManager.CompleteTask(0);
    
    }
}