using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform target1; // first target object to teleport to
    public Transform target2; // second target object to teleport to
    private bool teleportTo1 = true; // flag to track which target to teleport to

    private void OnMouseDown()
    {
        if (teleportTo1)
        {
            transform.position = target1.position;
            teleportTo1 = false;
        }
        else
        {
            transform.position = target2.position;
            teleportTo1 = true;
        }
    }
}