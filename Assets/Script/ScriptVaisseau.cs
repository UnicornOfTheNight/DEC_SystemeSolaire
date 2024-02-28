using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptVaisseau : MonoBehaviour
{
	public float speed = 40f;

	public float moveSpeed;
	private Vector3 moveDirection;
	public Transform pivot;
	
	public float distance = 5f;

	public Text txtPosition;
	public Camera cameraAvant;
	public Camera cameraArriere;

	void Start()
	{
	}
	// Update is called once per frame
	void Update()
    {
		moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
		moveDirection = moveDirection.normalized * moveSpeed;
		Camera cameraUtilise = new Camera();

		//on regarde quelle camera est utilisée
		if (cameraAvant.enabled)
			cameraUtilise = cameraAvant;
		else
			cameraUtilise = cameraArriere;

		moveDirection = cameraUtilise.transform.forward;
		
		//on regarde si le joueur veut avancer ou reculer
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
		{
			//le joueur se déplace selon la ou la camera regarde
			//euler pour avoir les 3 angles
			transform.rotation = Quaternion.Euler(0f, pivot.rotation.eulerAngles.y, 0f);

			Vector3 direction = new Vector3(cameraUtilise.transform.forward.x, cameraUtilise.transform.forward.y, cameraUtilise.transform.forward.z);

			//on regarde si le joueur veut aller vers la droite ou vers la gauche
			if (Input.GetAxis("Horizontal") == 0)
			{
				//on bouge selon la vue (les controles sont inversé en vue arriere)
				if(cameraAvant.enabled) transform.position += transform.TransformDirection(cameraUtilise.transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
				else transform.position += cameraUtilise.transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical") * (-1);
			}
			else
			{
				//on bouge selon la vue (les controles sont inversé en vue arriere)
				direction.x = Input.GetAxis("Horizontal");
				if (cameraAvant.enabled) transform.position += transform.TransformDirection(direction * speed * Time.deltaTime);
				else transform.position += transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), direction.y, direction.z) * speed * Time.deltaTime);
			}
		}

		//update la position sur la minimap
		txtPosition.text = "Coordonnées : \n\r(" + Mathf.Round(transform.position.x) + " ; " + Mathf.Round(transform.position.y) + " ; " + Mathf.Round(transform.position.z) + " )";
	}
}