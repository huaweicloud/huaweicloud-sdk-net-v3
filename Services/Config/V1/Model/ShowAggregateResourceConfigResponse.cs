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
    /// Response Object
    /// </summary>
    public class ShowAggregateResourceConfigResponse : SdkResponse
    {

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 聚合器ID。
        /// </summary>
        [JsonProperty("aggregator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// 聚合器帐号。
        /// </summary>
        [JsonProperty("aggregator_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorDomainId { get; set; }

        /// <summary>
        /// 聚合资源所属帐号的ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpId { get; set; }

        /// <summary>
        /// 云服务名称。
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 资源名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// Openstack中的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 资源创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 资源更新时间。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 资源详细属性。
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Properties { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAggregateResourceConfigResponse {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  aggregatorId: ").Append(AggregatorId).Append("\n");
            sb.Append("  aggregatorDomainId: ").Append(AggregatorDomainId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  epId: ").Append(EpId).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAggregateResourceConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAggregateResourceConfigResponse input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.AggregatorId != input.AggregatorId || (this.AggregatorId != null && !this.AggregatorId.Equals(input.AggregatorId))) return false;
            if (this.AggregatorDomainId != input.AggregatorDomainId || (this.AggregatorDomainId != null && !this.AggregatorDomainId.Equals(input.AggregatorDomainId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.EpId != input.EpId || (this.EpId != null && !this.EpId.Equals(input.EpId))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && input.Properties != null && !this.Properties.SequenceEqual(input.Properties))) return false;

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
                if (this.AggregatorId != null) hashCode = hashCode * 59 + this.AggregatorId.GetHashCode();
                if (this.AggregatorDomainId != null) hashCode = hashCode * 59 + this.AggregatorDomainId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.EpId != null) hashCode = hashCode * 59 + this.EpId.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }
}
