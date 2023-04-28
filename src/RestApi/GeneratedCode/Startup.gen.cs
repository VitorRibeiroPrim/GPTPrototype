﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

// Ignore Spelling: ro

namespace Primavera.Lithium.ChatGPT.Server.RestApi;

#region Code

#region Public Classes

/// <summary>
/// Provides extension methods for the <see cref="Microsoft.Extensions.DependencyInjection.IMvcBuilder" /> type.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public static partial class MvcBuilderExtensions
{
    #region Code

    #region Public Methods

    /// <summary>
    /// Configures the REST API part.
    /// </summary>
    /// <param name="builder">The MVC builder.</param>
    /// <param name="hostConfiguration">The host configuration.</param>
    /// <returns>
    /// The MVC builder instance.
    /// </returns>
    /// <remarks>
    /// This method is called from the host startup.
    /// </remarks>
    public static Microsoft.Extensions.DependencyInjection.IMvcBuilder AddRestApiPart(this Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration hostConfiguration)
    {
        Primavera.Lithium.ChatGPT.Server.RestApi.Startup instance = new Primavera.Lithium.ChatGPT.Server.RestApi.Startup(hostConfiguration);

        instance.AddServices(builder.Services);

        instance.AddMvc(builder);

        instance.AddMappings(builder.Services);

        instance.ConfigureJsonOptions(builder.Services);

        return builder;
    }

    #endregion

    #endregion
}

#endregion

#region Internal Classes

/// <summary>
/// Defines the base class for <see cref="Startup" /> to allow customization.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
internal abstract partial class StartupBase
{
    #region Code

    #region Protected Properties

    /// <summary>
    /// Gets the host configuration.
    /// </summary>
    protected Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration HostConfiguration
    {
        get;
    }

    #endregion

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="StartupBase" /> class.
    /// </summary>
    /// <param name="hostConfiguration">The host configuration.</param>
    protected StartupBase(Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration hostConfiguration)
    {
        this.HostConfiguration = hostConfiguration;
    }

    #endregion

    #region Internal Methods

    /// <summary>
    /// Configures the services.
    /// </summary>
    /// <param name="services">The service collection.</param>
    internal virtual void AddServices(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
    {
    }

    /// <summary>
    /// Configures MVC.
    /// </summary>
    /// <param name="builder">The MVC builder.</param>
    internal virtual void AddMvc(Microsoft.Extensions.DependencyInjection.IMvcBuilder builder)
    {
        // Known controllers

        builder.AddApplicationPart(
            typeof(RestApi.Controllers.CustomApiControllerBase).Assembly);
    }

    /// <summary>
    /// Configures the mappings.
    /// </summary>
    /// <param name="services">The service collection.</param>
    internal virtual void AddMappings(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
    {
        services.AddSingleton<AutoMapper.Profile, Primavera.Lithium.ChatGPT.Server.RestApi.MappingProfile>();
    }

    /// <summary>
    /// Configures the MVC JSON serializer options.
    /// </summary>
    /// <param name="services">The service collection.</param>
    internal virtual void ConfigureJsonOptions(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
    {
        services.Configure<Microsoft.AspNetCore.Mvc.JsonOptions>(
            options =>
            {
                // NOTES:
                // This combines the known serializer contexts so that MVC
                // knows the types for the RESP API models

                options.JsonSerializerOptions.CombineResolvers(
                    RestApi.Models.SerializerContext.Default);
            });
    }

    #endregion

    #endregion
}

/// <summary>
/// Provides methods to startup the REST API part.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
internal partial class Startup : StartupBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Startup" /> class.
    /// </summary>
    /// <param name="hostConfiguration">The host configuration.</param>
    public Startup(Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration hostConfiguration)
        : base(hostConfiguration)
    {
    }

    #endregion

    #endregion
}

#endregion

#endregion
