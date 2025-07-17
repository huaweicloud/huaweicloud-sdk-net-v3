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
    /// rest设置Mmr直播请求体
    /// </summary>
    public class RestSetMmrLiveReqBody 
    {

        /// <summary>
        /// 0：停止Mmr会议直播 1：启动Mmr会议直播
        /// </summary>
        [JsonProperty("liveState", NullValueHandling = NullValueHandling.Ignore)]
        public int? LiveState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetMmrLiveReqBody {\n");
            sb.Append("  liveState: ").Append(LiveState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetMmrLiveReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetMmrLiveReqBody input)
        {
            if (input == null) return false;
            if (this.LiveState != input.LiveState || (this.LiveState != null && !this.LiveState.Equals(input.LiveState))) return false;

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
                if (this.LiveState != null) hashCode = hashCode * 59 + this.LiveState.GetHashCode();
                return hashCode;
            }
        }
    }
}
