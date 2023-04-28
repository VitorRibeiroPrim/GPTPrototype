using Microsoft.AspNetCore.SignalR;
using Primavera.Lithium.ChatGPT.Server.RestApi.Contracts;
using Primavera.Lithium.ChatGPT.Server.RestApi.Models;

namespace Primavera.Lithium.ChatGPT.Server.Host.Hubs;

/// <summary>
/// The chat hub class.
/// </summary>
/// <seealso cref="Microsoft.AspNetCore.SignalR.Hub" />
public class ChatHub : Hub
{
    #region Fields

    /// <summary>
    /// The service provider.
    /// </summary>
    private readonly IServiceProvider serviceProvider;

    #endregion

    #region Private Properties

    /// <summary>
    /// Gets the chat GPT manager.
    /// </summary>
    /// <value>
    /// The chat GPT manager.
    /// </value>
    protected IChatGPTManager ChatGPTManager
    {
        get { return this.serviceProvider.GetRequiredService<IChatGPTManager>(); }
    }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatHub"/> class.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    public ChatHub(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Sends the message.
    /// </summary>
    /// <param name="user">The user.</param>
    /// <param name="message">The message.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task SendMessageAsync(string user, string message)
    {
        await this.Clients.Caller.SendAsync("ReceiveMessage", user, message).ConfigureAwait(false);

        Result<string> result = await this.SendAskAsync(message).ConfigureAwait(false);

        await this.Clients.Caller.SendAsync("ReceiveMessage", "Server", result.Value).ConfigureAwait(false);
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Sends the ask asynchronous.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <returns>
    /// A <see cref="Task" /> representing the asynchronous operation.
    /// The Primavera.Hydrogen.Result that describes the operation result.
    /// </returns>
    private Task<Result<string>> SendAskAsync(string message)
    {
        Request request = new()
        {
            Question = message,
        };

        return this.ChatGPTManager.AskAsync(request);
    }

    #endregion
}