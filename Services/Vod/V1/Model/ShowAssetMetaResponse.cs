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
    /// Response Object
    /// </summary>
    public class ShowAssetMetaResponse : SdkResponse
    {

        /// <summary>
        /// 媒资信息列表。
        /// </summary>
        [JsonProperty("asset_info_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetInfo> AssetInfoArray { get; set; }

        /// <summary>
        /// 列表是否被截断。  取值如下： - 1：表示本次查询未返回全部结果。 - 0：表示本次查询已经返回了全部结果。
        /// </summary>
        [JsonProperty("is_truncated", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsTruncated { get; set; }

        /// <summary>
        /// 查询媒资总数。  &gt; 暂只能统计2万个媒资，若您需要查询具体的媒资总数，请[提交工单](https://console.huaweicloud.com/ticket/?#/ticketindex/business?productTypeId&#x3D;462902cc39a04ab3a429df872021f970)申请。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetMetaResponse {\n");
            sb.Append("  assetInfoArray: ").Append(AssetInfoArray).Append("\n");
            sb.Append("  isTruncated: ").Append(IsTruncated).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetMetaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetMetaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetInfoArray == input.AssetInfoArray ||
                    this.AssetInfoArray != null &&
                    input.AssetInfoArray != null &&
                    this.AssetInfoArray.SequenceEqual(input.AssetInfoArray)
                ) && 
                (
                    this.IsTruncated == input.IsTruncated ||
                    (this.IsTruncated != null &&
                    this.IsTruncated.Equals(input.IsTruncated))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AssetInfoArray != null)
                    hashCode = hashCode * 59 + this.AssetInfoArray.GetHashCode();
                if (this.IsTruncated != null)
                    hashCode = hashCode * 59 + this.IsTruncated.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
