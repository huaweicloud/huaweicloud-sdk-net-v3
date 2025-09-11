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
    /// 
    /// </summary>
    public class RestoreHbaInfoRequestBody 
    {

        /// <summary>
        /// **参数解释**: 客户端接入认证修改历史记录ID。 **取值范围**: 传空时表示恢复默认。 
        /// </summary>
        [JsonProperty("hba_history_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HbaHistoryId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreHbaInfoRequestBody {\n");
            sb.Append("  hbaHistoryId: ").Append(HbaHistoryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreHbaInfoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreHbaInfoRequestBody input)
        {
            if (input == null) return false;
            if (this.HbaHistoryId != input.HbaHistoryId || (this.HbaHistoryId != null && !this.HbaHistoryId.Equals(input.HbaHistoryId))) return false;

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
                if (this.HbaHistoryId != null) hashCode = hashCode * 59 + this.HbaHistoryId.GetHashCode();
                return hashCode;
            }
        }
    }
}
