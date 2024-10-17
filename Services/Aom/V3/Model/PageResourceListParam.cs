using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PageResourceListParam 
    {

        /// <summary>
        /// 页面的分页标志位,为分页的最后一条记录的id
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 查询返回记录的数量限制。limit可以为空，如果值小于1或者大于100，则会使用默认值100
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 关键字模糊搜索。Key取值：NAME、RESOURCE_ID
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Keywords { get; set; }

        /// <summary>
        /// 是否需要返回拓扑树,默认是false。需要：true- --性能差，不需要false- -性能好
        /// </summary>
        [JsonProperty("ci_relationships", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CiRelationships { get; set; }

        /// <summary>
        /// 节点类型，取值：application、sub_application、component、environment
        /// </summary>
        [JsonProperty("ci_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CiType { get; set; }

        /// <summary>
        /// 环境的region信息，若没有值，代表全部
        /// </summary>
        [JsonProperty("ci_region", NullValueHandling = NullValueHandling.Ignore)]
        public string CiRegion { get; set; }

        /// <summary>
        /// 节点id列表;如果ci_ids和ci_id同时有，则优先ci_ids，但是不能同时为空
        /// </summary>
        [JsonProperty("ci_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CiIds { get; set; }

        /// <summary>
        /// 节点id列表;如果ci_ids和ci_id同时有，则优先ci_ids，但是不能同时为空。但是不支持应用批量查询
        /// </summary>
        [JsonProperty("ci_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CiId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageResourceListParam {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  ciRelationships: ").Append(CiRelationships).Append("\n");
            sb.Append("  ciType: ").Append(CiType).Append("\n");
            sb.Append("  ciRegion: ").Append(CiRegion).Append("\n");
            sb.Append("  ciIds: ").Append(CiIds).Append("\n");
            sb.Append("  ciId: ").Append(CiId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageResourceListParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageResourceListParam input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;
            if (this.CiRelationships != input.CiRelationships || (this.CiRelationships != null && !this.CiRelationships.Equals(input.CiRelationships))) return false;
            if (this.CiType != input.CiType || (this.CiType != null && !this.CiType.Equals(input.CiType))) return false;
            if (this.CiRegion != input.CiRegion || (this.CiRegion != null && !this.CiRegion.Equals(input.CiRegion))) return false;
            if (this.CiIds != input.CiIds || (this.CiIds != null && input.CiIds != null && !this.CiIds.SequenceEqual(input.CiIds))) return false;
            if (this.CiId != input.CiId || (this.CiId != null && !this.CiId.Equals(input.CiId))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.CiRelationships != null) hashCode = hashCode * 59 + this.CiRelationships.GetHashCode();
                if (this.CiType != null) hashCode = hashCode * 59 + this.CiType.GetHashCode();
                if (this.CiRegion != null) hashCode = hashCode * 59 + this.CiRegion.GetHashCode();
                if (this.CiIds != null) hashCode = hashCode * 59 + this.CiIds.GetHashCode();
                if (this.CiId != null) hashCode = hashCode * 59 + this.CiId.GetHashCode();
                return hashCode;
            }
        }
    }
}
