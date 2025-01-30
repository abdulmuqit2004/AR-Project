using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlaneDetection : MonoBehaviour
{
    private ARPlaneManager planeManager;

    void Start()
    {
        planeManager = GetComponent<ARPlaneManager>();
    }

    public void TogglePlaneDetection()
    {
        planeManager.enabled = !planeManager.enabled;
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(planeManager.enabled);
        }
    }
}
