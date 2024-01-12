using UnityEngine;

public class HotSpotTeleportScript : MonoBehaviour
{
    public Vector3 teleportPosition = new Vector3(0, 4, 0);
    public Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnMouseDown()
    {
        
        mainCamera.transform.position = teleportPosition;
    }

}