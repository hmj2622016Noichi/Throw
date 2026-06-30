using UnityEngine;

public class Spear : MonoBehaviour
{
	public float speed = 10f;

	void Update()
	{
		transform.position += Vector3.right * speed * Time.deltaTime;

		if (transform.position.x >= 12f)
		{
			Destroy(gameObject);
		}
	}
	public class Zomble : MonoBehaviour
	{
		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Yari"))
			{
				Destroy(gameObject); // ƒ]ƒ“ƒr‚ğÁ‚·

			}
		}
	}
}