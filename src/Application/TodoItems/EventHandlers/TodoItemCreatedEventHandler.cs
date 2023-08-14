using Dotnet8Template.Domain.Events;
using Microsoft.Extensions.Logging;

namespace Dotnet8Template.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Dotnet8Template Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
