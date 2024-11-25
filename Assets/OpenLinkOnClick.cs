using UnityEngine;

public class OpenLinkOnClick : MonoBehaviour
{
    // URL a abrir
    [SerializeField]
    private string url = "https://www.google.com";

    // Método que se ejecutará al hacer clic en el objeto
    public void OpenURL()
    {
        UnityEngine.Application.OpenURL(url); // Se especifica explícitamente
    }
}
