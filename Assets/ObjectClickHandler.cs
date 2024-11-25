using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    void Update()
    {
        // Detecta clic izquierdo del mouse o toque en pantalla
        if (Input.GetMouseButtonDown(0))
        {
            // Lanza un rayo desde la cámara hacia la posición del mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Si el objeto tiene el script OpenLinkOnClick, llama a su método OpenURL
                OpenLinkOnClick linkScript = hit.collider.GetComponent<OpenLinkOnClick>();
                if (linkScript != null)
                {
                    linkScript.OpenURL();
                }
            }
        }
    }
}
