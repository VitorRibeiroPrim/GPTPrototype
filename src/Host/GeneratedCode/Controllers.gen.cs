﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using Primavera.Hydrogen.Reflection;

namespace Primavera.Lithium.ChatGPT.Server.Host.Controllers;

#region Code

#region Public Classes

/// <summary>
/// Defines the base class for all the controllers in the MVC application.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public abstract partial class AppControllerBase : Microsoft.AspNetCore.Mvc.Controller
{
    #region Code

    #region Protected Properties

    /// <summary>
    /// Gets the host configuration options.
    /// </summary>
    protected Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration HostConfiguration => this.HttpContext.RequestServices.GetRequiredService<Primavera.Lithium.ChatGPT.Server.Common.Configuration.HostConfiguration>();

    /// <summary>
    /// Gets the host environment.
    /// </summary>
    protected Microsoft.Extensions.Hosting.IHostEnvironment HostEnvironment => this.HttpContext.RequestServices.GetRequiredService<Microsoft.Extensions.Hosting.IHostEnvironment>();

    /// <summary>
    /// Gets the logger.
    /// </summary>
    protected Microsoft.Extensions.Logging.ILogger Logger
    {
        get;
    }

    #endregion

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="AppControllerBase" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    protected AppControllerBase(Microsoft.Extensions.Logging.ILogger logger)
        : base()
    {
        this.Logger = logger;
    }

    #endregion

    #region Protected Methods

    /// <summary>
    /// Initializes a new validator.
    /// </summary>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.AspNetCore.Mvc.Validation.ApiControllerValidator" /> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.AspNetCore.Mvc.Validation.ApiControllerValidator Validate()
    {
        return new Primavera.Hydrogen.AspNetCore.Mvc.Validation.ApiControllerValidator(
            this.ModelState,
            this.Logger);
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the base class for the controller that provides the home routes.
/// </summary>
/// <remarks>
/// This is the base class of the MVC controller.
/// </remarks>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public abstract partial class HomeControllerBase : AppControllerBase, IHomeController
{
    #region Code

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HomeControllerBase" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    protected HomeControllerBase(Microsoft.Extensions.Logging.ILogger logger)
        : base(logger)
    {
    }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Home.Actions.Index)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Home.Routes.Index)]
    public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> IndexAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        // Show the view

        return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.IActionResult>(
            this.View(Primavera.Lithium.ChatGPT.Server.Common.Constants.Views.Home));
    }

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Home.Actions.Error)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Home.Routes.Error)]
    public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ErrorAsync(int statusCode, System.Threading.CancellationToken cancellationToken = default)
    {
        // If status code is 0, then use the status code in the response

        if (statusCode == 0 && this.HttpContext.Response != null)
        {
            statusCode = this.HttpContext.Response.StatusCode;
        }

        // Original path and query string

        string? originalPath = null;
        string? originalQueryString = null;

        // Exception feature

        Microsoft.AspNetCore.Diagnostics.IExceptionHandlerPathFeature? exceptionHandlerFeature = this.HttpContext.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerPathFeature>();
        if (exceptionHandlerFeature != null)
        {
            originalPath = exceptionHandlerFeature.Path;
        }

        // Status code feature

        Microsoft.AspNetCore.Diagnostics.IStatusCodeReExecuteFeature? statusCodeFeature = this.HttpContext.Features.Get<Microsoft.AspNetCore.Diagnostics.IStatusCodeReExecuteFeature>();
        if (statusCodeFeature != null)
        {
            originalPath = statusCodeFeature.OriginalPath;
            originalQueryString = statusCodeFeature.OriginalQueryString;
        }

        // Build the view model

        ViewModels.ErrorViewModel model = new ViewModels.ErrorViewModel(
            statusCode, 
            originalPath,
            originalQueryString,
            this.User?.Identity != null ? this.User.Identity.IsAuthenticated : false,
            this.User?.GetEmail());

        // Show the error

        return this.ShowErrorAsync(
            model,
            cancellationToken);
    }

    #endregion

    #region Protected Methods

    /// <summary>
    /// Shows the default error page for the specified view model.
    /// </summary>
    /// <param name="model">The error view model.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// The <see cref="System.Threading.Tasks.Task{TResult}"/> that represents the asynchronous operation.
    /// The <see cref="Microsoft.AspNetCore.Mvc.IActionResult"/> that describes the action result.
    /// </returns>
    protected virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ShowErrorAsync(ViewModels.ErrorViewModel model, System.Threading.CancellationToken cancellationToken = default)
    {
        Primavera.Hydrogen.Guard.NotNull(model, nameof(model));

        // Show the view

        return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.IActionResult>(
            this.View(
                Primavera.Lithium.ChatGPT.Server.Common.Constants.Views.Error,
                model));
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the controller that provides the home routes.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
[Microsoft.AspNetCore.Mvc.ControllerName(Common.Constants.Controllers.Home.Name)]
public partial class HomeController : HomeControllerBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HomeController" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public HomeController(Microsoft.Extensions.Logging.ILogger<HomeController> logger)
        : base(logger)
    {
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the base class for the controller that provides monitoring routes.
/// </summary>
/// <remarks>
/// This is the base class of the MVC controller.
/// </remarks>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public abstract partial class MonitoringControllerBase : AppControllerBase, IMonitoringController
{
    #region Code

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MonitoringControllerBase" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    protected MonitoringControllerBase(Microsoft.Extensions.Logging.ILogger logger)
        : base(logger)
    {
    }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Monitoring.Actions.Probe)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Monitoring.Routes.Probe)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Primavera.Hydrogen.HealthMonitoring.HealthResult), (int)System.Net.HttpStatusCode.OK)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Primavera.Hydrogen.HealthMonitoring.HealthResult), (int)System.Net.HttpStatusCode.ServiceUnavailable)]
    public virtual async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ProbeAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        // NOTES:
        // The Probe endpoint is used to monitor the health of the service
        // to ensure its liveness and readiness and to drive routing, fail-over,
        // and other infrastructure mechanisms.
        // This endpoint will be invoked very frequently, so it is expected to
        // check the service health very fast (and fail fast if something is
        // wrong).
        // It is paramount that the probes performed are as fast as possible,
        // executing very simple and atomic operations.
        // Be sure to use IHealthProbesBuilder so that all probes can be executed
        // in parallel, exceptions are correctly handled, telemetry is collected,
        // etc.
        // By default, this implementation will probe the dependencies specified
        // in the service model.
        // Additional probes (e.g. dependencies that cannot be described in the
        // service model, like a SQL server for example) may be implemented by
        // overriding AddDependenciesProbes(), AddAdditionalProbes(), etc.

        Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder = Primavera.Hydrogen.HealthMonitoring.HealthProbesBuilder
            .Create();

        this.AddAzureManagedConfigurationProbes(builder);

        this.AddDependenciesProbes(builder);

        this.AddAdditionalProbes(builder);

        Primavera.Hydrogen.HealthMonitoring.IHealthMonitoringService service = this.HttpContext.RequestServices.GetRequiredService<Primavera.Hydrogen.HealthMonitoring.IHealthMonitoringService>();

        Primavera.Hydrogen.HealthMonitoring.HealthResult result = await service.ProbeAsync(
            builder,
            cancellationToken)
            .ConfigureAwait(false);

        if (result.Status == Primavera.Hydrogen.HealthMonitoring.HealthStatus.Unhealthy)
        {
            return this.StatusCode(
                (int)System.Net.HttpStatusCode.ServiceUnavailable,
                result);
        }

        return this.Ok(result);
    }

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Monitoring.Actions.Diagnostics)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Monitoring.Routes.Diagnostics)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Primavera.Hydrogen.HealthMonitoring.HealthResult), (int)System.Net.HttpStatusCode.OK)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Primavera.Hydrogen.HealthMonitoring.HealthResult), (int)System.Net.HttpStatusCode.ServiceUnavailable)]
    public virtual async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DiagnosticsAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        // NOTES:
        // The Diagnostics endpoint is used to monitor the health of the service
        // to ensure that it is capable of executing its business logic as expected.
        // Unlike the Probe endpoint, this endpoint will be invoked much less
        // frequently, so it is acceptable for it to take more time to check the
        // service health from a business-logic standpoint.
        // By default, this implementation will diagnose the dependencies and
        // the service dependencies (dependencies on other services) specified 
        // in the service model.
        // Additional diagnostics (e.g. dependencies that cannot be described in the
        // service model, like a SQL server for example) may be implemented by
        // overriding AddDependenciesDiagnostics(), AddAdditionalDiagnostics(), etc.

        Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder = Primavera.Hydrogen.HealthMonitoring.HealthProbesBuilder
            .Create();

        this.AddAzureManagedConfigurationDiagnostics(builder);

        this.AddDependenciesDiagnostics(builder);

        this.AddServiceDependenciesDiagnostics(builder);

        this.AddAdditionalDiagnostics(builder);

        Primavera.Hydrogen.HealthMonitoring.IHealthMonitoringService service = this.HttpContext.RequestServices.GetRequiredService<Primavera.Hydrogen.HealthMonitoring.IHealthMonitoringService>();

        Primavera.Hydrogen.HealthMonitoring.HealthResult result = await service.ProbeAsync(
            builder,
            cancellationToken)
            .ConfigureAwait(false);

        if (result.Status == Primavera.Hydrogen.HealthMonitoring.HealthStatus.Unhealthy)
        {
            return this.StatusCode(
                (int)System.Net.HttpStatusCode.ServiceUnavailable,
                result);
        }

        return this.Ok(result);
    }

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Monitoring.Actions.Endpoints)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Monitoring.Routes.Endpoints)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(System.Collections.Generic.IEnumerable<Primavera.Hydrogen.Rest.Routing.EndpointInfo>), (int)System.Net.HttpStatusCode.OK)]
    public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> EndpointsAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        Primavera.Hydrogen.AspNetCore.Routing.IEndpointAnalyzerService service = this.HttpContext.RequestServices.GetRequiredService<Primavera.Hydrogen.AspNetCore.Routing.IEndpointAnalyzerService>();

        System.Collections.Generic.IEnumerable<Primavera.Hydrogen.Rest.Routing.EndpointInfo> endpoints = service.Analyze();

        return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.IActionResult>(
            this.Ok(
                endpoints));
    }

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Monitoring.Actions.Configuration)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Monitoring.Routes.Configuration)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Primavera.Hydrogen.Rest.Configuration.ConfigurationLocation), (int)System.Net.HttpStatusCode.OK)]
    public virtual async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ConfigurationAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        Primavera.Hydrogen.AspNetCore.Configuration.IConfigurationAnalyzerService service = this.HttpContext.RequestServices.GetRequiredService<Primavera.Hydrogen.AspNetCore.Configuration.IConfigurationAnalyzerService>();

        Primavera.Hydrogen.Rest.Configuration.ConfigurationLocation location = await service.SaveDebugAsync(
            "GPT", 
            cancellationToken)
            .ConfigureAwait(false);

        return this.Ok(
            location);
    }

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.Monitoring.Actions.Information)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.Monitoring.Routes.Information)]
    [Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Primavera.Hydrogen.Rest.Description.ServiceInfo), (int)System.Net.HttpStatusCode.OK)]
    public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> InformationAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        this.GetInformationFromAssembly(out string version, out string build, out string copyright);

        Primavera.Hydrogen.Rest.Description.ServiceInfo result = new Primavera.Hydrogen.Rest.Description.ServiceInfo()
        {
            Id = "GPT",
            Name = "ChatGPT",
            DisplayName = "Chat Gpt Service",
            Version = version,
            Build = build,
            Copyright = copyright,
            Framework = "5",
            Host = new Primavera.Hydrogen.Rest.Description.HostInfo()
            {
                Application = this.HostEnvironment.ApplicationName,
                Environment = this.HostEnvironment.EnvironmentName
            }
        };

        result.ApiVersions = new List<string>()
        {
            "1.0",
        };

        return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.IActionResult>(
            this.Ok(
                result));
    }

    #endregion

    #region Protected Methods

    /// <summary>
    /// Adds probes for the Azure Managed Configuration service, as part of the Probe endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddAzureManagedConfigurationProbes(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        return builder
            .AddAzureManagedConfigurationProbes();
    }

    /// <summary>
    /// Adds diagnostics for the Azure Managed Configuration service, as part of the Diagnostics endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddAzureManagedConfigurationDiagnostics(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        // NOTES:
        // Override this method to implement a more specific
        // diagnostic

        return builder
            .AddAzureManagedConfigurationProbes();
    }

    /// <summary>
    /// Adds probes for the dependencies of the service, as part of the Probe endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddDependenciesProbes(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        // NOTES:
        // Override this method to configure probes for dependencies
        // that cannot be expressed in the service model

        return builder;
    }

    /// <summary>
    /// Adds diagnostics for the dependencies of the service, as part of the Diagnostics endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddDependenciesDiagnostics(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        // NOTES:
        // Override this method to configure diagnostics for dependencies
        // that cannot be expressed in the service model

        return builder;
    }

    /// <summary>
    /// Adds diagnostics for the service dependencies of the service, as part of the Diagnostics endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddServiceDependenciesDiagnostics(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        // NOTES:
        // The service has no service dependencies

        return builder;
    }

    /// <summary>
    /// Adds additional probes for the service, as part of the Probe endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddAdditionalProbes(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        // NOTES:
        // Override this method to implement additional probes

        return builder;
    }

    /// <summary>
    /// Adds additional diagnostics for the service, as part of the Diagnostics endpoint.
    /// </summary>
    /// <param name="builder">The probes builder.</param>
    /// <returns>
    /// The <see cref="Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder"/> instance.
    /// </returns>
    protected virtual Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder AddAdditionalDiagnostics(Primavera.Hydrogen.HealthMonitoring.IHealthProbesBuilder builder)
    {
        // NOTES:
        // Override this method to implement additional diagnostics

        return builder;
    }

    #endregion

    #region Private Methods

    private void GetInformationFromAssembly(out string version, out string build, out string copyright)
    {
        System.Reflection.Assembly assembly = this.GetType().Assembly;

        version = assembly.Reflector().AssemblyFileVersion.ToString();
        build = assembly.Reflector().AssemblyInformationalVersion;
        copyright = assembly.Reflector().AssemblyCopyright;
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the controller that provides monitoring routes.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
[Microsoft.AspNetCore.Mvc.ControllerName(Common.Constants.Controllers.Monitoring.Name)]
[Microsoft.AspNetCore.Mvc.ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public partial class MonitoringController : MonitoringControllerBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MonitoringController" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public MonitoringController(Microsoft.Extensions.Logging.ILogger<MonitoringController> logger)
        : base(logger)
    {
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the base class for the controller that provides the client library documentation routes.
/// </summary>
/// <remarks>
/// This is the base class of the MVC controller.
/// </remarks>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public abstract partial class ClientLibDocumentationControllerBase : AppControllerBase, IClientLibDocumentationController
{
    #region Code

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientLibDocumentationControllerBase" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    protected ClientLibDocumentationControllerBase(Microsoft.Extensions.Logging.ILogger logger)
        : base(logger)
    {
    }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    [Microsoft.AspNetCore.Mvc.ActionName(Common.Constants.Controllers.ClientLibDocumentation.Actions.Documentation)]
    [Microsoft.AspNetCore.Mvc.HttpGet(Common.Constants.Controllers.ClientLibDocumentation.Routes.Documentation)]
    public virtual System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DocumentationAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        // Show the view

        return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.IActionResult>(
            this.View(Primavera.Lithium.ChatGPT.Server.Common.Constants.Views.ClientLibDocumentation));
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the controller that provides the client library documentation routes.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
[Microsoft.AspNetCore.Mvc.ControllerName(Common.Constants.Controllers.ClientLibDocumentation.Name)]
public partial class ClientLibDocumentationController : ClientLibDocumentationControllerBase
{
    #region Code

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientLibDocumentationController" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public ClientLibDocumentationController(Microsoft.Extensions.Logging.ILogger<ClientLibDocumentationController> logger)
        : base(logger)
    {
    }

    #endregion

    #endregion
}

#endregion

#endregion
