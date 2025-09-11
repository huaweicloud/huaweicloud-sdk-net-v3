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
    public class ShowSessionOverviewResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 实时会话的活跃会话数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("active_num", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveNum { get; set; }

        /// <summary>
        /// **参数解释**: 实时会话的总会话数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalNum { get; set; }

        /// <summary>
        /// **参数解释**: 实时会话中的慢SQL数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("slow_sql_num", NullValueHandling = NullValueHandling.Ignore)]
        public string SlowSqlNum { get; set; }

        /// <summary>
        /// **参数解释**: 实时会话中的锁等会话数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("lock_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LockNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSessionOverviewResponse {\n");
            sb.Append("  activeNum: ").Append(ActiveNum).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  slowSqlNum: ").Append(SlowSqlNum).Append("\n");
            sb.Append("  lockNum: ").Append(LockNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSessionOverviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSessionOverviewResponse input)
        {
            if (input == null) return false;
            if (this.ActiveNum != input.ActiveNum || (this.ActiveNum != null && !this.ActiveNum.Equals(input.ActiveNum))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.SlowSqlNum != input.SlowSqlNum || (this.SlowSqlNum != null && !this.SlowSqlNum.Equals(input.SlowSqlNum))) return false;
            if (this.LockNum != input.LockNum || (this.LockNum != null && !this.LockNum.Equals(input.LockNum))) return false;

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
                if (this.ActiveNum != null) hashCode = hashCode * 59 + this.ActiveNum.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.SlowSqlNum != null) hashCode = hashCode * 59 + this.SlowSqlNum.GetHashCode();
                if (this.LockNum != null) hashCode = hashCode * 59 + this.LockNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
