using Oculus.Interaction.Input;
using UnityEngine;

public class TriggerSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject newsArticle;

    [SerializeField]
    private RayController rayController;

    [SerializeField]
    private NewsController newsController;

    private Color inactive = new Color32(255, 98, 57, 120);
    private Color active = new Color32(255, 255, 0, 255);

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.SetColor("_Color", active);
    }

    private void OnTriggerStay(Collider other)
    {
        var collisionObject = other.GetComponentInParent<Controller>();
        if (collisionObject != null)
        {
            if (collisionObject.Handedness == Handedness.Left && OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                newsController.OpenNewsWindow(newsArticle);
                newsArticle.SetActive(true);
                rayController.ActivateRaycasters();
            }
            else if(collisionObject.Handedness == Handedness.Right && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {
                newsController.OpenNewsWindow(newsArticle);
                newsArticle.SetActive(true);
                rayController.ActivateRaycasters();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.SetColor("_Color", inactive);
    }
}
