using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAuditUpgradeStatusResponse : SdkResponse
    {

        /// <summary>
        /// 实例升级信息
        /// </summary>
        [JsonProperty("audit_upgrade_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditUpgradeStatus> AuditUpgradeInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditUpgradeStatusResponse {\n");
            sb.Append("  auditUpgradeInfos: ").Append(AuditUpgradeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditUpgradeStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditUpgradeStatusResponse input)
        {
            if (input == null) return false;
            if (this.AuditUpgradeInfos != input.AuditUpgradeInfos || (this.AuditUpgradeInfos != null && input.AuditUpgradeInfos != null && !this.AuditUpgradeInfos.SequenceEqual(input.AuditUpgradeInfos))) return false;

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
                if (this.AuditUpgradeInfos != null) hashCode = hashCode * 59 + this.AuditUpgradeInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
