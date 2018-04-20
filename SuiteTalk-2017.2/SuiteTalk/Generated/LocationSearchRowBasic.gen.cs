//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class LocationSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<LocationSearchRowBasic>
        {
            protected override Dictionary<string, Action<LocationSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<LocationSearchRowBasic>> {
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "allowStorePickup", r => r.@allowStorePickup = new [] { new SearchColumnBooleanField { customLabel = "allowStorePickup" } } },
                    { "autoAssignmentRegionSetting", r => r.@autoAssignmentRegionSetting = new [] { new SearchColumnEnumSelectField { customLabel = "autoAssignmentRegionSetting" } } },
                    { "bufferStock", r => r.@bufferStock = new [] { new SearchColumnLongField { customLabel = "bufferStock" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "dailyShippingCapacity", r => r.@dailyShippingCapacity = new [] { new SearchColumnLongField { customLabel = "dailyShippingCapacity" } } },
                    { "endTime", r => r.@endTime = new [] { new SearchColumnDateField { customLabel = "endTime" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "geolocationMethod", r => r.@geolocationMethod = new [] { new SearchColumnEnumSelectField { customLabel = "geolocationMethod" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isFriday", r => r.@isFriday = new [] { new SearchColumnBooleanField { customLabel = "isFriday" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isMonday", r => r.@isMonday = new [] { new SearchColumnBooleanField { customLabel = "isMonday" } } },
                    { "isOffice", r => r.@isOffice = new [] { new SearchColumnBooleanField { customLabel = "isOffice" } } },
                    { "isSaturday", r => r.@isSaturday = new [] { new SearchColumnBooleanField { customLabel = "isSaturday" } } },
                    { "isSunday", r => r.@isSunday = new [] { new SearchColumnBooleanField { customLabel = "isSunday" } } },
                    { "isThursday", r => r.@isThursday = new [] { new SearchColumnBooleanField { customLabel = "isThursday" } } },
                    { "isTuesday", r => r.@isTuesday = new [] { new SearchColumnBooleanField { customLabel = "isTuesday" } } },
                    { "isWednesday", r => r.@isWednesday = new [] { new SearchColumnBooleanField { customLabel = "isWednesday" } } },
                    { "latitude", r => r.@latitude = new [] { new SearchColumnDoubleField { customLabel = "latitude" } } },
                    { "locationType", r => r.@locationType = new [] { new SearchColumnEnumSelectField { customLabel = "locationType" } } },
                    { "longitude", r => r.@longitude = new [] { new SearchColumnDoubleField { customLabel = "longitude" } } },
                    { "makeInventoryAvailable", r => r.@makeInventoryAvailable = new [] { new SearchColumnBooleanField { customLabel = "makeInventoryAvailable" } } },
                    { "makeInventoryAvailableStore", r => r.@makeInventoryAvailableStore = new [] { new SearchColumnBooleanField { customLabel = "makeInventoryAvailableStore" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "nameNoHierarchy", r => r.@nameNoHierarchy = new [] { new SearchColumnStringField { customLabel = "nameNoHierarchy" } } },
                    { "nextPickupCutOffTime", r => r.@nextPickupCutOffTime = new [] { new SearchColumnDateField { customLabel = "nextPickupCutOffTime" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "sameDayPickupCutOffTime", r => r.@sameDayPickupCutOffTime = new [] { new SearchColumnDateField { customLabel = "sameDayPickupCutOffTime" } } },
                    { "startTime", r => r.@startTime = new [] { new SearchColumnDateField { customLabel = "startTime" } } },
                    { "state", r => r.@state = new [] { new SearchColumnStringField { customLabel = "state" } } },
                    { "storePickupBufferStock", r => r.@storePickupBufferStock = new [] { new SearchColumnDoubleField { customLabel = "storePickupBufferStock" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "timeZone", r => r.@timeZone = new [] { new SearchColumnEnumSelectField { customLabel = "timeZone" } } },
                    { "totalShippingCapacity", r => r.@totalShippingCapacity = new [] { new SearchColumnLongField { customLabel = "totalShippingCapacity" } } },
                    { "tranPrefix", r => r.@tranPrefix = new [] { new SearchColumnStringField { customLabel = "tranPrefix" } } },
                    { "usesBins", r => r.@usesBins = new [] { new SearchColumnBooleanField { customLabel = "usesBins" } } },
                    { "zip", r => r.@zip = new [] { new SearchColumnStringField { customLabel = "zip" } } },
                };
            }
        }
    }
}