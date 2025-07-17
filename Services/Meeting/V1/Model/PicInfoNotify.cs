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
    /// 子画面信息。
    /// </summary>
    public class PicInfoNotify 
    {

        /// <summary>
        /// 多画面中每个画面的编号，编号从1开始。
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }

        /// <summary>
        /// 每个画面中的与会者SIP号码。SIP号码可以通过[[查询企业通讯](https://support.huaweicloud.com/api-meeting/meeting_21_0512.html)](tag:hws)[[查询企业通讯](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0512.html)](tag:hk)获取。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 是否为辅流。 * 0： 不是辅流 * 1： 是辅流 
        /// </summary>
        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public int? Share { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PicInfoNotify {\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  share: ").Append(Share).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PicInfoNotify);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PicInfoNotify input)
        {
            if (input == null) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Share != input.Share || (this.Share != null && !this.Share.Equals(input.Share))) return false;

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
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Share != null) hashCode = hashCode * 59 + this.Share.GetHashCode();
                return hashCode;
            }
        }
    }
}
