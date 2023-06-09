﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace Primavera.Lithium.ChatGPT.Client.Rest;

#region Code

#region Public Interfaces

/// <summary>
/// Defines the interface of the service client that allows accessing the Chat Gpt Service REST API.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public partial interface IChatGPTClient
{
    #region Code

    #region Properties

    /// <summary>
    /// Provides monitoring operations on the service.
    /// </summary>
    IMonitoringClientController Monitoring
    {
        get;
    }

    /// <summary>
    /// The chatGPT controller.
    /// </summary>
    IChatGPTClientController ChatGPT
    {
        get;
    }

    #endregion

    #endregion
}

#endregion

#endregion
