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
            new ApiResource("ResourceCatalog") { Scopes = { "CatologFullPermission", "CatalogReadPermission" } },
            new ApiResource("ResourcesDiscount") {Scopes = {"DiscountFullPermission"}},
            new ApiResource("ResourcesDiscount2") {Scopes = {"DiscountDeletePermission"}},
            new ApiResource("ResourcesOrder") {Scopes = {"OrderFullPermission"}},
            new ApiResource("ResourcesCargo") {Scopes = {"CargoFullPermission"}},
            new ApiResource("ResourcesBasket") {Scopes = {"BasketFullPermission"}},
            new ApiResource("ResourcesComment") {Scopes = {"CommentFullPermission"}},
            new ApiResource("ResourcesOcelot") {Scopes = {"OcelotFullPermission"}},
            new ApiResource("ResourcesMessages") {Scopes = {"MessagesFullPermission"}},
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
            new ApiScope("CatalogFullPermission", "Full access to Catalog"),
            new ApiScope("DiscountFullPermission", "Full access to Discounts"),
            new ApiScope("DiscountDeletePermission", "Delete permission for Discounts"),
            new ApiScope("OrderFullPermission", "Full access to Orders"),
            new ApiScope("CargoFullPermission", "Full access to Cargo"),
            new ApiScope("BasketFullPermission", "Full access to Basket"),
            new ApiScope("CommentFullPermission", "Full access to Comments"),
            new ApiScope("OcelotFullPermission", "Full access to Ocelot Gateway"),
            new ApiScope("MessagesFullPermission", "Full access to Messages"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName, "Access to local API")
        };

        public static IEnumerable<Client> Clients => new Client[]
       {
            new Client
            {
                ClientId = "TakeAwayVisitorId",
                ClientName = "TakeAway Visitor User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("takeawaysecret".Sha256()) },
                AllowedScopes = { "CatalogFullPermission", "OcelotFullPermission", IdentityServerConstants.LocalApi.ScopeName},
                AccessTokenLifetime = 300
            },

            new Client
            {
                ClientId = "TakeAwayAdminId",
                ClientName = "TakeAway Admin User",
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                ClientSecrets = { new Secret("takeawaysecret".Sha256()) },
                AllowedScopes = { "CatalogFullPermission", "DiscountFullPermission", "DiscountDeletePermission", "OrderFullPermission","CargoFullPermission","BasketFullPermission", "CommentFullPermission", "OcelotFullPermission","MessagesFullPermission", IdentityServerConstants.LocalApi.ScopeName, IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Email, IdentityServerConstants.StandardScopes.Profile},
                AccessTokenLifetime = 750
            }
       };
    }
}