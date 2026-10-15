using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    [SerializeField] private int maxAttempts = 3;

    [SerializeField] private ChestController chest;

    private int currentAttempts = 0;
    private bool puzzleSolved = false;

    private void Start()
    {
        ValidateCode("0000"); // Codigo incorrecto
        ValidateCode("1234"); // Codigo correcto
        ValidateCode("1234"); // Puzzle ya resuelto
    }

    public bool ValidateCode(string code)
    {
        if (puzzleSolved)
        {
            Debug.Log("El puzzle ya fue resuelto.");
            return true;
        }

        if (currentAttempts >= maxAttempts)
        {
            Debug.LogWarning("Intentos agotados. Reinicia el puzzle.");
            return false;
        }

        if (code == null || code.Trim() != correctCode)

        {
            currentAttempts++;
            Debug.Log($"Codigo incorrecto. Intento {currentAttempts}/{maxAttempts}");
            return false;
        }

        puzzleSolved = true;
        if (chest != null) chest.Unlock();
        Debug.Log("Puzzle completado correctamente.");
        return true;
    }

    public void ResetPuzzle()
    {
        puzzleSolved = false;
        currentAttempts = 0;
        Debug.Log("Puzzle reiniciado.");
    }
}

