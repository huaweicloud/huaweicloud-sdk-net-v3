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
    /// 某种媒体的QoS，包括视频、音频或辅流
    /// </summary>
    public class MediaQos 
    {

        /// <summary>
        /// 客户端- -&gt;服务器方向QoS
        /// </summary>
        [JsonProperty("upList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Qos> UpList { get; set; }

        /// <summary>
        /// 服务器- -&gt;客户端方向QoS
        /// </summary>
        [JsonProperty("downList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Qos> DownList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaQos {\n");
            sb.Append("  upList: ").Append(UpList).Append("\n");
            sb.Append("  downList: ").Append(DownList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MediaQos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MediaQos input)
        {
            if (input == null) return false;
            if (this.UpList != input.UpList || (this.UpList != null && input.UpList != null && !this.UpList.SequenceEqual(input.UpList))) return false;
            if (this.DownList != input.DownList || (this.DownList != null && input.DownList != null && !this.DownList.SequenceEqual(input.DownList))) return false;

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
                if (this.UpList != null) hashCode = hashCode * 59 + this.UpList.GetHashCode();
                if (this.DownList != null) hashCode = hashCode * 59 + this.DownList.GetHashCode();
                return hashCode;
            }
        }
    }
}
