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
                    ""name"": ""Rotate"",
                    ""id"": ""4f0d2e9a-eb52-4b06-9509-e06856e3375b"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": true,
                    ""initialStateCheck"": false,
                    ""processors"": """",
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
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4132d978-c0ee-4fdc-89a6-6d799a355f4b"",
                    ""path"": ""<XInputController>/buttonSouth"",
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
                }
            ]
        },
        {
            ""name"": ""Vehicle"",
            ""id"": ""f1926770-9983-402f-bcf2-d7d16a49eccc"",
            ""actions"": [
                {
                    ""name"": ""Brake"",
                    ""id"": ""dda2cba7-be99-4df2-8873-1e53201846d0"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Accelerate"",
                    ""id"": ""1b4da591-03ae-473f-98f2-05c45d6da50c"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""bindings"": []
                },
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
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""d4767880-d584-4f52-8dff-d3ee91d9ed54"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""id"": ""6a7df02f-782e-48b2-b4e3-5bfa2ec2d9ed"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8a480c88-3bd6-4870-a2f6-f1f8ece91e28"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
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
        m_Character_Run = m_Character.GetAction("Run");
        m_Character_Rotate = m_Character.GetAction("Rotate");
        m_Character_Move = m_Character.GetAction("Move");
        // Vehicle
        m_Vehicle = asset.GetActionMap("Vehicle");
        m_Vehicle_Brake = m_Vehicle.GetAction("Brake");
        m_Vehicle_Accelerate = m_Vehicle.GetAction("Accelerate");
        m_Vehicle_Steer = m_Vehicle.GetAction("Steer");
        m_Vehicle_HandBrake = m_Vehicle.GetAction("HandBrake");
        m_Vehicle_Boost = m_Vehicle.GetAction("Boost");
        // Menu
        m_Menu = asset.GetActionMap("Menu");
        m_Menu_Newaction = m_Menu.GetAction("New action");
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
    private InputAction m_Character_Run;
    private InputAction m_Character_Rotate;
    private InputAction m_Character_Move;
    public struct CharacterActions
    {
        private InputControls m_Wrapper;
        public CharacterActions(InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot { get { return m_Wrapper.m_Character_Shoot; } }
        public InputAction @Run { get { return m_Wrapper.m_Character_Run; } }
        public InputAction @Rotate { get { return m_Wrapper.m_Character_Rotate; } }
        public InputAction @Move { get { return m_Wrapper.m_Character_Move; } }
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
                Run.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                Run.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                Run.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                Rotate.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                Rotate.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                Move.cancelled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.cancelled += instance.OnShoot;
                Run.started += instance.OnRun;
                Run.performed += instance.OnRun;
                Run.cancelled += instance.OnRun;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.cancelled += instance.OnRotate;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.cancelled += instance.OnMove;
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
    private InputAction m_Vehicle_Brake;
    private InputAction m_Vehicle_Accelerate;
    private InputAction m_Vehicle_Steer;
    private InputAction m_Vehicle_HandBrake;
    private InputAction m_Vehicle_Boost;
    public struct VehicleActions
    {
        private InputControls m_Wrapper;
        public VehicleActions(InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Brake { get { return m_Wrapper.m_Vehicle_Brake; } }
        public InputAction @Accelerate { get { return m_Wrapper.m_Vehicle_Accelerate; } }
        public InputAction @Steer { get { return m_Wrapper.m_Vehicle_Steer; } }
        public InputAction @HandBrake { get { return m_Wrapper.m_Vehicle_HandBrake; } }
        public InputAction @Boost { get { return m_Wrapper.m_Vehicle_Boost; } }
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
                Brake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                Brake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                Brake.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                Accelerate.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnAccelerate;
                Accelerate.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnAccelerate;
                Accelerate.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnAccelerate;
                Steer.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteer;
                Steer.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteer;
                Steer.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteer;
                HandBrake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandBrake;
                HandBrake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandBrake;
                HandBrake.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandBrake;
                Boost.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBoost;
                Boost.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBoost;
                Boost.cancelled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBoost;
            }
            m_Wrapper.m_VehicleActionsCallbackInterface = instance;
            if (instance != null)
            {
                Brake.started += instance.OnBrake;
                Brake.performed += instance.OnBrake;
                Brake.cancelled += instance.OnBrake;
                Accelerate.started += instance.OnAccelerate;
                Accelerate.performed += instance.OnAccelerate;
                Accelerate.cancelled += instance.OnAccelerate;
                Steer.started += instance.OnSteer;
                Steer.performed += instance.OnSteer;
                Steer.cancelled += instance.OnSteer;
                HandBrake.started += instance.OnHandBrake;
                HandBrake.performed += instance.OnHandBrake;
                HandBrake.cancelled += instance.OnHandBrake;
                Boost.started += instance.OnBoost;
                Boost.performed += instance.OnBoost;
                Boost.cancelled += instance.OnBoost;
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
    // Menu
    private InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private InputControls m_Wrapper;
        public MenuActions(InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction { get { return m_Wrapper.m_Menu_Newaction; } }
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                Newaction.cancelled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                Newaction.started += instance.OnNewaction;
                Newaction.performed += instance.OnNewaction;
                Newaction.cancelled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu
    {
        get
        {
            return new MenuActions(this);
        }
    }
    public interface ICharacterActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IVehicleActions
    {
        void OnBrake(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnHandBrake(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
