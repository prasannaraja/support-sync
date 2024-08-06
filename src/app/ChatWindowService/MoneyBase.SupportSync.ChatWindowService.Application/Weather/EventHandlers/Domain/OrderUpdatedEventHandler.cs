﻿using MoneyBase.SupportSync.ChatWindowService.Domain.Events;

namespace MoneyBase.SupportSync.ChatWindowService.Application.Weather.EventHandlers.Domain;
public class OrderUpdatedEventHandler(ILogger<OrderUpdatedEventHandler> logger)
    : INotificationHandler<OrderUpdatedEvent>
{
    public Task Handle(OrderUpdatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);
        return Task.CompletedTask;
    }
}