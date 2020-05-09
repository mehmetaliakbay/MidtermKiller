using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
        GameData data = new GameData();
        data.yLocation = -4.26f;
        data.score = 0;
        SaveLoadManager.Save(data);
        SceneManager.LoadScene(1);
    }

    public void LoadLastGame()
    {
        SceneManager.LoadScene(1);
    }


}
