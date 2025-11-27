using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 修改数据库代理作业请求体。
    /// </summary>
    public class ModifyDbAgentJobRequestBody 
    {

        /// <summary>
        /// 配置文件id。
        /// </summary>
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyDbAgentJobRequestBody {\n");
            sb.Append("  profileId: ").Append(ProfileId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyDbAgentJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyDbAgentJobRequestBody input)
        {
            if (input == null) return false;
            if (this.ProfileId != input.ProfileId || (this.ProfileId != null && !this.ProfileId.Equals(input.ProfileId))) return false;

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
                if (this.ProfileId != null) hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                return hashCode;
            }
        }
    }
}
