﻿using StoreManagement.Contracts;
using StoreManagement.Events;

namespace StoreManagement.Components.Publishers;

public class WarehousePublisher : IPublisher
{
    private readonly IEventAggregator _eventAggregator;

    public WarehousePublisher(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
    }

    public void Publish(string payload) =>
        _eventAggregator.Publish(new WarehouseReceivedNewSuppliesEvent(payload));
}
