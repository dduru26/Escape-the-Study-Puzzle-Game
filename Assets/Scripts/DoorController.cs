using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f;
    public float speed = 2f;
    public AudioSource openSound;

    private Quaternion openRot;
    private bool opening = false;

    void Start()
    {
        openRot = transform.rotation * Quaternion.Euler(0f, openAngle, 0f);
    }

    void Update()
    {
        if (opening)
            transform.rotation = Quaternion.Slerp(transform.rotation, openRot, Time.deltaTime * speed);
    }

    public void Open()
    {
        if (opening) return;
        opening = true;
        if (openSound != null) openSound.Play();
        Debug.Log("Door opening!");
    }
}