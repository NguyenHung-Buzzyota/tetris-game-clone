using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    private PauseMenu pauseMenu;

    private void Start() {
        pauseMenu.Resume();
    }
}