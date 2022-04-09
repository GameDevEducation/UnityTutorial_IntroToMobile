using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.EnhancedTouch;

public class PlayerController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Display_TouchPhase;
    [SerializeField] TextMeshProUGUI Display_StartTime;
    [SerializeField] TextMeshProUGUI Display_StartPosition;
    [SerializeField] TextMeshProUGUI Display_DeltaPosition;

    // Start is called before the first frame update
    void Start()
    {
        // safe location to store info
        Debug.Log(Application.persistentDataPath);

        Debug.Log(System.IO.Path.Combine(Application.persistentDataPath, "SaveFile", "Slot0.save"));

        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            //TouchSimulation.Enable();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTouch(InputValue value)
    {
        var state = value.Get<TouchState>();

        Display_TouchPhase.text = state.phase.ToString(); 
        Display_StartTime.text = state.startTime.ToString(); // based on Time.realtimeSinceStartupAsDouble
        Display_StartPosition.text = state.startPosition.ToString();
        Display_DeltaPosition.text = state.delta.ToString();
    }
}
