using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResourceAssociationsRequest 
    {

        /// <summary>
        /// **参数解释**： 资源ID，填写后按照ID进行过滤，支持传入多个ID过滤。 **取值范围**： 弹性网卡/辅助弹性网卡的资源ID。
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 资源的类型，填写后按照资源类型进行过滤，支持传入多个资源类型过滤。 **取值范围**： - port：弹性网卡。 - subeni：辅助弹性网卡。
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceType { get; set; }

        /// <summary>
        /// **参数解释**： 资源所属的项目ID，填写后按照项目ID进行过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("resource_project_id", IsQuery = true)]
        [JsonProperty("resource_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 实例ID，填写后按照ID进行过滤，支持传入多个ID过滤。 **取值范围**： ELB实例的ID。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 实例的类型，填写后按照实例类型进行过滤，支持传入多个实例类型过滤。 **取值范围**： - ELB：ELB实例。
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceType { get; set; }

        /// <summary>
        /// **参数解释**： 实例所属的项目ID，填写后按照项目ID进行过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("instance_project_id", IsQuery = true)]
        [JsonProperty("instance_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 每页返回的个数。 **取值范围**： 0-2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 分页查询起始的资源ID，为空时查询第一页。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceAssociationsRequest {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceProjectId: ").Append(ResourceProjectId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  instanceProjectId: ").Append(InstanceProjectId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceAssociationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceAssociationsRequest input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && input.ResourceId != null && !this.ResourceId.SequenceEqual(input.ResourceId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && input.ResourceType != null && !this.ResourceType.SequenceEqual(input.ResourceType))) return false;
            if (this.ResourceProjectId != input.ResourceProjectId || (this.ResourceProjectId != null && !this.ResourceProjectId.Equals(input.ResourceProjectId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && input.InstanceId != null && !this.InstanceId.SequenceEqual(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && input.InstanceType != null && !this.InstanceType.SequenceEqual(input.InstanceType))) return false;
            if (this.InstanceProjectId != input.InstanceProjectId || (this.InstanceProjectId != null && !this.InstanceProjectId.Equals(input.InstanceProjectId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceProjectId != null) hashCode = hashCode * 59 + this.ResourceProjectId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.InstanceProjectId != null) hashCode = hashCode * 59 + this.InstanceProjectId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
