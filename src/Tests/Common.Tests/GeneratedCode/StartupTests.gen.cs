﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Primavera.Lithium.ChatGPT.Server.Common.Tests;

#region Code

#region Public Classes

/// <summary>
/// Defines the base class for <see cref="StartupTests"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public abstract partial class StartupTestsBase
{
    #region Code

    #region Protected Methods

    /// <summary>
    /// Creates the service collection instance.
    /// </summary>
    /// <returns>
    /// The service collection.
    /// </returns>
    protected virtual ServiceCollection CreateServiceCollection()
    {
         return new ServiceCollection();
    }

    /// <summary>
    /// Tests the AddCommonPart method.
    /// </summary>
    protected virtual void TestAddCommonPart()
    {
        Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration hostConfiguration = new Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration();

        ServiceCollection services = this.CreateServiceCollection();

        services.AddCommonPart(hostConfiguration);

        IServiceProvider provider = services.BuildServiceProvider();

        provider.GetRequiredService<AutoMapper.IMapper>();

        this.TestAddCommonPartServices(services, provider);
    }

    /// <summary>
    /// Tests the services registered in the AddCommonPart method.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="provider">The service provider.</param>
    protected virtual void TestAddCommonPartServices(IServiceCollection services, IServiceProvider provider)
    {
    }

    #endregion

    #endregion
}

/// <summary>
/// Provides integration tests for <see cref="Startup"/>.
/// </summary>
/// <seealso cref="StartupTests" />
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public sealed partial class StartupTests : StartupTestsBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="StartupTests"/> class.
    /// </summary>
    public StartupTests()
        : base()
    {
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Tests the AddCommonPart method.
    /// </summary>
    [Fact]
    public void StartupTests_AddCommonPart()
    {
        this.TestAddCommonPart();
    }

    #endregion

    #endregion
}

#endregion

#endregion
