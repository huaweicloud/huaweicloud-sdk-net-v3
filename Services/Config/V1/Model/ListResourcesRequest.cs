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
    public class ListResourcesRequest 
    {

        /// <summary>
        /// 云服务名称
        /// </summary>
        [SDKProperty("provider", IsPath = true)]
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [SDKProperty("type", IsPath = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [SDKProperty("ep_id", IsQuery = true)]
        [JsonProperty("ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> Tag { get; set; }

        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
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
            sb.Append("class ListResourcesRequest {\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  epId: ").Append(EpId).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as ListResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourcesRequest input)
        {
            if (input == null) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.EpId != input.EpId || (this.EpId != null && !this.EpId.Equals(input.EpId))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && input.Tag != null && !this.Tag.SequenceEqual(input.Tag))) return false;
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
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.EpId != null) hashCode = hashCode * 59 + this.EpId.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
