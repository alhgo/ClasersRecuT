// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""RobotMove"",
            ""id"": ""cf02dba4-6669-4b4e-b544-6eb657c45587"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""881d75b5-0369-49ec-8925-4afac701e870"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""ceee1192-b5f2-4ecc-8899-a5bc42194a44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""5bb813dd-70e8-44cc-a632-ba66b47e4704"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af08a28b-6e14-4022-8998-5adaa266324a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71eaf41c-a2e1-4fcf-bf50-b895385d1f2b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c926269b-d23b-4bd7-ba8d-1b7d3f5adc2a"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMove"",
            ""id"": ""1ba47629-5788-449b-b62e-fdb3d818bcd0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""845b3986-6785-4896-8bba-e156683a62a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""9f799b02-bd81-4aed-8396-c04d928fe0ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0d43a4ef-8b28-4c2a-bc1e-69d9c00c094f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26f163e5-f9bb-4b55-a4ed-0cdc48e8382a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""045d49a5-c914-40a3-88f8-66d6d1050a29"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""75212fcd-881b-4fe6-971a-1fdc06c713f9"",
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
                    ""id"": ""8cfe72ad-d524-4b93-9139-d826b1a723ec"",
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
                    ""id"": ""1278c2e1-a4c9-41fd-b544-6e57dbc82941"",
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
                    ""id"": ""a4e30b47-9ede-4260-92d8-f155e2a5f3a8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""26c9a71e-89c2-4d47-a487-e8dcb4f9872a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""885c547b-dec9-4558-add9-dad67cc22bb1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
        // RobotMove
        m_RobotMove = asset.FindActionMap("RobotMove", throwIfNotFound: true);
        m_RobotMove_Jump = m_RobotMove.FindAction("Jump", throwIfNotFound: true);
        m_RobotMove_Run = m_RobotMove.FindAction("Run", throwIfNotFound: true);
        m_RobotMove_Walk = m_RobotMove.FindAction("Walk", throwIfNotFound: true);
        // PlayerMove
        m_PlayerMove = asset.FindActionMap("PlayerMove", throwIfNotFound: true);
        m_PlayerMove_Move = m_PlayerMove.FindAction("Move", throwIfNotFound: true);
        m_PlayerMove_Run = m_PlayerMove.FindAction("Run", throwIfNotFound: true);
        m_PlayerMove_Jump = m_PlayerMove.FindAction("Jump", throwIfNotFound: true);
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

    // RobotMove
    private readonly InputActionMap m_RobotMove;
    private IRobotMoveActions m_RobotMoveActionsCallbackInterface;
    private readonly InputAction m_RobotMove_Jump;
    private readonly InputAction m_RobotMove_Run;
    private readonly InputAction m_RobotMove_Walk;
    public struct RobotMoveActions
    {
        private @InputController m_Wrapper;
        public RobotMoveActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_RobotMove_Jump;
        public InputAction @Run => m_Wrapper.m_RobotMove_Run;
        public InputAction @Walk => m_Wrapper.m_RobotMove_Walk;
        public InputActionMap Get() { return m_Wrapper.m_RobotMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RobotMoveActions set) { return set.Get(); }
        public void SetCallbacks(IRobotMoveActions instance)
        {
            if (m_Wrapper.m_RobotMoveActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnRun;
                @Walk.started -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_RobotMoveActionsCallbackInterface.OnWalk;
            }
            m_Wrapper.m_RobotMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
            }
        }
    }
    public RobotMoveActions @RobotMove => new RobotMoveActions(this);

    // PlayerMove
    private readonly InputActionMap m_PlayerMove;
    private IPlayerMoveActions m_PlayerMoveActionsCallbackInterface;
    private readonly InputAction m_PlayerMove_Move;
    private readonly InputAction m_PlayerMove_Run;
    private readonly InputAction m_PlayerMove_Jump;
    public struct PlayerMoveActions
    {
        private @InputController m_Wrapper;
        public PlayerMoveActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMove_Move;
        public InputAction @Run => m_Wrapper.m_PlayerMove_Run;
        public InputAction @Jump => m_Wrapper.m_PlayerMove_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMoveActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMoveActions instance)
        {
            if (m_Wrapper.m_PlayerMoveActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnMove;
                @Run.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerMoveActions @PlayerMove => new PlayerMoveActions(this);
    public interface IRobotMoveActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
    }
    public interface IPlayerMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
