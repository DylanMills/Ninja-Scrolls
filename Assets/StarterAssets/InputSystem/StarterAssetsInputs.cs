using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

		[Header("Scroll")]
		public float scrollValue = 0.0f;
        [Header("Load Weapon")]
        public bool loadWeapon;


#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED


        public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if (cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}
#endif
		public void OnScroll(InputValue value)
		{
			ScrollInput(value.Get<float>());
		}

		public void OnLoadWeapon(InputValue value)
		{
            LoadWeaponInput(value.isPressed);
        }
		
        public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		}

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}
		public void ScrollInput(float newScrollValue)
		{
				if (newScrollValue<-2 ||newScrollValue>2)

            {
			scrollValue = newScrollValue;
			}
			else
			{
				scrollValue = 0 ;
			}
		}

        public void LoadWeaponInput(bool newLoadWeaponState)
        {
            loadWeapon = newLoadWeaponState;
        }
        private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}

}