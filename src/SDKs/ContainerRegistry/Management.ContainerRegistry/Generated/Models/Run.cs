// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Run resource properties
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Run : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Run class.
        /// </summary>
        public Run()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Run class.
        /// </summary>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="runId">The unique identifier for the run.</param>
        /// <param name="status">The current status of the run. Possible values
        /// include: 'Queued', 'Started', 'Running', 'Succeeded', 'Failed',
        /// 'Canceled', 'Error', 'Timeout'</param>
        /// <param name="lastUpdatedTime">The last updated time for the
        /// run.</param>
        /// <param name="runType">The type of run. Possible values include:
        /// 'QuickBuild', 'QuickRun', 'AutoBuild', 'AutoRun'</param>
        /// <param name="createTime">The time the run was scheduled.</param>
        /// <param name="startTime">The time the run started.</param>
        /// <param name="finishTime">The time the run finished.</param>
        /// <param name="outputImages">The list of all images that were
        /// generated from the run. This is applicable if the run generates
        /// base image dependencies.</param>
        /// <param name="task">The task against which run was
        /// scheduled.</param>
        /// <param name="imageUpdateTrigger">The image update trigger that
        /// caused the run. This is applicable if the task has base image
        /// trigger configured.</param>
        /// <param name="sourceTrigger">The source trigger that caused the
        /// run.</param>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled or not.</param>
        /// <param name="platform">The platform properties against which the
        /// run will happen.</param>
        /// <param name="agentConfiguration">The machine configuration of the
        /// run agent.</param>
        /// <param name="provisioningState">The provisioning state of a run.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed', 'Canceled'</param>
        public Run(string id = default(string), string name = default(string), string type = default(string), string runId = default(string), string status = default(string), System.DateTime? lastUpdatedTime = default(System.DateTime?), string runType = default(string), System.DateTime? createTime = default(System.DateTime?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? finishTime = default(System.DateTime?), IList<ImageDescriptor> outputImages = default(IList<ImageDescriptor>), string task = default(string), ImageUpdateTrigger imageUpdateTrigger = default(ImageUpdateTrigger), SourceTriggerDescriptor sourceTrigger = default(SourceTriggerDescriptor), bool? isArchiveEnabled = default(bool?), PlatformProperties platform = default(PlatformProperties), AgentProperties agentConfiguration = default(AgentProperties), string provisioningState = default(string))
            : base(id, name, type)
        {
            RunId = runId;
            Status = status;
            LastUpdatedTime = lastUpdatedTime;
            RunType = runType;
            CreateTime = createTime;
            StartTime = startTime;
            FinishTime = finishTime;
            OutputImages = outputImages;
            Task = task;
            ImageUpdateTrigger = imageUpdateTrigger;
            SourceTrigger = sourceTrigger;
            IsArchiveEnabled = isArchiveEnabled;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique identifier for the run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runId")]
        public string RunId { get; set; }

        /// <summary>
        /// Gets or sets the current status of the run. Possible values
        /// include: 'Queued', 'Started', 'Running', 'Succeeded', 'Failed',
        /// 'Canceled', 'Error', 'Timeout'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the last updated time for the run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets the type of run. Possible values include:
        /// 'QuickBuild', 'QuickRun', 'AutoBuild', 'AutoRun'
        /// </summary>
        [JsonProperty(PropertyName = "properties.runType")]
        public string RunType { get; set; }

        /// <summary>
        /// Gets or sets the time the run was scheduled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createTime")]
        public System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the time the run started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time the run finished.
        /// </summary>
        [JsonProperty(PropertyName = "properties.finishTime")]
        public System.DateTime? FinishTime { get; set; }

        /// <summary>
        /// Gets or sets the list of all images that were generated from the
        /// run. This is applicable if the run generates base image
        /// dependencies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputImages")]
        public IList<ImageDescriptor> OutputImages { get; set; }

        /// <summary>
        /// Gets or sets the task against which run was scheduled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.task")]
        public string Task { get; set; }

        /// <summary>
        /// Gets or sets the image update trigger that caused the run. This is
        /// applicable if the task has base image trigger configured.
        /// </summary>
        [JsonProperty(PropertyName = "properties.imageUpdateTrigger")]
        public ImageUpdateTrigger ImageUpdateTrigger { get; set; }

        /// <summary>
        /// Gets or sets the source trigger that caused the run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceTrigger")]
        public SourceTriggerDescriptor SourceTrigger { get; set; }

        /// <summary>
        /// Gets or sets the value that indicates whether archiving is enabled
        /// or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isArchiveEnabled")]
        public bool? IsArchiveEnabled { get; set; }

        /// <summary>
        /// Gets or sets the platform properties against which the run will
        /// happen.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platform")]
        public PlatformProperties Platform { get; set; }

        /// <summary>
        /// Gets or sets the machine configuration of the run agent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentConfiguration")]
        public AgentProperties AgentConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of a run. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Platform != null)
            {
                Platform.Validate();
            }
        }
    }
}
