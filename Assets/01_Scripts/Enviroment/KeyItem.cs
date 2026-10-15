using UnityEngine;

public class KeyItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogWarning("GameManager no encontrado en la escena.");
            return;
        }

        GameManager.Instance.ObtainKey();
        gameObject.SetActive(false);
        Debug.Log("Llave obtenida.");
    }
}
