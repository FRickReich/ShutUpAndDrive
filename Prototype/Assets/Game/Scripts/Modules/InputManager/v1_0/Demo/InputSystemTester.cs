using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class InputSystemTester : MonoBehaviour
{
    public enum CharacterTestState
    {
        CHARACTER,
        VEHICLE,
        MENU,
        TEST
    }

    public InputMaster controls;
    public CharacterTestState characterTestState;

    private void Awake()
    {
       
    }

    private void OnEnable(){}

	private void OnDisable() => controls.Disable();

	// Start is called before the first frame update
	void Start()
    {
        InputMaster controls = new InputMaster();

        switch(characterTestState)
        {
            case CharacterTestState.CHARACTER:
                controls.Character.Shoot.performed += context => CharacterShoot();
                controls.Character.Reload.performed += context => CharacterReload();
                controls.Character.Interact.performed += context => CharacterInteract();
                controls.Character.Move.performed += context => CharacterMove(context.ReadValue<Vector2>());
                controls.Character.Rotate.performed += context => CharacterRotate(context.ReadValue<Vector2>());
                controls.Character.PrevWeapon.performed += context => CharacterPrevWeapon();
                controls.Character.NextWeapon.performed += context => CharacterGrenade();
                controls.Character.Run.performed += context => CharacterRun();
                controls.Character.Grenade.performed += context => CharacterGrenade();
                controls.Character.Menu.performed += context => CharacterMenu();
                controls.Character.Options.performed += context => CharacterOptions();
                controls.Character.Aim.performed += context => CharacterAim();
                break;
            case CharacterTestState.VEHICLE:
                controls.Vehicle.HandBrake.performed += context => VehicleHandbrake();
                controls.Vehicle.Horn.performed += context => VehicleHorn();
                controls.Vehicle.Lights.performed += context => VehicleLights();
                controls.Vehicle.Exit.performed += context => VehicleExit();
                controls.Vehicle.Steer.performed += context => VehicleSteer(context.ReadValue<Vector2>());
                controls.Vehicle.Aim.performed += context => VehicleAim(context.ReadValue<Vector2>());
                controls.Vehicle.Accelerate.performed += context => VehicleAccelerate(context.ReadValue<float>());
                controls.Vehicle.Brake.performed += context => VehicleBrake(context.ReadValue<float>());
                controls.Vehicle.Menu.performed += context => VehicleMenu();
                controls.Vehicle.Options.performed += context => VehicleOptions();
                controls.Vehicle.Reset.performed += context => VehicleReset();
                break;
            case CharacterTestState.MENU:
                controls.Menu.Accept.performed += context => MenuAccept();
                controls.Menu.Cancel.performed += context => MenuCancel();
                controls.Menu.Cursor.performed += context => MenuCursor(context.ReadValue<Vector2>());
                controls.Menu.Prev.performed += context => MenuPrev();
                controls.Menu.Next.performed += context => MenuNext();
                break;
            default:
            case CharacterTestState.TEST:
                controls.Test.TestChangeState.performed += context => TestChangeState();
                controls.Test.TestContinueState.performed += context => TestContinueState();
                break;
        }

        controls.Enable();
    }

	// CHARACTER INPUT STATE
    void CharacterShoot() => Debug.Log("CHARACTER => SHOOT");
    void CharacterReload() => Debug.Log("CHARACTER => RELOAD");
    void CharacterInteract() => Debug.Log("CHARACTER => INTERACT");
    void CharacterMove(Vector2 direction) => Debug.Log($"CHARACTER => MOVE : {direction.x}/{direction.y}");
    void CharacterRotate(Vector2 direction) => Debug.Log($"CHARACTER => ROTATE : {direction.x}/{direction.y}");
    void CharacterPrevWeapon() => Debug.Log("CHARACTER => PREV WEAPON");
    void CharacterNextWeapon() => Debug.Log("CHARACTER => NEXT WEAPON");
    void CharacterRun() => Debug.Log("CHARACTER => RUN");
    void CharacterGrenade() => Debug.Log("CHARACTER => GRENADE");
    void CharacterMenu() => Debug.Log("CHARACTER => MENU");
    void CharacterOptions() => Debug.Log("CHARACTER => OPTIONS");
    void CharacterAim() => Debug.Log("CHARACTER => AIM");

	// VEHICLE INPUT STATE
    void VehicleHandbrake() => Debug.Log("VEHICLE => HANDBRAKE");
    void VehicleHorn() => Debug.Log("VEHICLE => HORN");
    void VehicleLights() => Debug.Log("VEHICLE => LIGHTS");
    void VehicleExit() => Debug.Log("VEHICLE => EXIT");
    void VehicleSteer(Vector2 direction) => Debug.Log($"VEHICLE => STEER : {direction.x}/{direction.y}");
    void VehicleAim(Vector2 direction) => Debug.Log($"VEHICLE => AIM : {direction.x}/{direction.y}");
    void VehicleAccelerate(float amount) => Debug.Log($"VEHICLE => ACCELERATE : {amount}");
    void VehicleBrake(float amount) => Debug.Log($"VEHICLE => BRAKE : {amount}");
    void VehicleMenu() => Debug.Log("VEHICLE => MENU");
    void VehicleOptions() => Debug.Log("VEHICLE => OPTIONS");
    void VehicleReset() => Debug.Log("VEHICLE => RESET");

	// MENU INPUT STATE
	void MenuAccept() => Debug.Log("MENU => ACCEPT");
	void MenuCancel() => Debug.Log("MENU => CANCEL");
	void MenuCursor(Vector2 direction) => Debug.Log($"MENU => CURSOR : {direction.x}/{direction.y}");
	void MenuPrev() => Debug.Log("MENU => PREV");
	void MenuNext() => Debug.Log("MENU => NEXT");

	// TEST INPUT STATES
	void TestChangeState() => Debug.Log("test");
	void TestContinueState() => Debug.Log("continues...");
}

/*
//controls.Player.Shoot.performed += context => Shoot();
//controls.Player.Move.performed += context => Move(context.ReadValue<Vector2>());

// Update is called once per frame
void Update()
{
    //Keyboard kb = InputSystem.GetDevice<Keyboard>();
    
    //if(kb.spaceKey.wasPressedThisFrame)
    //{
    //    Debug.Log("Someone pressed space...");
    //}
}

void Move(Vector2 direction)
    {
        Debug.Log($"Player wants to move to {direction}");
    }

void Shoot()
{
    Debug.Log("We shot the sheriff!");
}
*/
