using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
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

        if (code != correctCode)
        {
            Debug.Log("Codigo incorrecto.");
            return false;
        }

        puzzleSolved = true;
        Debug.Log("Puzzle completado correctamente.");
        return true;
    }
}
