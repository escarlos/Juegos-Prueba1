using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    public Canvas _inventarioIn;
    [SerializeField]
    GameObject _inventarioActividad;
    // Start is called before the first frame update

    
    private void Update()
    {
       activarInventario();
    }

    void activarInventario() {
         bool prueba = _inventarioActividad;
        if (Input.GetKey(KeyCode.I)){
            
            _inventarioActividad.GetComponent<Canvas> ().enabled = !_inventarioActividad.GetComponent<Canvas> ().enabled;
            return;
        }
    }
}
