using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    private bool puzzleSolved = false;

    public bool ValidateCode(string code)
    {
        if (puzzleSolved)
        {
            Debug.Log("El puzzle ya fue resuelto.");
            return true;
        }

        if (code != correctCode)
        {
            Debug.Log("Código incorrecto.");
            return false;
        }

        puzzleSolved = true;
        Debug.Log("Puzzle completado correctamente.");
        return true;
    }
}
