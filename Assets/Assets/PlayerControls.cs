// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player mvt"",
            ""id"": ""52771fde-6f52-4c31-83c9-1f3b092f04d2"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0150f521-7a52-4aab-ab26-e27e6944ebdd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""7ce7f909-b65b-4646-983a-2c82c3157a52"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a504c46e-38e3-4ce4-9b2a-6d4bd34fe898"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1271a9bc-483e-4320-8c63-c96e4ec2a1a8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""987dcb2d-749a-4ff1-9ee8-9920bd68e299"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0059546c-fcbd-4da1-87fa-dd636532b9b7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left stick"",
                    ""id"": ""5d03adfa-3f58-4163-b591-e38b300f5bd9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0fc6933b-05c4-48eb-8da3-248e9219025a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5543ff7-466f-4c59-a088-fa39d291c03a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d22662ed-cbc1-4b93-843a-0e912dcd7cd7"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3b454b50-2f64-4bdb-9dc8-e4fbb85c2543"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player mvt
        m_Playermvt = asset.FindActionMap("Player mvt", throwIfNotFound: true);
        m_Playermvt_Movements = m_Playermvt.FindAction("Movements", throwIfNotFound: true);
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

    // Player mvt
    private readonly InputActionMap m_Playermvt;
    private IPlayermvtActions m_PlayermvtActionsCallbackInterface;
    private readonly InputAction m_Playermvt_Movements;
    public struct PlayermvtActions
    {
        private @PlayerControls m_Wrapper;
        public PlayermvtActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_Playermvt_Movements;
        public InputActionMap Get() { return m_Wrapper.m_Playermvt; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayermvtActions set) { return set.Get(); }
        public void SetCallbacks(IPlayermvtActions instance)
        {
            if (m_Wrapper.m_PlayermvtActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_PlayermvtActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_PlayermvtActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_PlayermvtActionsCallbackInterface.OnMovements;
            }
            m_Wrapper.m_PlayermvtActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
            }
        }
    }
    public PlayermvtActions @Playermvt => new PlayermvtActions(this);
    public interface IPlayermvtActions
    {
        void OnMovements(InputAction.CallbackContext context);
    }
}
