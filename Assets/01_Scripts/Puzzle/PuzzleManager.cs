using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";

    public bool ValidateCode(string code)
    {
        bool valid = code == correctCode;

        if (valid)
        {
            Debug.Log("Código correcto.");
        }
        else
        {
            Debug.Log("Código incorrecto.");
        }

        return valid;
    }
}
