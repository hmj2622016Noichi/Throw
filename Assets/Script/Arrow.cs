using UnityEngine;
using UnityEngine.InputSystem;

public class SpearShooter : MonoBehaviour
{
	public GameObject spearPrefab;
	public Transform firePoint;

	void Update()
	{
		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			
		Instantiate(
	spearPrefab,
	firePoint.position,
	Quaternion.Euler(0, 0, 225)
);
		}
	}
}