﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MixedRealityToolkit.Input.EventData;
using UnityEngine.EventSystems;

namespace MixedRealityToolkit.Input.InputHandlers
{
    /// <summary>
    /// Interface to implement to react to per-pointer focus enter/exit.
    /// </summary>
    public interface IPointerSpecificFocusable : IEventSystemHandler
    {
        void OnFocusEnter(PointerSpecificEventData eventData);
        void OnFocusExit(PointerSpecificEventData eventData);
    }
}
