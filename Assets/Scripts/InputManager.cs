// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
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
        }
    ]
}");
        // PlagueDoctor
        m_PlagueDoctor = asset.FindActionMap("PlagueDoctor", throwIfNotFound: true);
        m_PlagueDoctor_Movement = m_PlagueDoctor.FindAction("Movement", throwIfNotFound: true);
        // Rat
        m_Rat = asset.FindActionMap("Rat", throwIfNotFound: true);
        m_Rat_Movement = m_Rat.FindAction("Movement", throwIfNotFound: true);
    }

    public void Dispose()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

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

    // PlagueDoctor
    private readonly InputActionMap m_PlagueDoctor;
    private IPlagueDoctorActions m_PlagueDoctorActionsCallbackInterface;
    private readonly InputAction m_PlagueDoctor_Movement;
    public struct PlagueDoctorActions
    {
        private @InputManager m_Wrapper;
        public PlagueDoctorActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlagueDoctor_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlagueDoctor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlagueDoctorActions set) { return set.Get(); }
        public void SetCallbacks(IPlagueDoctorActions instance)
        {
            if (m_Wrapper.m_PlagueDoctorActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlagueDoctorActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlagueDoctorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlagueDoctorActions @PlagueDoctor => new PlagueDoctorActions(this);

    // Rat
    private readonly InputActionMap m_Rat;
    private IRatActions m_RatActionsCallbackInterface;
    private readonly InputAction m_Rat_Movement;
    public struct RatActions
    {
        private @InputManager m_Wrapper;
        public RatActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Rat_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Rat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RatActions set) { return set.Get(); }
        public void SetCallbacks(IRatActions instance)
        {
            if (m_Wrapper.m_RatActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_RatActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_RatActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_RatActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_RatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public RatActions @Rat => new RatActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlagueDoctorActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IRatActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
