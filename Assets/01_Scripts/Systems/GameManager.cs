using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool HasKey { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        Initialize(); // Inicialización única y correcta del sistema
    }


    public void Initialize()
    {
        Debug.Log("[GameManager] Inicializando sistemas del juego...");
    }

    public void ObtainKey()
    {
        HasKey = true;
    }
}

