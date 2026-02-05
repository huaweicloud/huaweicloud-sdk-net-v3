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
    /// 用户漫游配置。
    /// </summary>
    public class UserProfileManagementOptions 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("profiles", NullValueHandling = NullValueHandling.Ignore)]
        public UserProfileManagementProfiles Profiles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileManagementOptions {\n");
            sb.Append("  profiles: ").Append(Profiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserProfileManagementOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserProfileManagementOptions input)
        {
            if (input == null) return false;
            if (this.Profiles != input.Profiles || (this.Profiles != null && !this.Profiles.Equals(input.Profiles))) return false;

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
                if (this.Profiles != null) hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                return hashCode;
            }
        }
    }
}
