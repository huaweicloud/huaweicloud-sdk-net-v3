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
    /// 删除与会者请求。
    /// </summary>
    public class RestBulkDelAttendReqBody 
    {

        /// <summary>
        /// 待删除会场列表。
        /// </summary>
        [JsonProperty("bulkDelAttendInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelAttendInfo> BulkDelAttendInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestBulkDelAttendReqBody {\n");
            sb.Append("  bulkDelAttendInfo: ").Append(BulkDelAttendInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestBulkDelAttendReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestBulkDelAttendReqBody input)
        {
            if (input == null) return false;
            if (this.BulkDelAttendInfo != input.BulkDelAttendInfo || (this.BulkDelAttendInfo != null && input.BulkDelAttendInfo != null && !this.BulkDelAttendInfo.SequenceEqual(input.BulkDelAttendInfo))) return false;

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
                if (this.BulkDelAttendInfo != null) hashCode = hashCode * 59 + this.BulkDelAttendInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
