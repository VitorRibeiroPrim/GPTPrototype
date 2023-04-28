# <a name="root"></a>Lithium Chat Gpt Service (GPT) Client Library

Chat GPT prototype.

## REST Service Client

| Class | Description |
| - | - |
| [`ChatGPTClient`](#ChatGPTClient) | The entry point of the Chat Gpt Service client library. |

## Client Controllers

| Class | Description |
| - | - |
| [`ChatGPT`](#ChatGPTClientController) | The chatGPT controller. |

## Models

| Class | Description |
| - | - |
| [`Request`](#Request) | The request resource. |

## Enumerations

The client library has no enumerations.

## Reference

### REST Service Client Classes

#### <a name="ChatGPTClient"></a>`ChatGPTClient`

- Namespace: `Primavera.Lithium.ChatGPT.Client.Rest`
- Inheritance: `ChatGPTClientBase` (`RestServiceClient`)

##### Constructors

###### `ChatGPTClient(Uri, BearerTokenCredential)`

| Parameter | Type | Description |
| - | - | - |
| `serviceUri` | `Uri` | The service URI. |
| `credential` | `BearerTokenCredential` | The credential that should be used to access the service. |

###### `ChatGPTClient(Uri, BearerTokenCredential, ChatGPTClientOptions)`

| Parameter | Type | Description |
| - | - | - |
| `serviceUri` | `Uri` | The service URI. |
| `credential` | `BearerTokenCredential` | The credential that should be used to access the service. |
| `clientOptions` | `ChatGPTClientOptions` | The client options. |

##### Example

```csharp
Uri address = new Uri("[service-address]");

ChatGPTClient client = new ChatGPTClient(
    new Uri(address),
    new NoCredential());
```

[^ Back to top](#root)

### Client Controllers Classes

#### <a name="ChatGPTClientController"></a>`ChatGPTClientController`

The chatGPT controller.

- Namespace: `Primavera.Lithium.ChatGPT.Client.Rest`
- Inheritance: `ChatGPTClientControllerBase` (`IChatGPTClientController`)

##### Methods

##### `AskAsync()`

Ask a question to the chat.

```csharp
public async Task<RestServiceResult<string>> AskAsync(Primavera.Lithium.ChatGPT.Client.Rest.Models.Request request, CancellationToken cancellationToken = default);

public RestServiceResult<string> Ask(Primavera.Lithium.ChatGPT.Client.Rest.Models.Request request);
```

###### Parameters

| Parameter | Type | Description | Rules |
| - | - | - | - |
| `request` | `Primavera.Lithium.ChatGPT.Client.Rest.Models.Request` | The request with the question. | Required.  |


###### Returns

| Return Type | Description |
| - | - | - | - |
| `string` | The chat response. |


###### Status Codes

| Status Code | Description |
| - | - | - | - |
| `HttpStatusCode.Ok` | Success. |
| `HttpStatusCode.BadRequest` | Failure: the request is invalid.|
| `HttpStatusCode.Conflict` | Failure: conflict.|

> The operation will raise `RestRequestException` for any failure status code. The exception may include a body with an instance of `RestProblemDetails` depending on the status code.


[^ Back to top](#root)

### Models Classes

#### <a name="Request"></a>`Request`

The request resource.

- Namespace: `Primavera.Lithium.ChatGPT.Client.Rest.Models`
- Inheritance: `RequestBase`

##### Properties

| Property | Type | Description | Rules |
| - | - | - | - |
| `Question` | `string` | The question. | Required.  |

[^ Back to top](#root)

