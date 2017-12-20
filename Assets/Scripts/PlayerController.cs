using UnityEngine;

namespace Assets.Scripts
{
	[RequireComponent(typeof(Rigidbody2D))]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(BoxCollider2D))]
	public class PlayerController : MonoBehaviour
	{

		public float Speed=4.0f;

		/// <summary>
		/// This is the variable we will pass into the calculate movement function
		/// </summary>
		[SerializeField]
		private Vector2 _vector2Force;

		private Rigidbody2D _rigidbody2;

		private Animator _animator;

		private BoxCollider2D _boxCollider2D;

		private Vector2 _lastDirection;

		private bool _isMoving;

		void Awake()
		{
			//
			_animator = GetComponent<Animator>();
			_rigidbody2 = GetComponent<Rigidbody2D>();
			_boxCollider2D = GetComponent<BoxCollider2D>();

		}
		// Use this for initialization
		void Start ()
		{   //not to forget default setting.
			_rigidbody2.gravityScale = 0;
			_rigidbody2.constraints = RigidbodyConstraints2D.FreezeRotation;
		}
	
		// Update is called once per frame
		void Update ()
		{
			CheckInput();
		}


		void CheckInput()
		{
			_isMoving = false;

			var x = Input.GetAxisRaw("Horizontal");
			var y = Input.GetAxisRaw("Vertical");
			if (x < 0 || x > 0 || y < 0 || y > 0)
			{
				_isMoving = true;
				if (!_boxCollider2D.IsTouchingLayers(Physics2D.AllLayers))
				{
					_lastDirection = _rigidbody2.velocity;
				}
				
			}
			//Avoid diagonal movement
			if (Mathf.Abs(x) >= Mathf.Abs(y))
			{
				y = 0;
			}
			else if (Mathf.Abs(x) <= Mathf.Abs(y))
			{
				x = 0;
			}
			_vector2Force = new Vector2(x, y);
			CalculateMovement(_vector2Force*Speed);

		}

		void CalculateMovement(Vector2 playerForce)
		{
			_rigidbody2.velocity=Vector2.zero;
			_rigidbody2.AddForce(playerForce,ForceMode2D.Impulse);
			SendAnimInfo();
		}

		void SendAnimInfo()
		{
			_animator.SetFloat("XSpeed",_rigidbody2.velocity.x);
			_animator.SetFloat("YSpeed", _rigidbody2.velocity.y);
			_animator.SetFloat("LastX", _lastDirection.x);
			_animator.SetFloat("LastY", _lastDirection.y);
			_animator.SetBool("IsMoving",_isMoving);
		}
	}
}
