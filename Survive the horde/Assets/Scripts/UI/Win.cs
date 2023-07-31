using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Spaceship");
    }
}
