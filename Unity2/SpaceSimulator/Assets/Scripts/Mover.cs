using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{

	[SerializeField]
	private float _MoveXEvery = 0.25f;

	[SerializeField]
	private float _MovementX = 0.1f;

	[SerializeField]
	private float _MoveYEvery = 4f;

	[SerializeField]
	private float _MovementY = 0.5f;


	private float _HorizontalSign = 1f;



	private void Start()
	{
		StartCoroutine(HorizontalMover());
		StartCoroutine(VerticalMover());
	}

	IEnumerator HorizontalMover()
	{
		while(true)
		{
			yield return new WaitForSeconds(_MoveXEvery);
			Vector3 v3 = transform.position;
			v3.x += _HorizontalSign * _MovementX;
			transform.position = v3;
		}
	}

	IEnumerator VerticalMover()
	{
		while(true)
		{
			yield return new WaitForSeconds(_MoveYEvery);
			Vector3 v3 = transform.position;
			v3.y -= _MovementY;
			transform.position = v3;
			_HorizontalSign *= -1;
		}
	}

}
