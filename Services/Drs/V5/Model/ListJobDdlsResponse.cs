using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListJobDdlsResponse : SdkResponse
    {

        /// <summary>
        /// DDL告警信息列表。
        /// </summary>
        [JsonProperty("ddl_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DdlAlarmResp> DdlList { get; set; }

        /// <summary>
        /// 列表中的项目总数，与分页无关。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobDdlsResponse {\n");
            sb.Append("  ddlList: ").Append(DdlList).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobDdlsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobDdlsResponse input)
        {
            if (input == null) return false;
            if (this.DdlList != input.DdlList || (this.DdlList != null && input.DdlList != null && !this.DdlList.SequenceEqual(input.DdlList))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.DdlList != null) hashCode = hashCode * 59 + this.DdlList.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
