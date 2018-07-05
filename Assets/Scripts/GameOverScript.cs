using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    private Texture2D tex;
    Rect pos;

    void Start()
    {
        tex = Resources.Load("died", typeof(Texture2D)) as Texture2D;
        pos = new Rect(Screen.width / 2 - 60,
                       2 * Screen.height / 3 - 200, 150, 150);
    }

    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;

        Debug.Log(tex);
        GUI.DrawTexture(pos, tex);

        if (
          GUI.Button(
            // Center in X, 1/3 of the height in Y
            new Rect(
              Screen.width / 3 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Retry!"
          )
        )
        {
            // Reload the level
            Application.LoadLevel("PlayGround");
        }

        if (
          GUI.Button(
            // Center in X, 2/3 of the height in Y
            new Rect(
              2 * Screen.width / 3 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Back to menu"
          )
        )
        {
            // Reload the level
            Application.LoadLevel("Menu");
        }
    }
}
