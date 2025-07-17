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
    /// 全场静音请求。
    /// </summary>
    public class RestMuteReqBody 
    {

        /// <summary>
        /// - 0: 取消静音 - 1: 静音
        /// </summary>
        [JsonProperty("isMute", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMute { get; set; }

        /// <summary>
        /// 是否允许自己解除静音（仅静音时有效），默认为允许。 - 0: 不允许 - 1: 允许
        /// </summary>
        [JsonProperty("allowUnmuteByOneself", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowUnmuteByOneself { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestMuteReqBody {\n");
            sb.Append("  isMute: ").Append(IsMute).Append("\n");
            sb.Append("  allowUnmuteByOneself: ").Append(AllowUnmuteByOneself).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestMuteReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestMuteReqBody input)
        {
            if (input == null) return false;
            if (this.IsMute != input.IsMute || (this.IsMute != null && !this.IsMute.Equals(input.IsMute))) return false;
            if (this.AllowUnmuteByOneself != input.AllowUnmuteByOneself || (this.AllowUnmuteByOneself != null && !this.AllowUnmuteByOneself.Equals(input.AllowUnmuteByOneself))) return false;

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
                if (this.IsMute != null) hashCode = hashCode * 59 + this.IsMute.GetHashCode();
                if (this.AllowUnmuteByOneself != null) hashCode = hashCode * 59 + this.AllowUnmuteByOneself.GetHashCode();
                return hashCode;
            }
        }
    }
}
