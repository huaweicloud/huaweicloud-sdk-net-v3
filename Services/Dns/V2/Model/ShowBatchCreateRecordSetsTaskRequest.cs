using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowBatchCreateRecordSetsTaskRequest 
    {

        /// <summary>
        /// **参数解释：** 域名ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("zone_id", IsPath = true)]
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// **参数解释：** 分页查询时配置每页返回的失败条目个数。 **约束限制：** 不涉及。 **取值范围：** 0~2000。 **默认取值：** 2000
        /// </summary>
        [SDKProperty("error_item_limit", IsQuery = true)]
        [JsonProperty("error_item_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorItemLimit { get; set; }

        /// <summary>
        /// **参数解释：** 分页查询起始偏移量，表示从偏移量的下一个失败条目开始查询。 **约束限制：** 不涉及。 **取值范围：** 0~2000。 **默认取值：** 0
        /// </summary>
        [SDKProperty("error_item_offset", IsQuery = true)]
        [JsonProperty("error_item_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorItemOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBatchCreateRecordSetsTaskRequest {\n");
            sb.Append("  zoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  errorItemLimit: ").Append(ErrorItemLimit).Append("\n");
            sb.Append("  errorItemOffset: ").Append(ErrorItemOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBatchCreateRecordSetsTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBatchCreateRecordSetsTaskRequest input)
        {
            if (input == null) return false;
            if (this.ZoneId != input.ZoneId || (this.ZoneId != null && !this.ZoneId.Equals(input.ZoneId))) return false;
            if (this.ErrorItemLimit != input.ErrorItemLimit || (this.ErrorItemLimit != null && !this.ErrorItemLimit.Equals(input.ErrorItemLimit))) return false;
            if (this.ErrorItemOffset != input.ErrorItemOffset || (this.ErrorItemOffset != null && !this.ErrorItemOffset.Equals(input.ErrorItemOffset))) return false;

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
                if (this.ZoneId != null) hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.ErrorItemLimit != null) hashCode = hashCode * 59 + this.ErrorItemLimit.GetHashCode();
                if (this.ErrorItemOffset != null) hashCode = hashCode * 59 + this.ErrorItemOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
