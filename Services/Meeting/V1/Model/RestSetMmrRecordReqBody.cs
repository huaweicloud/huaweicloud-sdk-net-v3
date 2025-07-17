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
    /// rest设置MMR录播启停请求体
    /// </summary>
    public class RestSetMmrRecordReqBody 
    {

        /// <summary>
        /// 0：暂停MMR会议录制 1：启动MMR会议录制 2：停止MMR会议录制
        /// </summary>
        [JsonProperty("recordType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetMmrRecordReqBody {\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetMmrRecordReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetMmrRecordReqBody input)
        {
            if (input == null) return false;
            if (this.RecordType != input.RecordType || (this.RecordType != null && !this.RecordType.Equals(input.RecordType))) return false;

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
                if (this.RecordType != null) hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                return hashCode;
            }
        }
    }
}
