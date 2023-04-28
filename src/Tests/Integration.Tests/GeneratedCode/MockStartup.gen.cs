﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Primavera.Lithium.ChatGPT.Server.Integration.Tests;

#region Code

#region Public Classes

/// <summary>
/// Defines the base class for a mock startup class used by the text fixtures.
/// </summary>
/// <seealso cref="Server.Host.Startup" />
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public abstract partial class MockStartupBase : Server.Host.Startup
{
    #region Code

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MockStartupBase"/> class.
    /// </summary>
    /// <param name="env">The current host environment.</param>
    /// <param name="configuration">The current configuration.</param>
    protected MockStartupBase(Microsoft.Extensions.Hosting.IHostEnvironment env, Microsoft.Extensions.Configuration.IConfiguration configuration)
        : base(env, configuration)
    {
    }

    #endregion

    #region Protected Methods

    /// <inheritdoc />
    protected override Common.Configuration.HostConfiguration AddConfiguration(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
    {
        Primavera.Hydrogen.Guard.NotNull(services, nameof(services));

        base.AddConfiguration(services);

        System.IServiceProvider provider = services.BuildServiceProvider();
        return provider.GetRequiredService<Common.Configuration.HostConfiguration>();
    }

    /// <inheritdoc />
    protected override void ConfigureMvc(Microsoft.Extensions.DependencyInjection.IMvcBuilder builder, Common.Configuration.HostConfiguration hostConfiguration)
    {
        Primavera.Hydrogen.Guard.NotNull(builder, nameof(builder));

        base.ConfigureMvc(builder, hostConfiguration);

        builder
            .AddApplicationPart(typeof(Server.Host.Startup).Assembly)
            .AddApplicationPart(typeof(Server.RestApi.Startup).Assembly);
    }

    /// <inheritdoc />
    protected override void ConfigureHostConfiguration(Common.Configuration.HostConfiguration configuration)
    {
        base.ConfigureHostConfiguration(configuration);

        configuration.ServiceCatalogServiceBaseUri = "https://localhost/scs";
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines a mock startup class used by the text fixtures.
/// </summary>
/// <seealso cref="MockStartupBase" />
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public partial class MockStartup : MockStartupBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MockStartup"/> class.
    /// </summary>
    /// <param name="env">The current host environment.</param>
    /// <param name="configuration">The current configuration.</param>
    public MockStartup(Microsoft.Extensions.Hosting.IHostEnvironment env, Microsoft.Extensions.Configuration.IConfiguration configuration)
        : base(env, configuration)
    {
    }

    #endregion

    #endregion
}

#endregion

#endregion