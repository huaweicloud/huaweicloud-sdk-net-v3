using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 日志导出配置
    /// </summary>
    public class LogExportConfig 
    {

        /// <summary>
        /// **参数解释**：日志版本号。 **约束限制**： - 日志版本取值为v0、v1，默认为v0。 **取值范围**：v0、v1 **默认取值**：v0。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**：是否开启日志分时段下载。 **约束限制**：不涉及。 **取值范围**： - true：开启日志分时段下载 - false：关闭日志分时段下载 **默认取值**：false。
        /// </summary>
        [JsonProperty("rotation_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RotationEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogExportConfig {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  rotationEnabled: ").Append(RotationEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogExportConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogExportConfig input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.RotationEnabled != input.RotationEnabled || (this.RotationEnabled != null && !this.RotationEnabled.Equals(input.RotationEnabled))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.RotationEnabled != null) hashCode = hashCode * 59 + this.RotationEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
