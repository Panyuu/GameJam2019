// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Movement/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    private InputActionAsset _asset;
    public @InputManager()
    {
        _asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""PlagueDoctor"",
            ""id"": ""4cf13a1d-1c6c-43e3-bb63-615e0dfb30ec"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a2d11aa-4c6c-42c1-b4db-d5439e7d298b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUpObject"",
                    ""type"": ""Button"",
                    ""id"": ""f611fcd1-c66c-4fe0-9f08-9cd4628c94e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CrowMode"",
                    ""type"": ""Button"",
                    ""id"": ""07acfcc9-5c4f-4c5c-82ea-5b162f63f178"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowControls"",
                    ""type"": ""Button"",
                    ""id"": ""1fc8a895-0941-489a-98fe-3cdf77d28bf4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""36d4d896-6f85-4814-aa00-e6d11fdd6197"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5614e4ac-c8fb-4052-8257-bd21ea3be3e2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d90e15f8-5ed9-47a0-a752-b66f4ae12f9d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2cdbc78d-83f5-490b-ad2b-6b48d56a05be"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e4199708-cebc-4924-9054-d86cca93bee9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""7cf3a6d4-b742-411f-ac7d-3216c860c15d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3eab0f19-c7e2-48e5-ac10-6b8512face8b"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a63b24a3-04fa-4dab-8937-47e64393ae71"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8536414a-0e46-4cca-aeb5-5914c0ab20ec"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""759cc66f-649d-4d6b-9a01-e7fda0ab2d75"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""08c8dcb0-eee4-41b0-8710-2372db38ae4d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickUpObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b18a9e7d-d725-48bc-8ed0-6c143a4a034a"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""PickUpObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a78bdf2e-b902-498d-897b-25f41f10056b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CrowMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba0b382e-8824-4ad1-89bc-d7c6a399c7cb"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CrowMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ddabb74-d437-4b3f-b003-c3650661f0ab"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ShowControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Rat"",
            ""id"": ""6a96c63a-4422-4db9-9355-19add82889dc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d50c3e33-b49f-4ae0-9eaa-5bedb78f5768"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""c95f0de5-9a31-4c80-8d5c-ccb28337ceeb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowControls"",
                    ""type"": ""Button"",
                    ""id"": ""d45e6249-746c-4058-8368-0af5a6b17b07"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""d4a9a4d8-2c43-4a71-b0c4-be7f54eafd1e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9f4c3aa3-ee10-476b-b54e-4ec4c6e29b97"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""495f1535-3c71-49f2-8ca8-7d0b3f077830"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""68b135c9-5f71-4d13-a5a6-bcd47ba12e3c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e64d122f-2549-4be0-98ac-cf2c6dafca3c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""864f6deb-4818-41f2-a79d-17af45420dae"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ba496968-835d-4fc7-8118-b7d20dde9c69"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""175b6d86-0c65-4d39-a015-04afaec224a4"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2cea2eef-382c-44f9-8cd3-80d9d3ad53c5"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bcaf5a8c-5acd-4e84-b7e8-8b6550d053d3"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2ecf49a7-46d6-4325-ac1b-17ef3368ad7c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da8e5107-962e-414b-bf0a-2bf7a3cfad65"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b12462a-fc11-466f-8c78-9d0553bb030a"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ShowControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""44f664d1-6592-4c0b-8253-53a4f2881445"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""7ea677ad-b7bf-4462-8906-4f89e5c3a700"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""e5d1c55b-f7b8-4e76-a0e8-723bf6b4b7cd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f7e0038f-fdb9-40b4-af2d-40d1d56fb1db"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52eb254a-0ae1-46a7-a622-aa34eb0fc201"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlagueDoctor
        _mPlagueDoctor = _asset.FindActionMap("PlagueDoctor", throwIfNotFound: true);
        _mPlagueDoctorMovement = _mPlagueDoctor.FindAction("Movement", throwIfNotFound: true);
        _mPlagueDoctorPickUpObject = _mPlagueDoctor.FindAction("PickUpObject", throwIfNotFound: true);
        _mPlagueDoctorCrowMode = _mPlagueDoctor.FindAction("CrowMode", throwIfNotFound: true);
        _mPlagueDoctorShowControls = _mPlagueDoctor.FindAction("ShowControls", throwIfNotFound: true);
        // Rat
        _mRat = _asset.FindActionMap("Rat", throwIfNotFound: true);
        _mRatMovement = _mRat.FindAction("Movement", throwIfNotFound: true);
        _mRatDash = _mRat.FindAction("Dash", throwIfNotFound: true);
        _mRatShowControls = _mRat.FindAction("ShowControls", throwIfNotFound: true);
        // Menu
        _mMenu = _asset.FindActionMap("Menu", throwIfNotFound: true);
        _mMenuStart = _mMenu.FindAction("Start", throwIfNotFound: true);
        _mMenuQuit = _mMenu.FindAction("Quit", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(_asset);
    }

    public InputBinding? bindingMask
    {
        get => _asset.bindingMask;
        set => _asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => _asset.devices;
        set => _asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => _asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return _asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return _asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        _asset.Enable();
    }

    public void Disable()
    {
        _asset.Disable();
    }

    // PlagueDoctor
    private readonly InputActionMap _mPlagueDoctor;
    private IPlagueDoctorActions _mPlagueDoctorActionsCallbackInterface;
    private readonly InputAction _mPlagueDoctorMovement;
    private readonly InputAction _mPlagueDoctorPickUpObject;
    private readonly InputAction _mPlagueDoctorCrowMode;
    private readonly InputAction _mPlagueDoctorShowControls;
    public struct PlagueDoctorActions
    {
        private @InputManager _mWrapper;
        public PlagueDoctorActions(@InputManager wrapper) { _mWrapper = wrapper; }
        public InputAction @Movement => _mWrapper._mPlagueDoctorMovement;
        public InputAction @PickUpObject => _mWrapper._mPlagueDoctorPickUpObject;
        public InputAction @CrowMode => _mWrapper._mPlagueDoctorCrowMode;
        public InputAction @ShowControls => _mWrapper._mPlagueDoctorShowControls;
        public InputActionMap Get() { return _mWrapper._mPlagueDoctor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool Enabled => Get().enabled;
        public static implicit operator InputActionMap(PlagueDoctorActions set) { return set.Get(); }
        public void SetCallbacks(IPlagueDoctorActions instance)
        {
            if (_mWrapper._mPlagueDoctorActionsCallbackInterface != null)
            {
                @Movement.started -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnMovement;
                @Movement.performed -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnMovement;
                @Movement.canceled -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnMovement;
                @PickUpObject.started -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnPickUpObject;
                @PickUpObject.performed -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnPickUpObject;
                @PickUpObject.canceled -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnPickUpObject;
                @CrowMode.started -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnCrowMode;
                @CrowMode.performed -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnCrowMode;
                @CrowMode.canceled -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnCrowMode;
                @ShowControls.started -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnShowControls;
                @ShowControls.performed -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnShowControls;
                @ShowControls.canceled -= _mWrapper._mPlagueDoctorActionsCallbackInterface.OnShowControls;
            }
            _mWrapper._mPlagueDoctorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @PickUpObject.started += instance.OnPickUpObject;
                @PickUpObject.performed += instance.OnPickUpObject;
                @PickUpObject.canceled += instance.OnPickUpObject;
                @CrowMode.started += instance.OnCrowMode;
                @CrowMode.performed += instance.OnCrowMode;
                @CrowMode.canceled += instance.OnCrowMode;
                @ShowControls.started += instance.OnShowControls;
                @ShowControls.performed += instance.OnShowControls;
                @ShowControls.canceled += instance.OnShowControls;
            }
        }
    }
    public PlagueDoctorActions @PlagueDoctor => new PlagueDoctorActions(this);

    // Rat
    private readonly InputActionMap _mRat;
    private IRatActions _mRatActionsCallbackInterface;
    private readonly InputAction _mRatMovement;
    private readonly InputAction _mRatDash;
    private readonly InputAction _mRatShowControls;
    public struct RatActions
    {
        private @InputManager _mWrapper;
        public RatActions(@InputManager wrapper) { _mWrapper = wrapper; }
        public InputAction @Movement => _mWrapper._mRatMovement;
        public InputAction @Dash => _mWrapper._mRatDash;
        public InputAction @ShowControls => _mWrapper._mRatShowControls;
        public InputActionMap Get() { return _mWrapper._mRat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool Enabled => Get().enabled;
        public static implicit operator InputActionMap(RatActions set) { return set.Get(); }
        public void SetCallbacks(IRatActions instance)
        {
            if (_mWrapper._mRatActionsCallbackInterface != null)
            {
                @Movement.started -= _mWrapper._mRatActionsCallbackInterface.OnMovement;
                @Movement.performed -= _mWrapper._mRatActionsCallbackInterface.OnMovement;
                @Movement.canceled -= _mWrapper._mRatActionsCallbackInterface.OnMovement;
                @Dash.started -= _mWrapper._mRatActionsCallbackInterface.OnDash;
                @Dash.performed -= _mWrapper._mRatActionsCallbackInterface.OnDash;
                @Dash.canceled -= _mWrapper._mRatActionsCallbackInterface.OnDash;
                @ShowControls.started -= _mWrapper._mRatActionsCallbackInterface.OnShowControls;
                @ShowControls.performed -= _mWrapper._mRatActionsCallbackInterface.OnShowControls;
                @ShowControls.canceled -= _mWrapper._mRatActionsCallbackInterface.OnShowControls;
            }
            _mWrapper._mRatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @ShowControls.started += instance.OnShowControls;
                @ShowControls.performed += instance.OnShowControls;
                @ShowControls.canceled += instance.OnShowControls;
            }
        }
    }
    public RatActions @Rat => new RatActions(this);

    // Menu
    private readonly InputActionMap _mMenu;
    private IMenuActions _mMenuActionsCallbackInterface;
    private readonly InputAction _mMenuStart;
    private readonly InputAction _mMenuQuit;
    public struct MenuActions
    {
        private @InputManager _mWrapper;
        public MenuActions(@InputManager wrapper) { _mWrapper = wrapper; }
        public InputAction @Start => _mWrapper._mMenuStart;
        public InputAction @Quit => _mWrapper._mMenuQuit;
        public InputActionMap Get() { return _mWrapper._mMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool Enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (_mWrapper._mMenuActionsCallbackInterface != null)
            {
                @Start.started -= _mWrapper._mMenuActionsCallbackInterface.OnStart;
                @Start.performed -= _mWrapper._mMenuActionsCallbackInterface.OnStart;
                @Start.canceled -= _mWrapper._mMenuActionsCallbackInterface.OnStart;
                @Quit.started -= _mWrapper._mMenuActionsCallbackInterface.OnQuit;
                @Quit.performed -= _mWrapper._mMenuActionsCallbackInterface.OnQuit;
                @Quit.canceled -= _mWrapper._mMenuActionsCallbackInterface.OnQuit;
            }
            _mWrapper._mMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int _mKeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (_mKeyboardMouseSchemeIndex == -1) _mKeyboardMouseSchemeIndex = _asset.FindControlSchemeIndex("Keyboard & Mouse");
            return _asset.controlSchemes[_mKeyboardMouseSchemeIndex];
        }
    }
    private int _mControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (_mControllerSchemeIndex == -1) _mControllerSchemeIndex = _asset.FindControlSchemeIndex("Controller");
            return _asset.controlSchemes[_mControllerSchemeIndex];
        }
    }
    public interface IPlagueDoctorActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPickUpObject(InputAction.CallbackContext context);
        void OnCrowMode(InputAction.CallbackContext context);
        void OnShowControls(InputAction.CallbackContext context);
    }
    public interface IRatActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnShowControls(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnStart(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
    }
}
