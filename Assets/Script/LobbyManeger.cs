using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManeger : MonoBehaviour
{
    public void LoadPlaySence()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadLobbySence()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void LoadHowToPlaySence()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void LoadClearSence()
    {
        SceneManager.LoadScene("Clear");
    }


}
