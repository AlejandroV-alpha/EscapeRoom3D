using UnityEngine;

public class PuzzleHint : MonoBehaviour
{
    [SerializeField] private string hint = "El código son los primeros cuatro números.";

    public void ShowHint()
    {
        Debug.Log("Pista: " + hint);
    }
}
