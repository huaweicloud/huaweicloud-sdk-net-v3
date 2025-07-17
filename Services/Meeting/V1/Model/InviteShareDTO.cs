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
    /// 邀请共享请求。
    /// </summary>
    public class InviteShareDTO 
    {

        /// <summary>
        /// 邀请标志。 * 0：取消邀请 * 1：邀请 
        /// </summary>
        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public int? Share { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteShareDTO {\n");
            sb.Append("  share: ").Append(Share).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InviteShareDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InviteShareDTO input)
        {
            if (input == null) return false;
            if (this.Share != input.Share || (this.Share != null && !this.Share.Equals(input.Share))) return false;

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
                if (this.Share != null) hashCode = hashCode * 59 + this.Share.GetHashCode();
                return hashCode;
            }
        }
    }
}
