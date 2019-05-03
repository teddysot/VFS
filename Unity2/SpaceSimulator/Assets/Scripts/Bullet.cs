using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{

	[SerializeField]
	private float _BulletSpeed = 5f;

	private void Start()
	{
		GetComponent<Rigidbody>().velocity = Vector3.up * _BulletSpeed;
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
