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
    /// 移动到等候室请求类
    /// </summary>
    public class RestBatchMoveToWaitingRoomReqBody 
    {

        /// <summary>
        /// 需要移入等候室的全部与会者pid
        /// </summary>
        [JsonProperty("batchParticipants", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BatchParticipants { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestBatchMoveToWaitingRoomReqBody {\n");
            sb.Append("  batchParticipants: ").Append(BatchParticipants).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestBatchMoveToWaitingRoomReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestBatchMoveToWaitingRoomReqBody input)
        {
            if (input == null) return false;
            if (this.BatchParticipants != input.BatchParticipants || (this.BatchParticipants != null && input.BatchParticipants != null && !this.BatchParticipants.SequenceEqual(input.BatchParticipants))) return false;

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
                if (this.BatchParticipants != null) hashCode = hashCode * 59 + this.BatchParticipants.GetHashCode();
                return hashCode;
            }
        }
    }
}
