using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RefreshTaskReq 
    {

        /// <summary>
        /// 完成态、删除态、发布态的媒资ID列表，一次性最多刷新10个媒资ID。
        /// </summary>
        [JsonProperty("asset_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIdList { get; set; }

        /// <summary>
        /// 完成态、删除态、发布态的播放URL列表，一次性最多刷新10个URL。 单个URL的长度不能超过10240。 
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshTaskReq {\n");
            sb.Append("  assetIdList: ").Append(AssetIdList).Append("\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefreshTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefreshTaskReq input)
        {
            if (input == null) return false;
            if (this.AssetIdList != input.AssetIdList || (this.AssetIdList != null && input.AssetIdList != null && !this.AssetIdList.SequenceEqual(input.AssetIdList))) return false;
            if (this.Urls != input.Urls || (this.Urls != null && input.Urls != null && !this.Urls.SequenceEqual(input.Urls))) return false;

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
                if (this.AssetIdList != null) hashCode = hashCode * 59 + this.AssetIdList.GetHashCode();
                if (this.Urls != null) hashCode = hashCode * 59 + this.Urls.GetHashCode();
                return hashCode;
            }
        }
    }
}
