﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MixedRealityToolkit.Input.EventData;
namespace MixedRealityToolkit.Input.InputHandlers
{
    /// <summary>
    /// Interface to implement to react to touchpad controls.
    /// </summary>
    public interface IControllerTouchpadHandler : IControllerInputHandler
    {
        void OnTouchpadTouched(InputEventData eventData);
        void OnTouchpadReleased(InputEventData eventData);
    }
}