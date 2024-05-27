using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Cuando el usuario presione el botón "Aceptar"
//Debe escribirse un mensaje en consola
//si el texto del Input_Psswrd coincide
//Con una contraseña predefinida por ustedes
//escribir "Access Guaranted", Sino escribir "Access Denied"

public class LoginManager : MonoBehaviour
{
    public InputField Input_PssWrd;
    public string PssWrd;

    public void PasswordInput()
    {
        if (Input_PssWrd.text == PssWrd)
        {
            Debug.Log("Access Guaranted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
