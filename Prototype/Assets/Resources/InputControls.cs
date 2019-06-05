// GENERATED AUTOMATICALLY FROM 'Assets/Resources/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

public class InputControls : IInputActionCollection
{
    private InputActionAsset asset;
    public InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""c7801155-5f2a-4b68-ae89-7570c76be468"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""id"": ""14b151f2-aa05-439a-8187-2a029a4bd054"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Interact"",
                    ""id"": ""ffb02823-b5b9-4521-b94c-199f1df28bdf"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Run"",
                    ""id"": ""d8b13608-c6ee-4103-bec8-99c93d4245a6"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Reload"",
                    ""id"": ""6868c369-7348-4ae5-a6df-e2b7fa6f3597"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Rotate"",
                    ""id"": ""4f0d2e9a-eb52-4b06-9509-e06856e3375b"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": true,
                    ""initialStateCheck"": false,
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Move"",
                    ""id"": ""d8f88bcb-33d7-47e0-89fb-6647305e382c"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""PrevWeapon"",
                    ""id"": ""5ed79789-4a83-4007-b8ea-653f9b62c357"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""bindings"": []
                },
                {
                    ""name"": ""NextWeapon"",
                    ""id"": ""543d55d4-9a3e-42aa-900d-0b715cb676eb"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""bindings"": []
                },
                {
                    ""name"": ""PrevItem"",
                    ""id"": ""436eefde-a568-4f10-b4f2-82b51a797f43"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""NextItem"",
                    ""id"": ""b2e8d7e5-1e68-4b33-b5f8-979ebec469e5"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                },
                {
                    ""name"": ""UseItem"",
                    ""id"": ""38ceaf71-d7f1-4c11-9178-120ae4854e0a"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4132d978-c0ee-4fdc-89a6-6d799a355f4b"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""e9222cd4-c608-45c7-9c17-0b86b0b989e7"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ced2d949-a950-4f73-afbb-c3493e0b1f0d"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""fcadf10f-bc9f-4da0-86d2-a6a4c0371877"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""844b1f14-a4b4-46dd-ba0a-3a3a1990c1be"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""5c36be74-4dd0-4a93-b604-edcd2dd34690"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrevWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""380bafa3-b395-458f-9660-472fdc1f3571"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ddc43fa0-1c78-4117-8d95-411c6ef0a9ce"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d42a9ad7-f583-4606-b73e-b8c5f8388491"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrevItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8a85773a-5425-4b52-a373-c843f46b7519"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""f8c25e22-8a7e-4348-b6b2-cb781606fb0b"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Vehicle"",
            ""id"": ""f1926770-9983-402f-bcf2-d7d16a49eccc"",
            ""actions"": [
                {
                    ""name"": ""Steer"",
                    ""id"": ""ee6cd4a9-14ab-4b3f-b126-ab731e2ae8d9"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""HandBrake"",
                    ""id"": ""eae8754f-28c8-422d-9b32-8e4ae19bc59b"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Boost"",
                    ""id"": ""7dca7720-cfbb-4ed0-a043-0a2f9d0a5b3b"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""bindings"": []
                },
                {
                    ""name"": ""Interact"",
                    ""id"": ""2892d7b9-5c9b-4beb-9161-1258984e495f"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c967c5e-f7f4-4e1e-95fc-df4f174a9f43"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""d8bbb218-e843-4f2e-84b8-fc4f5c06d5ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""00d1ec81-e425-4fc0-a056-e6d346f68ff2"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7f97fac5-f56b-4695-9176-85a255524a6a"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a76bc69-7ba4-4d40-a2f7-00a20e61a6df"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""84d9355f-d054-453b-908a-60520feb9103"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""67d80a65-0670-46c4-9bd5-43eede996fe1"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d4e7bbd1-f954-46ff-8d6c-104cad2204c8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""8e2f464d-44c2-418c-9349-91ad7aa3bb56"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""id"": ""2d9b07f5-a173-4701-afba-ff62a0575c6e"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a563f6b7-4ad2-4867-a31d-0c243f7388ba"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.GetActionMap("Character");
        m_Character_Shoot = m_Character.GetAction("Shoot");
        m_Character_Interact = m_Character.GetAction("Interact");
        m_Character_Run = m_Character.GetAction("Run");
        m_Character_Reload = m_Character.GetAction("Reload");
        m_Character_Rotate = m_Character.GetAction("Rotate");
        m_Character_Move = m_Character.GetAction("Move");
        m_Character_PrevWeapon = m_Character.GetAction("PrevWeapon");
        m_Character_NextWeapon = m_Character.GetAction("NextWeapon");
        m_Character_PrevItem = m_Character.GetAction("PrevItem");
        m_Character_NextItem = m_Character.GetAction("NextItem");
        m_Character_UseItem = m_Character.GetAction("UseItem");
        // Vehicle
        m_Vehicle = asset.GetActionMap("Vehicle");
        m_Vehicle_Steer = m_Vehicle.GetAction("Steer");
        m_Vehicle_HandBrake = m_Vehicle.GetAction("HandBrake");
        m_Vehicle_Boost = m_Vehicle.GetAction("Boost");
        m_Vehicle_Interact = m_Vehicle.GetAction("Interact");
        // Camera
        m_Camera = asset.GetActionMap("Camera");
        m_Camera_Rotate = m_Camera.GetAction("Rotate");
    }
    ~InputControls()
    {
        UnityEngine.Object.Destroy(asset);
    }
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }
    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Enable()
    {
        asset.Enable();
    }
    public void Disable()
    {
        asset.Disable();
    }
    // Character
    private InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private InputAction m_Character_Shoot;
    private InputAction m_Character_Interact;
    private InputAction m_Character_Run;
    private InputAction m_Character_Reload;
    private InputAction m_Character_Rotate;
    private InputAction m_Character_Move;
    private InputAction m_Character_PrevWeapon;
    private InputAction m_Character_NextWeapon;
    private InputAction m_Character_PrevItem;
    private InputAction m_Character_NextItem;
    private InputAction m_Character_UseItem;
    public struct CharacterActions
    {
        private InputControls m_Wrapper;
        public CharacterActions(InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot { get { return m_Wrapper.m_Character_Shoot; } }
        public InputAction @Interact { get { return m_Wrapper.m_Character_Interact; } }
        public InputAction @Run { get { return m_Wrapper.m_Character_Run; } }
        public InputAction @Reload { get { return m_Wrapper.m_Character_Reload; } }
        public InputAction @Rotate { get { return m_Wrapper.m_Character_Rotate; } }
        public InputAction @Move { get { return m_Wrapper.m_Character_Move; } }
        public InputAction @PrevWeapon { get { return m_Wrapper.m_Character_PrevWeapon; } }
        public InputAction @NextWeapon { get { return m_Wrapper.m_Character_NextWeapon; } }
        public InputAction @PrevItem { get { return m_Wrapper.m_Character_PrevItem; } }
        public InputAction @NextItem { get { return m_Wrapper.m_Character_NextItem; } }
        public InputAction @UseItem { get { return m_Wrapper.m_Character_UseItem; } }
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                Shoot.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnShoot;
                Shoot.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnShoot;
                Interact.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                Interact.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                Run.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                Run.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                Run.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                Reload.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnReload;
                Reload.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnReload;
                Reload.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnReload;
                Rotate.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                Rotate.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                Move.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                PrevWeapon.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPrevWeapon;
                PrevWeapon.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPrevWeapon;
                PrevWeapon.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPrevWeapon;
                NextWeapon.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNextWeapon;
                NextWeapon.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNextWeapon;
                NextWeapon.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNextWeapon;
                PrevItem.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPrevItem;
                PrevItem.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPrevItem;
                PrevItem.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPrevItem;
                NextItem.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNextItem;
                NextItem.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNextItem;
                NextItem.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNextItem;
                UseItem.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnUseItem;
                UseItem.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnUseItem;
                UseItem.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnUseItem;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.cancelled += instance.OnShoot;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.cancelled += instance.OnInteract;
                Run.started += instance.OnRun;
                Run.performed += instance.OnRun;
                Run.cancelled += instance.OnRun;
                Reload.started += instance.OnReload;
                Reload.performed += instance.OnReload;
                Reload.cancelled += instance.OnReload;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.cancelled += instance.OnRotate;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.cancelled += instance.OnMove;
                PrevWeapon.started += instance.OnPrevWeapon;
                PrevWeapon.performed += instance.OnPrevWeapon;
                PrevWeapon.cancelled += instance.OnPrevWeapon;
                NextWeapon.started += instance.OnNextWeapon;
                NextWeapon.performed += instance.OnNextWeapon;
                NextWeapon.cancelled += instance.OnNextWeapon;
                PrevItem.started += instance.OnPrevItem;
                PrevItem.performed += instance.OnPrevItem;
                PrevItem.cancelled += instance.OnPrevItem;
                NextItem.started += instance.OnNextItem;
                NextItem.performed += instance.OnNextItem;
                NextItem.cancelled += instance.OnNextItem;
                UseItem.started += instance.OnUseItem;
                UseItem.performed += instance.OnUseItem;
                UseItem.cancelled += instance.OnUseItem;
            }
        }
    }
    public CharacterActions @Character
    {
        get
        {
            return new CharacterActions(this);
        }
    }
    // Vehicle
    private InputActionMap m_Vehicle;
    private IVehicleActions m_VehicleActionsCallbackInterface;
    private InputAction m_Vehicle_Steer;
    private InputAction m_Vehicle_HandBrake;
    private InputAction m_Vehicle_Boost;
    private InputAction m_Vehicle_Interact;
    public struct VehicleActions
    {
        private InputControls m_Wrapper;
        public VehicleActions(InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steer { get { return m_Wrapper.m_Vehicle_Steer; } }
        public InputAction @HandBrake { get { return m_Wrapper.m_Vehicle_HandBrake; } }
        public InputAction @Boost { get { return m_Wrapper.m_Vehicle_Boost; } }
        public InputAction @Interact { get { return m_Wrapper.m_Vehicle_Interact; } }
        public InputActionMap Get() { return m_Wrapper.m_Vehicle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(VehicleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleActions instance)
        {
            if (m_Wrapper.m_VehicleActionsCallbackInterface != null)
            {
                Steer.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteer;
                Steer.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteer;
                Steer.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteer;
                HandBrake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandBrake;
                HandBrake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandBrake;
                HandBrake.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandBrake;
                Boost.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBoost;
                Boost.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBoost;
                Boost.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBoost;
                Interact.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnInteract;
                Interact.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_VehicleActionsCallbackInterface = instance;
            if (instance != null)
            {
                Steer.started += instance.OnSteer;
                Steer.performed += instance.OnSteer;
                Steer.cancelled += instance.OnSteer;
                HandBrake.started += instance.OnHandBrake;
                HandBrake.performed += instance.OnHandBrake;
                HandBrake.cancelled += instance.OnHandBrake;
                Boost.started += instance.OnBoost;
                Boost.performed += instance.OnBoost;
                Boost.cancelled += instance.OnBoost;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.cancelled += instance.OnInteract;
            }
        }
    }
    public VehicleActions @Vehicle
    {
        get
        {
            return new VehicleActions(this);
        }
    }
    // Camera
    private InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private InputAction m_Camera_Rotate;
    public struct CameraActions
    {
        private InputControls m_Wrapper;
        public CameraActions(InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate { get { return m_Wrapper.m_Camera_Rotate; } }
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                Rotate.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                Rotate.cancelled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.cancelled += instance.OnRotate;
            }
        }
    }
    public CameraActions @Camera
    {
        get
        {
            return new CameraActions(this);
        }
    }
    public interface ICharacterActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnPrevWeapon(InputAction.CallbackContext context);
        void OnNextWeapon(InputAction.CallbackContext context);
        void OnPrevItem(InputAction.CallbackContext context);
        void OnNextItem(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
    }
    public interface IVehicleActions
    {
        void OnSteer(InputAction.CallbackContext context);
        void OnHandBrake(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnRotate(InputAction.CallbackContext context);
    }
}
