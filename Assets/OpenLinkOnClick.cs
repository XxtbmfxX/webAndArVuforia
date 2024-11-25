using UnityEngine;

public class OpenLinkOnClick : MonoBehaviour
{
    // URL a abrir
    [SerializeField]
    private string url = "https://www.google.com";

    // M�todo que se ejecutar� al hacer clic en el objeto
    public void OpenURL()
    {
        UnityEngine.Application.OpenURL(url); // Se especifica expl�citamente
    }
}
