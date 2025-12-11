using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAutoSqlLimitingLogResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  查询自治限流执行记录列表。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AutoSqlLimitingLog> Logs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoSqlLimitingLogResponse {\n");
            sb.Append("  logs: ").Append(Logs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoSqlLimitingLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoSqlLimitingLogResponse input)
        {
            if (input == null) return false;
            if (this.Logs != input.Logs || (this.Logs != null && input.Logs != null && !this.Logs.SequenceEqual(input.Logs))) return false;

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
                if (this.Logs != null) hashCode = hashCode * 59 + this.Logs.GetHashCode();
                return hashCode;
            }
        }
    }
}
