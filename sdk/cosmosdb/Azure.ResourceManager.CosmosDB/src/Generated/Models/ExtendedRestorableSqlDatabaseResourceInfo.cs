// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB SQL database event. </summary>
    public partial class ExtendedRestorableSqlDatabaseResourceInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableSqlDatabaseResourceInfo"/>. </summary>
        internal ExtendedRestorableSqlDatabaseResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableSqlDatabaseResourceInfo"/>. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this database event. </param>
        /// <param name="canUndelete"> A state of this database to identify if this database is restorable in same account. </param>
        /// <param name="canUndeleteReason"> The reason why this database can not be restored in same account. </param>
        /// <param name="eventTimestamp"> The time when this database event happened. </param>
        /// <param name="databaseName"> The name of the SQL database. </param>
        /// <param name="databaseId"> The resource ID of the SQL database. </param>
        /// <param name="database"> Cosmos DB SQL database resource object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedRestorableSqlDatabaseResourceInfo(string rid, CosmosDBOperationType? operationType, string canUndelete, string canUndeleteReason, string eventTimestamp, string databaseName, string databaseId, RestorableSqlDatabasePropertiesResourceDatabase database, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rid = rid;
            OperationType = operationType;
            CanUndelete = canUndelete;
            CanUndeleteReason = canUndeleteReason;
            EventTimestamp = eventTimestamp;
            DatabaseName = databaseName;
            DatabaseId = databaseId;
            Database = database;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        [WirePath("_rid")]
        public string Rid { get; }
        /// <summary> The operation type of this database event. </summary>
        [WirePath("operationType")]
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> A state of this database to identify if this database is restorable in same account. </summary>
        [WirePath("canUndelete")]
        public string CanUndelete { get; }
        /// <summary> The reason why this database can not be restored in same account. </summary>
        [WirePath("canUndeleteReason")]
        public string CanUndeleteReason { get; }
        /// <summary> The time when this database event happened. </summary>
        [WirePath("eventTimestamp")]
        public string EventTimestamp { get; }
        /// <summary> The name of the SQL database. </summary>
        [WirePath("ownerId")]
        public string DatabaseName { get; }
        /// <summary> The resource ID of the SQL database. </summary>
        [WirePath("ownerResourceId")]
        public string DatabaseId { get; }
        /// <summary> Cosmos DB SQL database resource object. </summary>
        [WirePath("database")]
        public RestorableSqlDatabasePropertiesResourceDatabase Database { get; }
    }
}
