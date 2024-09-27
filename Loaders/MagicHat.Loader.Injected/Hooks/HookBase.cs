﻿using Reloaded.Hooks.Definitions;
using Reloaded.Hooks;
using System.Diagnostics.CodeAnalysis;
using System;

namespace MagicHat.Loader.Injected.Hooks {
    internal class HookBase {
        internal static IHook<TFunction> CreateHook<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes)] TFunction>(Type type, string name, int address) {
            return ReloadedHooks.Instance.CreateHook<TFunction>(type, name, address).Activate();
        }
    }
}