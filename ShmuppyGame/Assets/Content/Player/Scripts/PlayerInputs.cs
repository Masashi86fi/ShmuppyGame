// GENERATED AUTOMATICALLY FROM 'Assets/Content/Player/Scripts/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""TouchMovement"",
            ""id"": ""570fe3b9-6677-40e0-b7fd-ab6e03241231"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f3934103-c05a-4a61-a555-f1eff3863dc7"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1ce11e86-e47e-41ce-ac00-758cc2b68c41"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TouchMovement
        m_TouchMovement = asset.FindActionMap("TouchMovement", throwIfNotFound: true);
        m_TouchMovement_Movement = m_TouchMovement.FindAction("Movement", throwIfNotFound: true);
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

    // TouchMovement
    private readonly InputActionMap m_TouchMovement;
    private ITouchMovementActions m_TouchMovementActionsCallbackInterface;
    private readonly InputAction m_TouchMovement_Movement;
    public struct TouchMovementActions
    {
        private @PlayerInputs m_Wrapper;
        public TouchMovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_TouchMovement_Movement;
        public InputActionMap Get() { return m_Wrapper.m_TouchMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchMovementActions set) { return set.Get(); }
        public void SetCallbacks(ITouchMovementActions instance)
        {
            if (m_Wrapper.m_TouchMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_TouchMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TouchMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TouchMovementActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_TouchMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public TouchMovementActions @TouchMovement => new TouchMovementActions(this);
    public interface ITouchMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
