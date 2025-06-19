using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;

    public void SwitchToCam2()
    {
        vCam1.Priority = 0;
        vCam2.Priority = 10;
    }

    public void SwitchToCam1()
    {
        vCam1.Priority = 10;
        vCam2.Priority = 0;
    }
}