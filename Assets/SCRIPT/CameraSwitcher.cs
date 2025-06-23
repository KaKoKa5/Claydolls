using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;
    public CinemachineVirtualCamera vCam3;
    public CinemachineVirtualCamera vCam4;
    public CinemachineVirtualCamera vCam5;

    public void SwitchToCam2()
    {
        vCam1.Priority = 0;
        vCam2.Priority = 10;
        vCam3.Priority = 0;
        vCam4.Priority = 0;
        vCam5.Priority = 0;
    }

    public void SwitchToCam1()
    {
        vCam1.Priority = 10;
        vCam2.Priority = 0;
        vCam3.Priority = 0;
        vCam4.Priority = 0;
        vCam5.Priority = 0;
    }
    public void SwitchToCam3()
    {
        vCam1.Priority = 0;
        vCam2.Priority = 0;
        vCam3.Priority = 10;
        vCam4.Priority = 0;
        vCam5.Priority = 0;
    }
    public void SwitchToCam4()
    {
        vCam1.Priority = 0;
        vCam2.Priority = 0;
        vCam3.Priority = 0;
        vCam4.Priority = 10;
        vCam5.Priority = 0;
    }
    public void SwitchToCam5()
    {
        vCam1.Priority = 0;
        vCam2.Priority = 0;
        vCam3.Priority = 0;
        vCam4.Priority = 0;
        vCam5.Priority = 10;
    }

}