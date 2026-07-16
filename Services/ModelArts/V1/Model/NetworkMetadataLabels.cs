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
    /// 网络资源的标签信息。
    /// </summary>
    public class NetworkMetadataLabels 
    {

        /// <summary>
        /// **参数解释**：资源池的显示名称。 **取值范围**：只能以小写字母开头，数字、中划线组成，不能以中划线结尾，且长度为4-32。
        /// </summary>
        [JsonProperty("os.modelarts/name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsName { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc) **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/workspace.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsWorkspaceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkMetadataLabels {\n");
            sb.Append("  osModelartsName: ").Append(OsModelartsName).Append("\n");
            sb.Append("  osModelartsWorkspaceId: ").Append(OsModelartsWorkspaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkMetadataLabels);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkMetadataLabels input)
        {
            if (input == null) return false;
            if (this.OsModelartsName != input.OsModelartsName || (this.OsModelartsName != null && !this.OsModelartsName.Equals(input.OsModelartsName))) return false;
            if (this.OsModelartsWorkspaceId != input.OsModelartsWorkspaceId || (this.OsModelartsWorkspaceId != null && !this.OsModelartsWorkspaceId.Equals(input.OsModelartsWorkspaceId))) return false;

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
                return hashCode;
            }
        }
    }
}
