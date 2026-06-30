using UnityEngine;

public class Zomble : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Yari"))
		{
			Destroy(collision.gameObject);
			Destroy(gameObject); // ƒ]ƒ“ƒr‚ğÁ‚·
		}
	}
}