using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSingleStreamBitrateResponse : SdkResponse
    {

        /// <summary>
        /// 用量详情。
        /// </summary>
        [JsonProperty("bitrate_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<V2BitrateInfo> BitrateInfoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSingleStreamBitrateResponse {\n");
            sb.Append("  bitrateInfoList: ").Append(BitrateInfoList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSingleStreamBitrateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSingleStreamBitrateResponse input)
        {
            if (input == null) return false;
            if (this.BitrateInfoList != input.BitrateInfoList || (this.BitrateInfoList != null && input.BitrateInfoList != null && !this.BitrateInfoList.SequenceEqual(input.BitrateInfoList))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.BitrateInfoList != null) hashCode = hashCode * 59 + this.BitrateInfoList.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
