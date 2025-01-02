using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 资源历史
    /// </summary>
    public class HistoryItem 
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 该资源在Config系统捕获时间
        /// </summary>
        [JsonProperty("capture_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CaptureTime { get; set; }

        /// <summary>
        /// 资源状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 资源关系列表
        /// </summary>
        [JsonProperty("relations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceRelation> Relations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public BaseResourceEntity Resource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryItem {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  captureTime: ").Append(CaptureTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  relations: ").Append(Relations).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistoryItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HistoryItem input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.CaptureTime != input.CaptureTime || (this.CaptureTime != null && !this.CaptureTime.Equals(input.CaptureTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Relations != input.Relations || (this.Relations != null && input.Relations != null && !this.Relations.SequenceEqual(input.Relations))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CaptureTime != null) hashCode = hashCode * 59 + this.CaptureTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Relations != null) hashCode = hashCode * 59 + this.Relations.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }
    }
}
