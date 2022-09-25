using FirstGearGames.SmoothCameraShaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public ShakeData MyShake;
    private void Start()
    {
        CameraShakerHandler.Shake(MyShake);
    }

}
