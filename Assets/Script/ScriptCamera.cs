using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptCamera : MonoBehaviour
{
	float sensibiltiteSouris = 100;
	public Transform joueur;

	float rotationX = 0;

	public Camera avant;
	public Camera arriere;
	public Text txtInfo;

    // Start is called before the first frame update
    void Start()
    {
		//on regarde par l'avant
		avant.enabled = true;
		arriere.enabled = false;

		//on fait disparaitre le cursor
		Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
		//On regarde ou est la souris
		float sourisX = Input.GetAxis("Mouse X") * sensibiltiteSouris * Time.deltaTime;
		float sourisY = Input.GetAxis("Mouse Y") * sensibiltiteSouris * Time.deltaTime;
		
		rotationX -= sourisY;
		rotationX = Mathf.Clamp(rotationX, -90f, 90f);			

		//changement de vue si on appuie sur C
		if (Input.GetKeyDown(KeyCode.C))
		{
			arriere.enabled = !arriere.enabled;
			avant.enabled = !avant.enabled;
		}

		//On fait la rotation selon la position de la souris
		if (arriere.enabled)
		{
			txtInfo.text = "Vue arrière (press C pour passer a la vue avant)";
			arriere.transform.localRotation = Quaternion.Euler(rotationX, 190f, 0f);
		}
		else
		{
			txtInfo.text = "Vue avant (press C pour passer a la vue arrière)";
			avant.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
		}

		joueur.Rotate(Vector3.up * sourisX);		
    }
}
