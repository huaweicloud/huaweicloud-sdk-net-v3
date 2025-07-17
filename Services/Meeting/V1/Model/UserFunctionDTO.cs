using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserFunctionDTO 
    {

        /// <summary>
        /// 是否开启智能协同白板功能。如果开启，表示该帐号是给智能协同白板使用，占用企业智能协同白板的资源，如果资源不足，则无法开启。 默认值：false。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [JsonProperty("enableRoom", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRoom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserFunctionDTO {\n");
            sb.Append("  enableRoom: ").Append(EnableRoom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserFunctionDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserFunctionDTO input)
        {
            if (input == null) return false;
            if (this.EnableRoom != input.EnableRoom || (this.EnableRoom != null && !this.EnableRoom.Equals(input.EnableRoom))) return false;

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
                if (this.EnableRoom != null) hashCode = hashCode * 59 + this.EnableRoom.GetHashCode();
                return hashCode;
            }
        }
    }
}
