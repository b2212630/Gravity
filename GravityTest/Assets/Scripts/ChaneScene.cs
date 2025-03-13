using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour 
{
        public void change_button() //change_buttonという名前にします
        {
            SceneManager.LoadScene("New Scene");//secondを呼び出します
        }
}