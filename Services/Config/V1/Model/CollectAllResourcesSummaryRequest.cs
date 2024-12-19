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
    /// Request Object
    /// </summary>
    public class CollectAllResourcesSummaryRequest 
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源类型（provider.type）
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 区域ID列表
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionId { get; set; }

        /// <summary>
        /// 企业项目ID列表
        /// </summary>
        [SDKProperty("ep_id", IsQuery = true)]
        [JsonProperty("ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EpId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProjectId { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectAllResourcesSummaryRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  epId: ").Append(EpId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectAllResourcesSummaryRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectAllResourcesSummaryRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && input.RegionId != null && !this.RegionId.SequenceEqual(input.RegionId))) return false;
            if (this.EpId != input.EpId || (this.EpId != null && input.EpId != null && !this.EpId.SequenceEqual(input.EpId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && input.ProjectId != null && !this.ProjectId.SequenceEqual(input.ProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.EpId != null) hashCode = hashCode * 59 + this.EpId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
