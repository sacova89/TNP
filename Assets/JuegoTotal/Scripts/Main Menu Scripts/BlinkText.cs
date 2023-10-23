using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkText : MonoBehaviour
{

    /** Declaro 2 espacios para los GameObjects, los Menus**/
    [SerializeField] private GameObject insertMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject backgroundMusicGO;
    [SerializeField] private GameObject scrollingBackgroundGO;


    /** Declaro un espacio para el GameObject Text de InsertCoin 
     * Y una variable float para el tiempo de repeticion de la funcion ChangeState**/
    [SerializeField] private GameObject insertCoinText;
    [SerializeField] private float repeatTime;

    /** Declaro una Fuente de Audio AudioSource 'coinSound' para asignarle por medio del Inspector el audio**/
    [SerializeField] private AudioSource coinSound;




    void Start()
    {
        /** Activo desde el incio el menu 'InsertCoin' y desactivo desde el inicio el menu 'MainMenu'**/
        insertMenu.SetActive(true);
        scrollingBackgroundGO.SetActive(false);
        mainMenu.SetActive(false);

        /**Invoca la funcion 'ChangeState', despues de un segundo, 
         * y repite el numero de segundos de acuerdo valor asignado en la variable 'repeatTime'**/
        InvokeRepeating("ChangeState", 1f, repeatTime);

    }

    /** Cambia los menus. Desactiva el menu 'InsertCoin', activa el menu "MainMenu" 
    *   Y desactiva el gameobject con el script para evitar problemas   **/ 
    void ChangeMenus()
    {
            insertMenu.SetActive(false);
            gameObject.SetActive(false);
            scrollingBackgroundGO.SetActive(true);
            mainMenu.SetActive(true);
            backgroundMusicGO.SetActive(true);
    }

    /** Metodo que cambia el estado activo del GameObject 'insertCoinText' a su negativo
     *  Es decir, si esta apagado, lo enciende, y si esta encendido, lo apaga **/
    void ChangeState()
    {
        insertCoinText.SetActive(!insertCoinText.activeInHierarchy);
    }



    void Update()
    {
        /** Condicion que: Si se presiona ENTER, ejecute el sonido asignado a 'coinSound' 
         *  y que Invoque el metodo 'ChangeMenus' esperando 2 segundos antes de invocarlo  **/
        if(Input.GetKeyDown(KeyCode.Return))
        {
            coinSound.Play();
            Invoke ("ChangeMenus", 2f);
        }

        /** Codigo anterior que: Desactiva el Menu InsertCoin, ejecuta el sonido, activa el Menu MainMenu
        *   Y desactiva el gameobject con el script para evitar problemas**/
       
       /** if(Input.GetKeyDown(KeyCode.Return))
        {
            insertMenu.SetActive(false);
           // coinSound.Play();
            mainMenu.SetActive(true);
            gameObject.SetActive(false);
        }**/

    }
}
