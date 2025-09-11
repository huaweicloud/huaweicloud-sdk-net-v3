using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHbaInfoHistoryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: hba修改历史信息。
        /// </summary>
        [JsonProperty("hba_confs", NullValueHandling = NullValueHandling.Ignore)]
        public List<HbaHistoryResult> HbaConfs { get; set; }

        /// <summary>
        /// **参数解释**: hba配置总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHbaInfoHistoryResponse {\n");
            sb.Append("  hbaConfs: ").Append(HbaConfs).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHbaInfoHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHbaInfoHistoryResponse input)
        {
            if (input == null) return false;
            if (this.HbaConfs != input.HbaConfs || (this.HbaConfs != null && input.HbaConfs != null && !this.HbaConfs.SequenceEqual(input.HbaConfs))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.HbaConfs != null) hashCode = hashCode * 59 + this.HbaConfs.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
