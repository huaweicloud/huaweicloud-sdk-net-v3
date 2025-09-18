using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCentralNetworkPoliciesRequest 
    {

        /// <summary>
        /// 中心网络的ID。
        /// </summary>
        [SDKProperty("central_network_id", IsPath = true)]
        [JsonProperty("central_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkId { get; set; }

        /// <summary>
        /// 每页返回的个数。 取值范围：1~2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 翻页信息，从上次API调用返回的翻页数据中获取，可填写前一页marker或者后一页marker，填入前一页previous_marker就向前翻页，后一页next_marker就向后翻页。 翻页过程中，查询条件不能修改，包括过滤条件、排序条件、limit。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 排序字段。
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 指定排序是升序还是降序（asc为升序，desc为降序）。
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDir? SortDir { get; set; }

        /// <summary>
        /// 根据ID查询，可查询多个ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 根据状态查询，可查询多个状态。
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public List<CentralNetworkPolicyStateEnum> State { get; set; }

        /// <summary>
        /// 根据版本查询，可查询多个版本。
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public List<Version> Version { get; set; }

        /// <summary>
        /// 是否被应用。
        /// </summary>
        [SDKProperty("is_applied", IsQuery = true)]
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsApplied { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCentralNetworkPoliciesRequest {\n");
            sb.Append("  centralNetworkId: ").Append(CentralNetworkId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  isApplied: ").Append(IsApplied).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCentralNetworkPoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCentralNetworkPoliciesRequest input)
        {
            if (input == null) return false;
            if (this.CentralNetworkId != input.CentralNetworkId || (this.CentralNetworkId != null && !this.CentralNetworkId.Equals(input.CentralNetworkId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.State != input.State || (this.State != null && input.State != null && !this.State.SequenceEqual(input.State))) return false;
            if (this.Version != input.Version || (this.Version != null && input.Version != null && !this.Version.SequenceEqual(input.Version))) return false;
            if (this.IsApplied != input.IsApplied || (this.IsApplied != null && !this.IsApplied.Equals(input.IsApplied))) return false;

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
                if (this.CentralNetworkId != null) hashCode = hashCode * 59 + this.CentralNetworkId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.IsApplied != null) hashCode = hashCode * 59 + this.IsApplied.GetHashCode();
                return hashCode;
            }
        }
    }
}
