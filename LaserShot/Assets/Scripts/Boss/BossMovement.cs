using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {
	[SerializeField] private float speed;
	private bool cambie = false;
	private float potencia = 1;
	[SerializeField] private GameObject turrent1;
	[SerializeField] private GameObject turrent2;
	[SerializeField] private GameObject turrent3;

	void Awake(){
		turrent1.SetActive(false);
		turrent2.SetActive(false);
		turrent3.SetActive(false);
		gameObject.SetActive(false);
	}

	void Update(){
		/*presentacion*/
		if (transform.position.z > 18){
			transform.Translate(0, 0, -speed * Time.deltaTime);
		}
		else{
			turrent1.SetActive(true);
			turrent2.SetActive(true);
			turrent3.SetActive(true);
		}
		/*fases*/
		if (gameObject.GetComponent<Life>().Amount < 80){
			potencia = 1.5f;
			turrent1.GetComponent<EnemyShoot>().FireRate = 0.5f;
			turrent2.GetComponent<EnemyShoot>().FireRate = 0.5f;
			turrent3.GetComponent<EnemyShoot>().FireRate = 0.5f;
		}
		if (gameObject.GetComponent<Life>().Amount < 50){
			potencia = 2;
			turrent1.GetComponent<EnemyShoot>().FireRate = 0.25f;
			turrent2.GetComponent<EnemyShoot>().FireRate = 0.25f;
			turrent3.GetComponent<EnemyShoot>().FireRate = 0.25f;
		}
		if (gameObject.GetComponent<Life>().Amount < 30){
			potencia = 3;
			turrent1.GetComponent<EnemyShoot>().FireRate = 0.15f;
			turrent2.GetComponent<EnemyShoot>().FireRate = 0.15f;
			turrent3.GetComponent<EnemyShoot>().FireRate = 0.15f;
		}

		/*movimiento*/
		if (transform.position.x >= 3) cambie = true;
		if (transform.position.x <= -3) cambie = false;
		if (!cambie)
			transform.Translate(potencia * speed * Time.deltaTime, 0, 0);
		if (cambie)
			transform.Translate(-speed * Time.deltaTime * potencia, 0, 0);
	}
}
