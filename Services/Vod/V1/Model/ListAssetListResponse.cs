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
    public class ListAssetListResponse : SdkResponse
    {

        /// <summary>
        /// 媒资总数  &gt; 暂只能统计2万个媒资，若您需要查询具体的媒资总数，请提交工单申请。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 媒资列表
        /// </summary>
        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetSummary> Assets { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetListResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  assets: ").Append(Assets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
                return hashCode;
            }
        }
    }
}
