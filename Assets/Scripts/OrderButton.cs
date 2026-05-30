using UnityEngine;

public class OrderButton : MonoBehaviour, IInteractable
{
    public int id;                 // this object's number
    public OrderPuzzle puzzle;     // drag the OrderPuzzle here

    public void Interact()
    {
        puzzle.PressButton(id);
    }
}