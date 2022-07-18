//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""91ef2e12-1ba1-4841-9469-949bb8573d55"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""70896a4e-d186-41f3-a6fd-99b5b6e6cf60"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""d976de12-e860-413f-a0c1-e1edca49b9c4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Handbreak"",
                    ""type"": ""Button"",
                    ""id"": ""fc63c9da-72d8-4448-8ef6-6713eb00f0ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS"",
                    ""id"": ""aedbaadf-c6da-471a-b9f4-5998a68890e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""637b18a6-0916-45b5-8489-2f8f01075871"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""04fc98a4-af17-445a-bb0e-a4e5eb4b0612"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""05a624c0-1dfa-4a9b-b04c-f4767cb1b9e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2258e935-05ea-471e-9b64-99d76b1a5367"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a33034e2-9cdb-4c80-9501-90d56a32ae65"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4c74ea68-6452-494d-b4e3-1215b97f8242"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Vertical = m_Car.FindAction("Vertical", throwIfNotFound: true);
        m_Car_Horizontal = m_Car.FindAction("Horizontal", throwIfNotFound: true);
        m_Car_Handbreak = m_Car.FindAction("Handbreak", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Car
    private readonly InputActionMap m_Car;
    private ICarActions m_CarActionsCallbackInterface;
    private readonly InputAction m_Car_Vertical;
    private readonly InputAction m_Car_Horizontal;
    private readonly InputAction m_Car_Handbreak;
    public struct CarActions
    {
        private @PlayerInputActions m_Wrapper;
        public CarActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_Car_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_Car_Horizontal;
        public InputAction @Handbreak => m_Wrapper.m_Car_Handbreak;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void SetCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_CarActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontal;
                @Handbreak.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHandbreak;
                @Handbreak.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHandbreak;
                @Handbreak.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHandbreak;
            }
            m_Wrapper.m_CarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Handbreak.started += instance.OnHandbreak;
                @Handbreak.performed += instance.OnHandbreak;
                @Handbreak.canceled += instance.OnHandbreak;
            }
        }
    }
    public CarActions @Car => new CarActions(this);
    public interface ICarActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnHandbreak(InputAction.CallbackContext context);
    }
}