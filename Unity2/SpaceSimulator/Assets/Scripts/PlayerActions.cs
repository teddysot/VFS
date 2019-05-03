using UnityEngine;

public class PlayerActions : MonoBehaviour
{

	[SerializeField]
	private Bullet _BulletPrefab;

	public void MoveLeft(float howMuch)
	{
		transform.position += Vector3.left * howMuch;
	}

	public void MoveRight(float howMuch)
	{
		transform.position += Vector3.right * howMuch;
	}

	public void MoveUp(float howMuch)
	{
		transform.position += Vector3.up * howMuch;
	}

	public void MoveDown(float howMuch)
	{
		transform.position += Vector3.down * howMuch;
	}

	public void ShootBullet(float yOffset)
	{
		Instantiate(_BulletPrefab, transform.position + (Vector3.up * yOffset), Quaternion.identity);
	}

}
