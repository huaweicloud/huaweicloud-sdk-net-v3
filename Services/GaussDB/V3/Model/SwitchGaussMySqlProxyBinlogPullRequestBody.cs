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
    /// 
    /// </summary>
    public class SwitchGaussMySqlProxyBinlogPullRequestBody 
    {

        /// <summary>
        /// **参数解释**：  数据库代理模式。  **约束限制**：  不涉及。  **取值范围**： - readwrite：读写模式。 - readonly：TP只读模式。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：  数据库代理拉取Binlog开关。  **约束限制**：  不涉及。  **取值范围**： - true：开启。 - false：关闭。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("support_binlog_pull", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportBinlogPull { get; set; }

        /// <summary>
        /// **参数解释**： 数据库代理是否从数据库主节点拉取Binlog。  **约束限制**：  - 读写代理可以设置从数据库主节点或者只读节点拉取Binlog，TP只读代理只支持从只读节点拉取Binlog。 - binlog_route_master参数仅在support_binlog_pull为true时生效。  **取值范围**： - true：从主节点拉取。 - false：从只读节点拉取。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("binlog_route_master", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BinlogRouteMaster { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchGaussMySqlProxyBinlogPullRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  supportBinlogPull: ").Append(SupportBinlogPull).Append("\n");
            sb.Append("  binlogRouteMaster: ").Append(BinlogRouteMaster).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchGaussMySqlProxyBinlogPullRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchGaussMySqlProxyBinlogPullRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.SupportBinlogPull != input.SupportBinlogPull || (this.SupportBinlogPull != null && !this.SupportBinlogPull.Equals(input.SupportBinlogPull))) return false;
            if (this.BinlogRouteMaster != input.BinlogRouteMaster || (this.BinlogRouteMaster != null && !this.BinlogRouteMaster.Equals(input.BinlogRouteMaster))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SupportBinlogPull != null) hashCode = hashCode * 59 + this.SupportBinlogPull.GetHashCode();
                if (this.BinlogRouteMaster != null) hashCode = hashCode * 59 + this.BinlogRouteMaster.GetHashCode();
                return hashCode;
            }
        }
    }
}
