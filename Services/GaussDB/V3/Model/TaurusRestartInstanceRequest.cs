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
    /// 重启实例
    /// </summary>
    public class TaurusRestartInstanceRequest 
    {

        /// <summary>
        /// 实例是否延迟重启，默认false，立即重启。  - true: 延迟重启，实例将在运维时间窗内自动重启。 - false: 立即重启。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delay { get; set; }

        /// <summary>
        /// **参数解释**：  实例重启后生效的max_connections内核参数配置值。max_connections用于设置允许同时连接到数据库实例的最大客户端连接数。  **约束限制**：  不涉及。  **取值范围**： 30-100000。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("max_connections", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConnections { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaurusRestartInstanceRequest {\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  maxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaurusRestartInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaurusRestartInstanceRequest input)
        {
            if (input == null) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.MaxConnections != input.MaxConnections || (this.MaxConnections != null && !this.MaxConnections.Equals(input.MaxConnections))) return false;

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
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.MaxConnections != null) hashCode = hashCode * 59 + this.MaxConnections.GetHashCode();
                return hashCode;
            }
        }
    }
}
