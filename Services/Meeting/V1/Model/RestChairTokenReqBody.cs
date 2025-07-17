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
    /// 申请主持人请求。
    /// </summary>
    public class RestChairTokenReqBody 
    {

        /// <summary>
        /// - 0: 释放主持人 - 1: 申请主持人
        /// </summary>
        [JsonProperty("applyChair", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApplyChair { get; set; }

        /// <summary>
        /// 当申请主持人时，携带主持人密码。
        /// </summary>
        [JsonProperty("chairmanPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairmanPwd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestChairTokenReqBody {\n");
            sb.Append("  applyChair: ").Append(ApplyChair).Append("\n");
            sb.Append("  chairmanPwd: ").Append(ChairmanPwd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestChairTokenReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestChairTokenReqBody input)
        {
            if (input == null) return false;
            if (this.ApplyChair != input.ApplyChair || (this.ApplyChair != null && !this.ApplyChair.Equals(input.ApplyChair))) return false;
            if (this.ChairmanPwd != input.ChairmanPwd || (this.ChairmanPwd != null && !this.ChairmanPwd.Equals(input.ChairmanPwd))) return false;

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
                if (this.ApplyChair != null) hashCode = hashCode * 59 + this.ApplyChair.GetHashCode();
                if (this.ChairmanPwd != null) hashCode = hashCode * 59 + this.ChairmanPwd.GetHashCode();
                return hashCode;
            }
        }
    }
}
