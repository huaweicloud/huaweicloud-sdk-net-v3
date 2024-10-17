using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 资源栈
    /// </summary>
    public class StackResource 
    {

        /// <summary>
        /// 物理资源id
        /// </summary>
        [JsonProperty("physical_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// 物理资源名称
        /// </summary>
        [JsonProperty("physical_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalResourceName { get; set; }

        /// <summary>
        /// 逻辑资源名称
        /// </summary>
        [JsonProperty("logical_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicalResourceName { get; set; }

        /// <summary>
        /// 逻辑资源类型
        /// </summary>
        [JsonProperty("logical_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicalResourceType { get; set; }

        /// <summary>
        /// 资源状态
        /// </summary>
        [JsonProperty("resource_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceStatus { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 超链接地址
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackResource {\n");
            sb.Append("  physicalResourceId: ").Append(PhysicalResourceId).Append("\n");
            sb.Append("  physicalResourceName: ").Append(PhysicalResourceName).Append("\n");
            sb.Append("  logicalResourceName: ").Append(LogicalResourceName).Append("\n");
            sb.Append("  logicalResourceType: ").Append(LogicalResourceType).Append("\n");
            sb.Append("  resourceStatus: ").Append(ResourceStatus).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  href: ").Append(Href).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackResource input)
        {
            if (input == null) return false;
            if (this.PhysicalResourceId != input.PhysicalResourceId || (this.PhysicalResourceId != null && !this.PhysicalResourceId.Equals(input.PhysicalResourceId))) return false;
            if (this.PhysicalResourceName != input.PhysicalResourceName || (this.PhysicalResourceName != null && !this.PhysicalResourceName.Equals(input.PhysicalResourceName))) return false;
            if (this.LogicalResourceName != input.LogicalResourceName || (this.LogicalResourceName != null && !this.LogicalResourceName.Equals(input.LogicalResourceName))) return false;
            if (this.LogicalResourceType != input.LogicalResourceType || (this.LogicalResourceType != null && !this.LogicalResourceType.Equals(input.LogicalResourceType))) return false;
            if (this.ResourceStatus != input.ResourceStatus || (this.ResourceStatus != null && !this.ResourceStatus.Equals(input.ResourceStatus))) return false;
            if (this.StatusMessage != input.StatusMessage || (this.StatusMessage != null && !this.StatusMessage.Equals(input.StatusMessage))) return false;
            if (this.Href != input.Href || (this.Href != null && !this.Href.Equals(input.Href))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;

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
                if (this.PhysicalResourceId != null) hashCode = hashCode * 59 + this.PhysicalResourceId.GetHashCode();
                if (this.PhysicalResourceName != null) hashCode = hashCode * 59 + this.PhysicalResourceName.GetHashCode();
                if (this.LogicalResourceName != null) hashCode = hashCode * 59 + this.LogicalResourceName.GetHashCode();
                if (this.LogicalResourceType != null) hashCode = hashCode * 59 + this.LogicalResourceType.GetHashCode();
                if (this.ResourceStatus != null) hashCode = hashCode * 59 + this.ResourceStatus.GetHashCode();
                if (this.StatusMessage != null) hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.Href != null) hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }
    }
}
