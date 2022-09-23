using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cameraLocations;
    [SerializeField]
    private GameObject mainCamera;

    private int currentCameraLocationCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentCameraLocationCount = currentCameraLocationCount < cameraLocations.Length ? currentCameraLocationCount++ : 0;
            Debug.Log(currentCameraLocationCount);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            currentCameraLocationCount = currentCameraLocationCount >= 0  ? currentCameraLocationCount-- : cameraLocations.Length-1;
            Debug.Log(currentCameraLocationCount);
        }


        mainCamera.transform.parent = cameraLocations[currentCameraLocationCount].transform;
        mainCamera.transform.localPosition = Vector3.zero;
        mainCamera.transform.rotation = Quaternion.identity;
    }
}
