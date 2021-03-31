﻿using System;
using System.Text.Json;
using IOL.VippsEcommerce;
using IOL.VippsEcommerce.Models;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddVippsEcommerceService(o => {
	o.ApiUrl = "";
	o.PrimarySubscriptionKey = "";
	o.ClientSecret = "";
	o.ClientId = "";
	o.CacheEncryptionKey = "";
	o.CacheDirectoryPath = "";
	o.ConfigurationMode = VippsConfigurationMode.ONLY_OBJECT;
});
var provider = services.BuildServiceProvider();
var vippsEcommerceService = provider.GetService<IVippsEcommerceService>();
var res = vippsEcommerceService?.GetPaymentDetailsAsync("asdf").Result;
Console.WriteLine(JsonSerializer.Serialize(res));