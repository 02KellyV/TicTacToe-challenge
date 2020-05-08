using UnityEngine;
using UnityEngine.UI;

public class GridSpaceScript : MonoBehaviour
{
    public Button button;
    public Text buttonText;

    private GameControllerScript gameController;

    // Start is called before the first frame update
    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

    public void SetGameControllerReference(GameControllerScript controller)
    {
        gameController = controller;
    }
}
