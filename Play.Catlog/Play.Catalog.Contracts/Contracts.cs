using System;

namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string name, string Description);
    public record CatalogItemUpdated(Guid ItemId, string name, string Description);
    public record CatalogItemDeleted(Guid ItemId);

}