using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDrInfosResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 实例容灾信息
        /// </summary>
        [JsonProperty("instance_dr_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceDrInfo> InstanceDrInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDrInfosResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  instanceDrInfos: ").Append(InstanceDrInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDrInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDrInfosResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.InstanceDrInfos != input.InstanceDrInfos || (this.InstanceDrInfos != null && input.InstanceDrInfos != null && !this.InstanceDrInfos.SequenceEqual(input.InstanceDrInfos))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.InstanceDrInfos != null) hashCode = hashCode * 59 + this.InstanceDrInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
