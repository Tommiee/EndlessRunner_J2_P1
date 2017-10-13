using UnityEngine;

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if(!jump)
            jump = Input.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            // Pass all parameters to the character control script.
            character.Move(1, false, jump);
            jump = false;
        }
    }