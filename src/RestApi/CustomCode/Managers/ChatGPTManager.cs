using Newtonsoft.Json;
using Primavera.Hydrogen.Net.Http;
using Primavera.Lithium.ChatGPT.Server.RestApi.Contracts;
using Primavera.Lithium.ChatGPT.Server.RestApi.Models;

namespace Primavera.Lithium.ChatGPT.Server.RestApi.Managers;

/// <summary>
/// Defines the Chat GPT manager.
/// </summary>
public class ChatGPTManager : IChatGPTManager
{
    #region Fields

    private IServiceProvider serviceProvider;

    #endregion

    #region Private Properties

    /// <summary>
    /// Gets the service provider.
    /// </summary>
    /// <value>
    /// The service provider.
    /// </value>
    protected IServiceProvider ServiceProvider
    {
        get { return this.serviceProvider; }
    }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatGPTManager" /> class.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    public ChatGPTManager(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    #endregion

    #region Public Methods

    /// <inheritdoc/>
    public async Task<Result<string>> AskAsync(Request request, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(request, nameof(request));

        using HttpClient client = HttpClientBuilder.Create();

        var requestBody = new { website = "https://www.contasimple.es", question = request.Question };
        using StringContent requestContent = new StringContent(JsonConvert.SerializeObject(requestBody!), Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.PostAsync("https://lithium-dv-ana-af.azurewebsites.net/api/gpt_function?code=JVcrg9v4oCXWHN3nYZYWn_l2Ip1Zjh0ZDz1Fdxdat2GcAzFujxpITQ==", requestContent, cancellationToken).ConfigureAwait(false);

        ////if (!response.IsSuccessStatusCode)
        ////{
        ////    return new ResultError(response.StatusCode, response.ReasonPhrase);
        ////}

        return await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
    }

    #endregion
}
