using Primavera.Lithium.ChatGPT.Server.RestApi.Contracts;
using Primavera.Lithium.ChatGPT.Server.RestApi.Models;

namespace Primavera.Lithium.ChatGPT.Server.RestApi.Controllers;

/// <content/>
public partial class ChatGPTController
{
    #region Fields

    private IChatGPTManager? chatGPTManager;

    #endregion

    #region Private Properties

    private IChatGPTManager ChatGPTManager
    {
        get
        {
            this.chatGPTManager ??= this
                .HttpContext
                .RequestServices
                .GetRequiredService<IChatGPTManager>();

            return this.chatGPTManager;
        }
    }

    #endregion

    #region Protected Methods

    /// <inheritdoc/>
    protected override async Task<IActionResult> AskCoreAsync(Request request, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(request, nameof(request));

        Result<string> result = await this
            .ChatGPTManager
            .AskAsync(request, cancellationToken)
            .ConfigureAwait(false);

        if (result.Failed)
        {
            return this.BadRequest(RestProblemDetails.FromResult(result));
        }

        string responseContent = result.Value;
        Console.WriteLine(responseContent);

        return this.Ok(responseContent);
    }

    #endregion
}
