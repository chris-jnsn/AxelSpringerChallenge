using System.Collections;
using UnityEngine;

public class RayController : MonoBehaviour
{
    [SerializeField]
    private GameObject leftRaycaster, rightRaycaster;

    public void ActivateRaycasters()
    {
        leftRaycaster.SetActive(true);
        rightRaycaster.SetActive(true);
    }

    public void DeactivateRaycasters()
    {
        leftRaycaster.SetActive(false);
        rightRaycaster.SetActive(false);
    }
}
