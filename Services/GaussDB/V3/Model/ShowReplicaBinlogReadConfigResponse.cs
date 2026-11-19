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
    public class ShowReplicaBinlogReadConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  实例是否支持开启只读Binlog拉取。  **取值范围**：  - true：支持。 - false：不支持。
        /// </summary>
        [JsonProperty("supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supported { get; set; }

        /// <summary>
        /// **参数解释**：  只读Binlog拉取开关状态。  **取值范围**：  - true：开启。 - false：关闭。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplicaBinlogReadConfigResponse {\n");
            sb.Append("  supported: ").Append(Supported).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplicaBinlogReadConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplicaBinlogReadConfigResponse input)
        {
            if (input == null) return false;
            if (this.Supported != input.Supported || (this.Supported != null && !this.Supported.Equals(input.Supported))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                if (this.Supported != null) hashCode = hashCode * 59 + this.Supported.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
