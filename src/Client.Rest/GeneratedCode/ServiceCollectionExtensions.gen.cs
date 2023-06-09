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
/// Defines extension methods for the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/> type
/// that allow registered <see cref="ChatGPTClient"/> instances.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public static partial class ChatGPTServiceCollectionExtensions
{
    #region Code

    #region Public Methods

    /// <summary>
    /// Adds the default ChatGPT service client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="clientFactory">The delegate that should be used to create the service client instance.</param>
    /// <returns>
    /// The <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.
    /// </returns>
    /// <remarks>
    /// The service client is registered by default as a singleton.
    /// </remarks>
    public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddChatGPTClient(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<System.IServiceProvider, ChatGPTClientOptions, ChatGPTClient> clientFactory)
    {
        return services
            .AddChatGPTClient(
                _ => new ChatGPTClientOptions(),
                clientFactory);
    }

    /// <summary>
    /// Adds the default ChatGPT service client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="clientOptionsFactory">The delegate that should be used to create the service client options instance.</param>
    /// <param name="clientFactory">The delegate that should be used to create the service client instance.</param>
    /// <returns>
    /// The <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.
    /// </returns>
    /// <remarks>
    /// The service client is registered by default as a singleton.
    /// </remarks>
    public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddChatGPTClient(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Func<System.IServiceProvider, ChatGPTClientOptions> clientOptionsFactory, Func<System.IServiceProvider, ChatGPTClientOptions, ChatGPTClient> clientFactory)
    {
        return services
            .AddChatGPTClient(
                Primavera.Hydrogen.Rest.Client.RestServiceClientFactory<ChatGPTClient, ChatGPTClientOptions>.DefaultClientName,
                clientOptionsFactory,
                clientFactory);
    }

    /// <summary>
    /// Adds the default ChatGPT service client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="name">The service client name.</param>
    /// <param name="clientFactory">The delegate that should be used to create the service client instance.</param>
    /// <returns>
    /// The <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.
    /// </returns>
    /// <remarks>
    /// The service client is registered by default as a singleton.
    /// </remarks>
    public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddChatGPTClient(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string name, Func<System.IServiceProvider, ChatGPTClientOptions, ChatGPTClient> clientFactory)
    {
        return services
            .AddChatGPTClient(
                name,
                _ => new ChatGPTClientOptions(),
                clientFactory);
    }

    /// <summary>
    /// Adds the default ChatGPT service client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="name">The service client name.</param>
    /// <param name="clientOptionsFactory">The delegate that should be used to create the service client options instance.</param>
    /// <param name="clientFactory">The delegate that should be used to create the service client instance.</param>
    /// <returns>
    /// The <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.
    /// </returns>
    /// <remarks>
    /// The service client is registered by default as a singleton.
    /// </remarks>
    public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddChatGPTClient(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, string name, Func<System.IServiceProvider, ChatGPTClientOptions> clientOptionsFactory, Func<System.IServiceProvider, ChatGPTClientOptions, ChatGPTClient> clientFactory)
    {
        services
            .AddRestServiceClient<ChatGPTClient, ChatGPTClientOptions, ChatGPTClientFactory>(
                name,
                clientOptionsFactory,
                clientFactory);

        if (name.EqualsNoCase(RestServiceClientFactory<ChatGPTClient, ChatGPTClientOptions>.DefaultClientName))
        {
            services
                .TryAddSingleton<IChatGPTClient>(
                    provider => provider.GetRequiredService<ChatGPTClient>());
        }

        return services;
    }

    #endregion

    #endregion
}

#endregion

#endregion
