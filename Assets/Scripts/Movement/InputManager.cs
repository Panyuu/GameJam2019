// ReSharper disable All
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
        m_PlagueDoctor = asset.FindActionMap("PlagueDoctor", throwIfNotFound: true);
        m_PlagueDoctor_Movement = m_PlagueDoctor.FindAction("Movement", throwIfNotFound: true);
        m_PlagueDoctor_PickUpObject = m_PlagueDoctor.FindAction("PickUpObject", throwIfNotFound: true);
        m_PlagueDoctor_CrowMode = m_PlagueDoctor.FindAction("CrowMode", throwIfNotFound: true);
        // Rat
        _mRat = _asset.FindActionMap("Rat", throwIfNotFound: true);
        _mRatMovement = _mRat.FindAction("Movement", throwIfNotFound: true);
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
    private readonly InputActionMap m_PlagueDoctor;
    private IPlagueDoctorActions m_PlagueDoctorActionsCallbackInterface;
    private readonly InputAction m_PlagueDoctor_Movement;
    private readonly InputAction m_PlagueDoctor_PickUpObject;
    private readonly InputAction m_PlagueDoctor_CrowMode;
    public struct PlagueDoctorActions
    {
        private @InputManager m_Wrapper;
        public PlagueDoctorActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlagueDoctor_Movement;
        public InputAction @PickUpObject => m_Wrapper.m_PlagueDoctor_PickUpObject;
        public InputAction @CrowMode => m_Wrapper.m_PlagueDoctor_CrowMode;
        public InputActionMap Get() { return m_Wrapper.m_PlagueDoctor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool Enabled => Get().enabled;
        public static implicit operator InputActionMap(PlagueDoctorActions set) { return set.Get(); }
        public void SetCallbacks(IPlagueDoctorActions instance)
        {
            if (_mWrapper._mPlagueDoctorActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnMovement;
                @PickUpObject.started -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnPickUpObject;
                @PickUpObject.performed -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnPickUpObject;
                @PickUpObject.canceled -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnPickUpObject;
                @CrowMode.started -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnCrowMode;
                @CrowMode.performed -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnCrowMode;
                @CrowMode.canceled -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnCrowMode;
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
            }
        }
    }
    public PlagueDoctorActions @PlagueDoctor => new PlagueDoctorActions(this);

    // Rat
    private readonly InputActionMap _mRat;
    private IRatActions _mRatActionsCallbackInterface;
    private readonly InputAction _mRatMovement;
    public struct RatActions
    {
        private @InputManager _mWrapper;
        public RatActions(@InputManager wrapper) { _mWrapper = wrapper; }
        public InputAction @Movement => _mWrapper._mRatMovement;
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
            }
            _mWrapper._mRatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public RatActions @Rat => new RatActions(this);
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
    }
    public interface IRatActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
