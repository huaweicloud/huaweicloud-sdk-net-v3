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
    /// 邀请与会者请求。
    /// </summary>
    public class RestBulkHangUpReqBody 
    {

        /// <summary>
        /// 批量挂断会场列表，列表元素为与会者标识。
        /// </summary>
        [JsonProperty("bulkHangUpParticipants", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BulkHangUpParticipants { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestBulkHangUpReqBody {\n");
            sb.Append("  bulkHangUpParticipants: ").Append(BulkHangUpParticipants).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestBulkHangUpReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestBulkHangUpReqBody input)
        {
            if (input == null) return false;
            if (this.BulkHangUpParticipants != input.BulkHangUpParticipants || (this.BulkHangUpParticipants != null && input.BulkHangUpParticipants != null && !this.BulkHangUpParticipants.SequenceEqual(input.BulkHangUpParticipants))) return false;

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
                if (this.BulkHangUpParticipants != null) hashCode = hashCode * 59 + this.BulkHangUpParticipants.GetHashCode();
                return hashCode;
            }
        }
    }
}
