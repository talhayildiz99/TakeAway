// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace TakeAway.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceCatalog"){Scopes = {"CatalogFullPermission", "CatalogReadPermission"} },
            new ApiResource("ResourceDiscount"){Scopes = {"DiscountFullPermission"}},
            new ApiResource("ResourceDiscount2"){Scopes = {"DiscountDeletePermission"}},
            new ApiResource("ResourceOrder"){Scopes = {"OrderFullPermission"}},
            new ApiResource("ResourceCargo"){Scopes = {"CargoFullPermission"}},
            new ApiResource("ResourceBasket"){Scopes = {"BasketFullPermission"}},
            new ApiResource("ResourceComment"){Scopes = {"CommentFullPermission"}},
            new ApiResource("ResourceOcelot"){Scopes = {"OcelotFullPermission"}},
            new ApiResource("ResourceMessage"){Scopes = {"MessageFullPermission"}},
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };
        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermission","Full Aouthority For Catalog Operations"),
            new ApiScope("DiscountFullPermission","Delete Aouthority For Discount Operations"),
            new ApiScope("Discount2FullPermission","Full Aouthority For Discount2 Operations"),
            new ApiScope("OrderFullPermission","Full Aouthority For Order Operations"),
            new ApiScope("CargoFullPermission","Full Aouthority For Cargo Operations"),
            new ApiScope("BasketFullPermission","Full Aouthority For Basket Operations"),
            new ApiScope("CommentFullPermission","Full Aouthority For Comment Operations"),
            new ApiScope("OcelotFullPermission","Full Aouthority For Ocelot Operations"),
            new ApiScope("MessageFullPermission","Full Aouthority For Message Operations"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<Client> Clients => new Client[]
        {
            new Client
            {
                ClientId = "TakeAwayVisitorId",
                ClientName = "TakeAwayVisitor User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = {new Secret("takeawaysecret".Sha256())},
                AllowedScopes = {"CatalogFullPermission", "OcelotFullPermission",  IdentityServerConstants.LocalApi.ScopeName },
                AccessTokenLifetime = 300
            },
            new Client
            {
                ClientId = "TakeAwayAdminId",
                ClientName = "TakeAwayAdminUser",
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                ClientSecrets = {new Secret("takeawaysecret".Sha256())},
                AllowedScopes = {"CatalogFullPermission", "DiscountFullPermission", "Discount2FullPermission", "OrderFullPermission", "CargoFullPermission", "BasketFullPermission", "CommentFullPermission", "OcelotFullPermission", "MessageFullPermission", IdentityServerConstants.LocalApi.ScopeName, IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Email, IdentityServerConstants.StandardScopes.Profile },
                AccessTokenLifetime = 750
            }
        };
    }
}