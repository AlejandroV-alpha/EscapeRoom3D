using UnityEngine;

public class PuzzleTimer : MonoBehaviour
{
    [SerializeField] private float timeLimit = 60f;
    private float elapsed;

    private void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timeLimit)
        {
            Debug.Log("Tiempo agotado (experimental).");
            enabled = false;
        }
    }
}
