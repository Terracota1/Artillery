// GENERATED AUTOMATICALLY FROM 'Assets/_Input/CanonControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CanonControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CanonControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CanonControls"",
    ""maps"": [
        {
            ""name"": ""Canon"",
            ""id"": ""804780fd-03a9-4d3a-883f-7dd016b02f16"",
            ""actions"": [
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""5f793105-b1a4-43ef-b074-dc5ad543da7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""f076fd71-cac9-417e-8199-1c4e4dc6d7ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModificarFuerza"",
                    ""type"": ""Button"",
                    ""id"": ""c7bed04b-ddb1-479a-b3ef-957c598ca6e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""6286f28b-8a74-4276-83a4-110a42f88e87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""175e2033-3e7f-4251-81bd-54c845ade269"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf07ae76-5dd6-4e29-b795-ff9c96629622"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""0360a872-5da4-4fa2-8c7b-0f1b53a4be1d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""36c1fa79-d588-476c-839c-d795b7c5149a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8568de9e-9b7a-4c1a-8f3e-09111482aa33"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""21858405-2f8d-4188-b29c-0e03c08e0d6b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c312251d-b229-4eea-a00b-932d8d81743c"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7982e287-dfc1-4178-8701-1760dda167c5"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""5ecf6936-83a1-4601-ae9e-fe71114a8229"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""65e4c4bd-ddbc-491f-b0b7-e11137c2e511"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""191b5b5b-a3c4-452d-81c9-d1d25b43fd1c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""49e12cb6-e6a6-4908-b86e-f1d62c563745"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""039333f1-cdba-40af-8a45-45c7cb697f81"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f0adf8cc-80a5-4438-8e5d-f347159f2bc3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""131dd747-55a0-49ed-a2f0-f0b7f04c6a22"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b0626b5f-f70e-4c1c-bc42-c6b893de030d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ff72e149-69da-4a16-b5ad-216729529006"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8aac2485-9dd4-46ae-acba-ef549760f534"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9437e7b1-8d27-42b8-aa9d-17ece07c25ca"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Canon
        m_Canon = asset.FindActionMap("Canon", throwIfNotFound: true);
        m_Canon_Apuntar = m_Canon.FindAction("Apuntar", throwIfNotFound: true);
        m_Canon_Disparar = m_Canon.FindAction("Disparar", throwIfNotFound: true);
        m_Canon_ModificarFuerza = m_Canon.FindAction("ModificarFuerza", throwIfNotFound: true);
        m_Canon_Move = m_Canon.FindAction("Move", throwIfNotFound: true);
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

    // Canon
    private readonly InputActionMap m_Canon;
    private ICanonActions m_CanonActionsCallbackInterface;
    private readonly InputAction m_Canon_Apuntar;
    private readonly InputAction m_Canon_Disparar;
    private readonly InputAction m_Canon_ModificarFuerza;
    private readonly InputAction m_Canon_Move;
    public struct CanonActions
    {
        private @CanonControls m_Wrapper;
        public CanonActions(@CanonControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Apuntar => m_Wrapper.m_Canon_Apuntar;
        public InputAction @Disparar => m_Wrapper.m_Canon_Disparar;
        public InputAction @ModificarFuerza => m_Wrapper.m_Canon_ModificarFuerza;
        public InputAction @Move => m_Wrapper.m_Canon_Move;
        public InputActionMap Get() { return m_Wrapper.m_Canon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CanonActions set) { return set.Get(); }
        public void SetCallbacks(ICanonActions instance)
        {
            if (m_Wrapper.m_CanonActionsCallbackInterface != null)
            {
                @Apuntar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Disparar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @ModificarFuerza.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @Move.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CanonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @ModificarFuerza.started += instance.OnModificarFuerza;
                @ModificarFuerza.performed += instance.OnModificarFuerza;
                @ModificarFuerza.canceled += instance.OnModificarFuerza;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CanonActions @Canon => new CanonActions(this);
    public interface ICanonActions
    {
        void OnApuntar(InputAction.CallbackContext context);
        void OnDisparar(InputAction.CallbackContext context);
        void OnModificarFuerza(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
