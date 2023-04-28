using Primavera.Lithium.ChatGPT.Server.Host.Hubs;
using Primavera.Lithium.ChatGPT.Server.RestApi.Contracts;
using Primavera.Lithium.ChatGPT.Server.RestApi.Managers;

namespace Primavera.Lithium.ChatGPT.Server.Host;

/// <content/>
public partial class Startup
{
    #region Public Methods

    /// <inheritdoc/>
    public override void Configure(IApplicationBuilder app, HostConfiguration hostConfiguration, ILogger<Startup> logger)
    {
        base.Configure(app, hostConfiguration, logger);

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapHub<ChatHub>("/chatHub");
        });
    }

    #endregion

    #region Protected Methods

    /// <inheritdoc/>
    protected override void AddAdditionalServices(IServiceCollection services, HostConfiguration hostConfiguration)
    {
        base
            .AddAdditionalServices(services, hostConfiguration);

        services
            .AddSingleton<IChatGPTManager, ChatGPTManager>()
            .AddSignalR();
    }

    #endregion
}