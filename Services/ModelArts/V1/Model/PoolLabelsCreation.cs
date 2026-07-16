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
    /// 资源池标签信息。
    /// </summary>
    public class PoolLabelsCreation 
    {

        /// <summary>
        /// **参数解释**：用户指定的资源池名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsName { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc) **约束限制**：不涉及。 **取值范围**：未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/workspace.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsWorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：自定义节点名称前缀。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/node.prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodePrefix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolLabelsCreation {\n");
            sb.Append("  osModelartsName: ").Append(OsModelartsName).Append("\n");
            sb.Append("  osModelartsWorkspaceId: ").Append(OsModelartsWorkspaceId).Append("\n");
            sb.Append("  osModelartsNodePrefix: ").Append(OsModelartsNodePrefix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolLabelsCreation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolLabelsCreation input)
        {
            if (input == null) return false;
            if (this.OsModelartsName != input.OsModelartsName || (this.OsModelartsName != null && !this.OsModelartsName.Equals(input.OsModelartsName))) return false;
            if (this.OsModelartsWorkspaceId != input.OsModelartsWorkspaceId || (this.OsModelartsWorkspaceId != null && !this.OsModelartsWorkspaceId.Equals(input.OsModelartsWorkspaceId))) return false;
            if (this.OsModelartsNodePrefix != input.OsModelartsNodePrefix || (this.OsModelartsNodePrefix != null && !this.OsModelartsNodePrefix.Equals(input.OsModelartsNodePrefix))) return false;

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
                if (this.OsModelartsName != null) hashCode = hashCode * 59 + this.OsModelartsName.GetHashCode();
                if (this.OsModelartsWorkspaceId != null) hashCode = hashCode * 59 + this.OsModelartsWorkspaceId.GetHashCode();
                if (this.OsModelartsNodePrefix != null) hashCode = hashCode * 59 + this.OsModelartsNodePrefix.GetHashCode();
                return hashCode;
            }
        }
    }
}
