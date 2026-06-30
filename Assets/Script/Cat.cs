using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; //LoadScene‚ð‚Â‚©‚¤

public class CatJump : MonoBehaviour
{
	[SerializeField] float jumpForce = 5f;
	[SerializeField] Rigidbody2D rb;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("death");
	}

	void Update()
	{
		if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}

		if (transform.position.x < -13)
		{
			SceneManager.LoadScene("death");
		}

		if (transform.position.y < -4)
		{
			SceneManager.LoadScene("death");
		}

		if (transform.position.y > 4.7)
		{
			SceneManager.LoadScene("death");
		}
	}
}