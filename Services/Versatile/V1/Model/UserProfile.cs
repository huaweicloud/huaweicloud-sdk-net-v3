using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserProfile 
    {

        /// <summary>
        /// 运行时, 是否读取用户画像
        /// </summary>
        [JsonProperty("enable_retrieve", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRetrieve { get; set; }

        /// <summary>
        /// 运行时, 是否构建用户画像
        /// </summary>
        [JsonProperty("enable_extract", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableExtract { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfile {\n");
            sb.Append("  enableRetrieve: ").Append(EnableRetrieve).Append("\n");
            sb.Append("  enableExtract: ").Append(EnableExtract).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserProfile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserProfile input)
        {
            if (input == null) return false;
            if (this.EnableRetrieve != input.EnableRetrieve || (this.EnableRetrieve != null && !this.EnableRetrieve.Equals(input.EnableRetrieve))) return false;
            if (this.EnableExtract != input.EnableExtract || (this.EnableExtract != null && !this.EnableExtract.Equals(input.EnableExtract))) return false;

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
                if (this.EnableRetrieve != null) hashCode = hashCode * 59 + this.EnableRetrieve.GetHashCode();
                if (this.EnableExtract != null) hashCode = hashCode * 59 + this.EnableExtract.GetHashCode();
                return hashCode;
            }
        }
    }
}
