using UnityEngine;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    public string[] puzzleNames =
    {
        "Let there be light",
        "Set the record straight",
        "A turn for the better",
        "Right where it belongs",
        "Pull yourself together"
    };

    public TextMeshProUGUI checklistText;
    private bool[] done;

    void Start()
    {
        done = new bool[puzzleNames.Length];
        RefreshChecklist();
    }

    public void CompleteTask(int index)
    {
        if (index < 0 || index >= done.Length || done[index]) return;
        done[index] = true;
        RefreshChecklist();
        if (AllDone()) Debug.Log("All puzzles solved - the door unlocks!");
    }

    bool AllDone()
    {
        foreach (bool b in done)
            if (!b) return false;
        return true;
    }

    // NEW: are the first `count` tasks finished?
    public bool AreTasksDone(int count)
    {
        for (int i = 0; i < count && i < done.Length; i++)
            if (!done[i]) return false;
        return true;
    }

    void RefreshChecklist()
    {
        string s = "";
        for (int i = 0; i < puzzleNames.Length; i++)
        {
            if (done[i])
                s += "<s><color=#7CC47C>" + puzzleNames[i] + "</color></s>\n";
            else
                s += puzzleNames[i] + "\n";
        }
        checklistText.text = s;
    }
}