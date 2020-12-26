// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Animal"",
            ""id"": ""89e24d2b-54ab-46c3-a7ce-c6ba0d4bbe2e"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fae0246f-de42-478b-9954-0a2a393615a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveZ"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ddaa314c-bc82-40cf-b0f5-2196e248b187"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4274de41-b0c6-475e-bf82-9f20ed75a450"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""EjeX"",
                    ""id"": ""1df6af66-1dbb-46b6-8bbe-96489bf08c6a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1bd954cf-03b6-4821-b167-fb50d143390b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""13261cef-b4ac-4456-b879-7c2826413d6f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""57758fa2-dd0c-48fd-b72d-1bf345602379"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""EjeY"",
                    ""id"": ""025687f7-e5d5-4281-a340-7750ec53dfd7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""14ed81b4-b513-4953-b66f-e495883c7cce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1e913f93-19f0-44ee-923b-f3dfd2be4e4f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Fruta"",
            ""id"": ""ce93a973-dfa7-4677-802e-135362f70d02"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""460a72ac-07ba-47ae-b461-8a0a41d31660"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveZ"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9b6d8d88-c961-4697-b12f-a878bdda3d56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""91e4a68d-f046-454f-84a5-8cd231717223"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""EjeX"",
                    ""id"": ""9a8a6f6b-82e1-4cb3-a1ac-57990765166f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4ed86754-a68c-401d-b266-3d1775eb84e4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""96b55140-5440-4953-94c3-fa89a9c44f48"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""EjeY"",
                    ""id"": ""7cc2934f-74a5-4df0-ba93-70a9368a6260"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1c8f3638-4b27-4561-a493-ba3bbec224fc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e5577a64-1345-4db0-8970-5553f2b3a951"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bbf18fa4-3ae6-4bd8-a52f-1d5bfdcd3170"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Animal
        m_Animal = asset.FindActionMap("Animal", throwIfNotFound: true);
        m_Animal_MoveX = m_Animal.FindAction("MoveX", throwIfNotFound: true);
        m_Animal_MoveZ = m_Animal.FindAction("MoveZ", throwIfNotFound: true);
        m_Animal_Jump = m_Animal.FindAction("Jump", throwIfNotFound: true);
        // Fruta
        m_Fruta = asset.FindActionMap("Fruta", throwIfNotFound: true);
        m_Fruta_MoveX = m_Fruta.FindAction("MoveX", throwIfNotFound: true);
        m_Fruta_MoveZ = m_Fruta.FindAction("MoveZ", throwIfNotFound: true);
        m_Fruta_Jump = m_Fruta.FindAction("Jump", throwIfNotFound: true);
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

    // Animal
    private readonly InputActionMap m_Animal;
    private IAnimalActions m_AnimalActionsCallbackInterface;
    private readonly InputAction m_Animal_MoveX;
    private readonly InputAction m_Animal_MoveZ;
    private readonly InputAction m_Animal_Jump;
    public struct AnimalActions
    {
        private @PlayerControl m_Wrapper;
        public AnimalActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Animal_MoveX;
        public InputAction @MoveZ => m_Wrapper.m_Animal_MoveZ;
        public InputAction @Jump => m_Wrapper.m_Animal_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Animal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AnimalActions set) { return set.Get(); }
        public void SetCallbacks(IAnimalActions instance)
        {
            if (m_Wrapper.m_AnimalActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_AnimalActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_AnimalActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_AnimalActionsCallbackInterface.OnMoveX;
                @MoveZ.started -= m_Wrapper.m_AnimalActionsCallbackInterface.OnMoveZ;
                @MoveZ.performed -= m_Wrapper.m_AnimalActionsCallbackInterface.OnMoveZ;
                @MoveZ.canceled -= m_Wrapper.m_AnimalActionsCallbackInterface.OnMoveZ;
                @Jump.started -= m_Wrapper.m_AnimalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_AnimalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_AnimalActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_AnimalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveZ.started += instance.OnMoveZ;
                @MoveZ.performed += instance.OnMoveZ;
                @MoveZ.canceled += instance.OnMoveZ;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public AnimalActions @Animal => new AnimalActions(this);

    // Fruta
    private readonly InputActionMap m_Fruta;
    private IFrutaActions m_FrutaActionsCallbackInterface;
    private readonly InputAction m_Fruta_MoveX;
    private readonly InputAction m_Fruta_MoveZ;
    private readonly InputAction m_Fruta_Jump;
    public struct FrutaActions
    {
        private @PlayerControl m_Wrapper;
        public FrutaActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Fruta_MoveX;
        public InputAction @MoveZ => m_Wrapper.m_Fruta_MoveZ;
        public InputAction @Jump => m_Wrapper.m_Fruta_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Fruta; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FrutaActions set) { return set.Get(); }
        public void SetCallbacks(IFrutaActions instance)
        {
            if (m_Wrapper.m_FrutaActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_FrutaActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_FrutaActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_FrutaActionsCallbackInterface.OnMoveX;
                @MoveZ.started -= m_Wrapper.m_FrutaActionsCallbackInterface.OnMoveZ;
                @MoveZ.performed -= m_Wrapper.m_FrutaActionsCallbackInterface.OnMoveZ;
                @MoveZ.canceled -= m_Wrapper.m_FrutaActionsCallbackInterface.OnMoveZ;
                @Jump.started -= m_Wrapper.m_FrutaActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FrutaActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FrutaActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_FrutaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveZ.started += instance.OnMoveZ;
                @MoveZ.performed += instance.OnMoveZ;
                @MoveZ.canceled += instance.OnMoveZ;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public FrutaActions @Fruta => new FrutaActions(this);
    public interface IAnimalActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveZ(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IFrutaActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveZ(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
