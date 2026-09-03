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
    /// 更改数据库代理慢日志上报开关请求体
    /// </summary>
    public class SwitchMySqlProxySlowLogRequestBody 
    {

        /// <summary>
        /// **参数解释**：  慢日志上报开关。  **约束限制**：  不涉及。  **取值范围**：  - on：开启。 - off：关闭。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("lts_slow_log_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsSlowLogEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchMySqlProxySlowLogRequestBody {\n");
            sb.Append("  ltsSlowLogEnabled: ").Append(LtsSlowLogEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchMySqlProxySlowLogRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchMySqlProxySlowLogRequestBody input)
        {
            if (input == null) return false;
            if (this.LtsSlowLogEnabled != input.LtsSlowLogEnabled || (this.LtsSlowLogEnabled != null && !this.LtsSlowLogEnabled.Equals(input.LtsSlowLogEnabled))) return false;

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
                if (this.LtsSlowLogEnabled != null) hashCode = hashCode * 59 + this.LtsSlowLogEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
