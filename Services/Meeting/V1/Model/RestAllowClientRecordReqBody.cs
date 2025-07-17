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
    /// 允许客户端录制请求。
    /// </summary>
    public class RestAllowClientRecordReqBody 
    {

        /// <summary>
        /// * 0：取消与会者客户端录制权限 * 1：允许与会者客户端录制 
        /// </summary>
        [JsonProperty("allowClientRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowClientRecord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestAllowClientRecordReqBody {\n");
            sb.Append("  allowClientRecord: ").Append(AllowClientRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestAllowClientRecordReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestAllowClientRecordReqBody input)
        {
            if (input == null) return false;
            if (this.AllowClientRecord != input.AllowClientRecord || (this.AllowClientRecord != null && !this.AllowClientRecord.Equals(input.AllowClientRecord))) return false;

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
                if (this.AllowClientRecord != null) hashCode = hashCode * 59 + this.AllowClientRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
