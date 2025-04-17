using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDDosStatusResponse : SdkResponse
    {

        /// <summary>
        /// 弹性IP总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 防护状态列表
        /// </summary>
        [JsonProperty("ddosStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<DDosStatus> DdosStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDDosStatusResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  ddosStatus: ").Append(DdosStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDDosStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDDosStatusResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.DdosStatus != input.DdosStatus || (this.DdosStatus != null && input.DdosStatus != null && !this.DdosStatus.SequenceEqual(input.DdosStatus))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.DdosStatus != null) hashCode = hashCode * 59 + this.DdosStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
