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
    public class ShowTakeOverAssetDetailsRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。 
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 媒资原始输入存放的桶。
        /// </summary>
        [SDKProperty("source_bucket", IsQuery = true)]
        [JsonProperty("source_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBucket { get; set; }

        /// <summary>
        /// 媒资原始输入的objectKey。
        /// </summary>
        [SDKProperty("source_object", IsQuery = true)]
        [JsonProperty("source_object", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceObject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTakeOverAssetDetailsRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  sourceBucket: ").Append(SourceBucket).Append("\n");
            sb.Append("  sourceObject: ").Append(SourceObject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTakeOverAssetDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTakeOverAssetDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.XSdkDate == input.XSdkDate ||
                    (this.XSdkDate != null &&
                    this.XSdkDate.Equals(input.XSdkDate))
                ) && 
                (
                    this.SourceBucket == input.SourceBucket ||
                    (this.SourceBucket != null &&
                    this.SourceBucket.Equals(input.SourceBucket))
                ) && 
                (
                    this.SourceObject == input.SourceObject ||
                    (this.SourceObject != null &&
                    this.SourceObject.Equals(input.SourceObject))
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
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null)
                    hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.SourceBucket != null)
                    hashCode = hashCode * 59 + this.SourceBucket.GetHashCode();
                if (this.SourceObject != null)
                    hashCode = hashCode * 59 + this.SourceObject.GetHashCode();
                return hashCode;
            }
        }
    }
}
