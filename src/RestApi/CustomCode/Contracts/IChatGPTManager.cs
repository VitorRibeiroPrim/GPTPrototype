using Primavera.Lithium.ChatGPT.Server.RestApi.Models;

namespace Primavera.Lithium.ChatGPT.Server.RestApi.Contracts;

/// <summary>
/// Defines the Chat GPT manager.
/// </summary>
public interface IChatGPTManager
{
    #region Methods

    /// <summary>
    /// Asks the asynchronous.
    /// </summary>
    /// <param name="request">The dragon.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// A <see cref="Task" /> representing the asynchronous operation.
    /// The Primavera.Hydrogen.Result that describes the operation result.
    /// </returns>
    Task<Result<string>> AskAsync(Request request, CancellationToken cancellationToken = default);

    #endregion
}
