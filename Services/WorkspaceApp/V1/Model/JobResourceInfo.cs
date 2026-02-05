using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 具体的资源信息。
    /// </summary>
    public class JobResourceInfo 
    {

        /// <summary>
        /// 客户在云服务Console上可见的资源实例Id，全局唯一，且不可更改，最大64个字符。  注：“规格变更”场景下（包括升降配），是对某个资源实例的规格进行调整，  该资源实例其他信息（比如资源Id、资源名称）和运行的业务数据不变化。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称；创建、有最新资源名称场景，必填。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 云服务类型编码；新购、规格变更场景，必填： - hws.service.type.vdi - hws.service.type.marketplace
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型编码；新购、规格变更场景，必填: -hws.resource.type.workspace.volume： 云办公桌面磁盘 -hws.resource.type.workspace.desktop： 云办公桌面 -hws.resource.type.workspace.appstream： 云应用 -hws.resource.type.workspace.appstreamsession： 云应用多会话
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源规格编码；新购、规格变更场景，必填。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 规格类型，运营上需要呈现和使用的一些规格属性，多个使用K:V格式。 比如带宽的共享/独享(shareable:true/false)，数据盘的系统盘/数据盘类型(root:true/false)。 当前针对共享带宽、共享盘使用，必填。
        /// </summary>
        [JsonProperty("spec_type", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> SpecType { get; set; }

        /// <summary>
        /// 某些规格属性大小：比如带宽大小、数据盘大小。
        /// </summary>
        [JsonProperty("spec_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? SpecSize { get; set; }

        /// <summary>
        /// specSize的单位编码，比如GB、M，有specSize时，此字段必填。
        /// </summary>
        [JsonProperty("measure", NullValueHandling = NullValueHandling.Ignore)]
        public int? Measure { get; set; }

        /// <summary>
        /// 处理时间。
        /// </summary>
        [JsonProperty("processed_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessedTime { get; set; }

        /// <summary>
        /// 该resourceId是否是主资源（仅开通场景使用，其他场景为空）。 * &#x60;1&#x60; - 是 * &#x60;0&#x60; - 否
        /// </summary>
        [JsonProperty("is_main_resource", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMainResource { get; set; }

        /// <summary>
        /// resourceId的主资源。  是挂载到/绑定到/依附到/包含于/关联到资源，比如IP的主资源‘云主机’、数据盘的主资源‘云主机’。  如果resourceId是依附在多个资源上，则有多个主资源，比如共享盘挂载到多个云主机上。  无关联主资源，则空，比如独立未挂载的数据盘。
        /// </summary>
        [JsonProperty("main_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelativeResource> MainResources { get; set; }

        /// <summary>
        /// expireTime：到期时间，域名注册服务使用。  UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ（2016-06-28T00:00:00Z）。
        /// </summary>
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 仅针对ECS/BMS云服务的“切换操作系统”场景使用。 云主机切换操作系统的资源id会变化场景。 填写变更前老的资源Id。资源Id未变化，无此字段。
        /// </summary>
        [JsonProperty("old_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OldResourceId { get; set; }

        /// <summary>
        /// 仅针对ECS/BMS云服务的“切换操作系统”场景使用：云主机切换操作系统的云服务类型编码会变化场景。 填写变更前老的云服务类型编码。云服务类型未变化，无此字段。
        /// </summary>
        [JsonProperty("old_cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OldCloudServiceType { get; set; }

        /// <summary>
        /// 仅针对ECS/BMS云服务“切换操作系统”场景使用。 云主机切换操作系统的资源类型编码会变化场景。 填写变更前老的资源类型编码。资源类型未变化，无此字段。
        /// </summary>
        [JsonProperty("old_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OldResourceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobResourceInfo {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  specType: ").Append(SpecType).Append("\n");
            sb.Append("  specSize: ").Append(SpecSize).Append("\n");
            sb.Append("  measure: ").Append(Measure).Append("\n");
            sb.Append("  processedTime: ").Append(ProcessedTime).Append("\n");
            sb.Append("  isMainResource: ").Append(IsMainResource).Append("\n");
            sb.Append("  mainResources: ").Append(MainResources).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  oldResourceId: ").Append(OldResourceId).Append("\n");
            sb.Append("  oldCloudServiceType: ").Append(OldCloudServiceType).Append("\n");
            sb.Append("  oldResourceType: ").Append(OldResourceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobResourceInfo input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.SpecType != input.SpecType || (this.SpecType != null && input.SpecType != null && !this.SpecType.SequenceEqual(input.SpecType))) return false;
            if (this.SpecSize != input.SpecSize || (this.SpecSize != null && !this.SpecSize.Equals(input.SpecSize))) return false;
            if (this.Measure != input.Measure || (this.Measure != null && !this.Measure.Equals(input.Measure))) return false;
            if (this.ProcessedTime != input.ProcessedTime || (this.ProcessedTime != null && !this.ProcessedTime.Equals(input.ProcessedTime))) return false;
            if (this.IsMainResource != input.IsMainResource || (this.IsMainResource != null && !this.IsMainResource.Equals(input.IsMainResource))) return false;
            if (this.MainResources != input.MainResources || (this.MainResources != null && input.MainResources != null && !this.MainResources.SequenceEqual(input.MainResources))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;
            if (this.OldResourceId != input.OldResourceId || (this.OldResourceId != null && !this.OldResourceId.Equals(input.OldResourceId))) return false;
            if (this.OldCloudServiceType != input.OldCloudServiceType || (this.OldCloudServiceType != null && !this.OldCloudServiceType.Equals(input.OldCloudServiceType))) return false;
            if (this.OldResourceType != input.OldResourceType || (this.OldResourceType != null && !this.OldResourceType.Equals(input.OldResourceType))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.SpecType != null) hashCode = hashCode * 59 + this.SpecType.GetHashCode();
                if (this.SpecSize != null) hashCode = hashCode * 59 + this.SpecSize.GetHashCode();
                if (this.Measure != null) hashCode = hashCode * 59 + this.Measure.GetHashCode();
                if (this.ProcessedTime != null) hashCode = hashCode * 59 + this.ProcessedTime.GetHashCode();
                if (this.IsMainResource != null) hashCode = hashCode * 59 + this.IsMainResource.GetHashCode();
                if (this.MainResources != null) hashCode = hashCode * 59 + this.MainResources.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                if (this.OldResourceId != null) hashCode = hashCode * 59 + this.OldResourceId.GetHashCode();
                if (this.OldCloudServiceType != null) hashCode = hashCode * 59 + this.OldCloudServiceType.GetHashCode();
                if (this.OldResourceType != null) hashCode = hashCode * 59 + this.OldResourceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
