using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 联邦用户映射到IAM中的身份信息
    /// </summary>
    public class RulesLocal 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public RulesLocalUser User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public RulesLocalGroup Group { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RulesLocal {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RulesLocal);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RulesLocal input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Group != input.Group || (this.Group != null && !this.Group.Equals(input.Group))) return false;

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
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                return hashCode;
            }
        }
    }
}
