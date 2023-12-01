using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] MenuManager _menuManager;
    [SerializeField] Camera _camera;
    [SerializeField] Vector3 mousePosition;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CameraRay();
        }
    }

    void CameraRay()
    {
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit _hit;

        if(Physics.Raycast(_ray, out _hit, Mathf.Infinity))
        {
	        Debug.DrawLine(Camera.main.transform.position, _hit.point, Color.green);
	        if(_hit.transform.gameObject.tag == ("Cube1"))
	        {
		        Debug.Log("Círculo número 1 clicado");
                _menuManager.Scene1();
	        }
            if(_hit.transform.gameObject.tag == ("Cube2"))
	        {
		        Debug.Log("Círculo número 2 clicado");
                _menuManager.Scene3();
	        }
            if(_hit.transform.gameObject.tag == ("Circle"))
	        {
		        Debug.Log("Esfera clicada");
                _menuManager.Scene2();
	        }
        }
    }
}
