using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public GameObject cont_menuUI;
    public GameObject restartButtonUI;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Basketball")) {

            cont_menuUI.SetActive(true);
            restartButtonUI.SetActive(false);
        }





    }








}
