using UnityEngine;

public class NewsController : MonoBehaviour
{
    private GameObject activeNewsWindow;

    public void OpenNewsWindow(GameObject newsWindow)
    {
        if (activeNewsWindow != null && newsWindow != activeNewsWindow)
            activeNewsWindow.SetActive(false);

        newsWindow.SetActive(true);
        activeNewsWindow = newsWindow;
    }

    public void CloseNewsWindow(GameObject newsWindow)
    {
        newsWindow.SetActive(false);
        activeNewsWindow = null;
    }
}
