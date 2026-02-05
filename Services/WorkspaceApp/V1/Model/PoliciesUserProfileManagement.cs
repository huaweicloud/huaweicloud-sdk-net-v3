using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 用户配置策略。
    /// </summary>
    public class PoliciesUserProfileManagement 
    {

        /// <summary>
        /// 用户配置状态： 0: 已禁用 1: 已启用 2: 未配置
        /// </summary>
        [JsonProperty("upm_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpmStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public UserProfileManagementOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesUserProfileManagement {\n");
            sb.Append("  upmStatus: ").Append(UpmStatus).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesUserProfileManagement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesUserProfileManagement input)
        {
            if (input == null) return false;
            if (this.UpmStatus != input.UpmStatus || (this.UpmStatus != null && !this.UpmStatus.Equals(input.UpmStatus))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.UpmStatus != null) hashCode = hashCode * 59 + this.UpmStatus.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
