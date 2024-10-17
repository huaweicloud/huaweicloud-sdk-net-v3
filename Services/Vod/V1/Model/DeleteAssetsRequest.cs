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
    /// Request Object
    /// </summary>
    public class DeleteAssetsRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 媒资ID，支持一次删除多个媒资，批量删除时以逗号分隔。
        /// </summary>
        [SDKProperty("asset_id", IsQuery = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetId { get; set; }

        /// <summary>
        /// 删除类型，当值为origin时只删除源文件，保留转码后文件。
        /// </summary>
        [SDKProperty("delete_type", IsQuery = true)]
        [JsonProperty("delete_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAssetsRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  deleteType: ").Append(DeleteType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAssetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAssetsRequest input)
        {
            if (input == null) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && input.AssetId != null && !this.AssetId.SequenceEqual(input.AssetId))) return false;
            if (this.DeleteType != input.DeleteType || (this.DeleteType != null && !this.DeleteType.Equals(input.DeleteType))) return false;

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
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.DeleteType != null) hashCode = hashCode * 59 + this.DeleteType.GetHashCode();
                return hashCode;
            }
        }
    }
}
