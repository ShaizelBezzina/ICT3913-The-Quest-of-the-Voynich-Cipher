using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickFirstLevel : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("FirstScene");
    }
}