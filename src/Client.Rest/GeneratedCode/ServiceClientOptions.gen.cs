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

#region Public Classes

/// <summary>
/// Defines the base class for the service client options.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability Rules", "SA1402:FileMayOnlyContainASingleType", Justification = "Because of code generation design.")]
public abstract partial class ChatGPTClientOptionsBase : Primavera.Hydrogen.Rest.Client.RestServiceClientOptions
{
    #region Code

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatGPTClientOptionsBase" /> class.
    /// </summary>
    protected ChatGPTClientOptionsBase()
        : base()
    {
        this.InitializeSerialization();
        this.SetDefaultValues();
    }

    #endregion

    #region Protected Methods

    /// <summary>
    /// Initializes the serialization options.
    /// </summary>
    protected virtual void InitializeSerialization()
    {
        // NOTES:
        // This combines the known serializer contexts so that the REST pipeline
        // knows the types for generated controllers (monitoring, etc.)
        // DefaultJsonTypeInfoResolver enables reflection serialization,
        // which is needed because there is a scenario (status code 415)
        // where MVC will return ProblemDetails and that type cannot be
        // added to serializer contexts

        this.SerializerOptions.CombineResolvers(
            new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver(),
            Primavera.Hydrogen.Rest.RestSerializerContext.Default,
            Primavera.Hydrogen.HealthMonitoring.HealthMonitoringSerializerContext.Default,
            Models.SerializerContext.Default);

        this.DeserializerOptions.CombineResolvers(
            new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver(),
            Primavera.Hydrogen.Rest.RestSerializerContext.Default,
            Primavera.Hydrogen.HealthMonitoring.HealthMonitoringSerializerContext.Default,
            Models.SerializerContext.Default);
    }

    /// <summary>
    /// Sets the default values.
    /// </summary>
    /// <remarks>
    /// This method should be overridden to set the default values of properties.
    /// </remarks>
    protected virtual void SetDefaultValues()
    {
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the service client options.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability Rules", "SA1402:FileMayOnlyContainASingleType", Justification = "Because of code generation design.")]
public partial class ChatGPTClientOptions : ChatGPTClientOptionsBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatGPTClientOptions" /> class.
    /// </summary>
    public ChatGPTClientOptions()
        : base()
    {
    }

    #endregion

    #endregion
}

#endregion

#endregion
