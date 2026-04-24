using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 用户使用频次信息。
    /// </summary>
    public class UserUsageFrequencyInfo 
    {

        /// <summary>
        /// 桌面用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户使用次数。
        /// </summary>
        [JsonProperty("use_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UseCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUsageFrequencyInfo {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  useCount: ").Append(UseCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserUsageFrequencyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserUsageFrequencyInfo input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UseCount != input.UseCount || (this.UseCount != null && !this.UseCount.Equals(input.UseCount))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UseCount != null) hashCode = hashCode * 59 + this.UseCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
