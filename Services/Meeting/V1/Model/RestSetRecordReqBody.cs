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
    /// 启停会议录制请求。
    /// </summary>
    public class RestSetRecordReqBody 
    {

        /// <summary>
        /// 录制启停开关。默认值为0。 - 0: 停止会议录制 - 1: 启动会议录制
        /// </summary>
        [JsonProperty("isRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRecord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetRecordReqBody {\n");
            sb.Append("  isRecord: ").Append(IsRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetRecordReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetRecordReqBody input)
        {
            if (input == null) return false;
            if (this.IsRecord != input.IsRecord || (this.IsRecord != null && !this.IsRecord.Equals(input.IsRecord))) return false;

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
                if (this.IsRecord != null) hashCode = hashCode * 59 + this.IsRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
