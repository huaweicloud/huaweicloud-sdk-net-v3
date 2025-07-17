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
    /// QOS请求用户信息
    /// </summary>
    public class UserQosReqInfo 
    {

        /// <summary>
        /// 用户pid
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// 用户接入媒体类型
        /// </summary>
        [JsonProperty("accessMediaType", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMediaType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserQosReqInfo {\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("  accessMediaType: ").Append(AccessMediaType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserQosReqInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserQosReqInfo input)
        {
            if (input == null) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;
            if (this.AccessMediaType != input.AccessMediaType || (this.AccessMediaType != null && !this.AccessMediaType.Equals(input.AccessMediaType))) return false;

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
                if (this.Pid != null) hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.AccessMediaType != null) hashCode = hashCode * 59 + this.AccessMediaType.GetHashCode();
                return hashCode;
            }
        }
    }
}
