// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Encoder disconnected event data.
    /// </summary>
    public partial class MediaLiveEventEncoderDisconnectedEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventEncoderDisconnectedEventData class.
        /// </summary>
        public MediaLiveEventEncoderDisconnectedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventEncoderDisconnectedEventData class.
        /// </summary>
        /// <param name="ingestUrl">Gets the ingest URL provided by the live
        /// event.</param>
        /// <param name="streamId">Gets the stream Id.</param>
        /// <param name="encoderIp">Gets the remote IP.</param>
        /// <param name="encoderPort">Gets the remote port.</param>
        /// <param name="resultCode">Gets the result code.</param>
        public MediaLiveEventEncoderDisconnectedEventData(string ingestUrl = default(string), string streamId = default(string), string encoderIp = default(string), string encoderPort = default(string), string resultCode = default(string))
        {
            IngestUrl = ingestUrl;
            StreamId = streamId;
            EncoderIp = encoderIp;
            EncoderPort = encoderPort;
            ResultCode = resultCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ingest URL provided by the live event.
        /// </summary>
        [JsonProperty(PropertyName = "ingestUrl")]
        public string IngestUrl { get; private set; }

        /// <summary>
        /// Gets the stream Id.
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; private set; }

        /// <summary>
        /// Gets the remote IP.
        /// </summary>
        [JsonProperty(PropertyName = "encoderIp")]
        public string EncoderIp { get; private set; }

        /// <summary>
        /// Gets the remote port.
        /// </summary>
        [JsonProperty(PropertyName = "encoderPort")]
        public string EncoderPort { get; private set; }

        /// <summary>
        /// Gets the result code.
        /// </summary>
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; private set; }

    }
}
