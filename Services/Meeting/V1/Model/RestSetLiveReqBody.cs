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
    /// 启停会议直播请求。
    /// </summary>
    public class RestSetLiveReqBody 
    {

        /// <summary>
        /// 会议直播开关。默认值为0。 - 0: 停止会议直播 - 1: 启动会议直播
        /// </summary>
        [JsonProperty("isLive", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsLive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetLiveReqBody {\n");
            sb.Append("  isLive: ").Append(IsLive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetLiveReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetLiveReqBody input)
        {
            if (input == null) return false;
            if (this.IsLive != input.IsLive || (this.IsLive != null && !this.IsLive.Equals(input.IsLive))) return false;

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
                if (this.IsLive != null) hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                return hashCode;
            }
        }
    }
}
