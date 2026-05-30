using UnityEngine;

public class OrderPuzzle : MonoBehaviour
{
    public int[] correctOrder = { 2, 0, 1 };   // the IDs in the right order
    public PuzzleManager puzzleManager;
    public AudioSource buzzer;                  // optional wrong-answer sound

    private int currentStep = 0;
    private bool solved = false;

    public void PressButton(int id)
    {
        if (solved) return;

        if (id == correctOrder[currentStep])     // right one for this step?
        {
            currentStep++;
            Debug.Log("Correct! " + currentStep + " of " + correctOrder.Length);

            if (currentStep >= correctOrder.Length)
            {
                solved = true;
                Debug.Log("Order puzzle solved!");
                puzzleManager.CompleteTask(1);
            }
        }
        else                                     // wrong -> start over
        {
            Debug.Log("Wrong order - reset");
            currentStep = 0;
            if (buzzer != null) buzzer.Play();
        }
    }
}