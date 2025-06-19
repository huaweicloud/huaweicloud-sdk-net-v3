using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPublicLibAndAwsResp 
    {

        /// <summary>
        /// 公共关键字分组信息
        /// </summary>
        [JsonProperty("aw_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string AwTag { get; set; }

        /// <summary>
        /// 公共关键字帮助文档链接
        /// </summary>
        [JsonProperty("document_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentLink { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsFavorite { get; set; }

        /// <summary>
        /// 公共关键字描述
        /// </summary>
        [JsonProperty("public_aw_description", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAwDescription { get; set; }

        /// <summary>
        /// 公共关键字唯一ID
        /// </summary>
        [JsonProperty("public_aw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAwId { get; set; }

        /// <summary>
        /// 公共关键库唯一ID
        /// </summary>
        [JsonProperty("public_aw_lib_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAwLibId { get; set; }

        /// <summary>
        /// 公共关键字库名称
        /// </summary>
        [JsonProperty("public_aw_lib_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAwLibName { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("public_aw_mark", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicAwMark { get; set; }

        /// <summary>
        /// 公共关键字名称
        /// </summary>
        [JsonProperty("public_aw_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAwName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPublicLibAndAwsResp {\n");
            sb.Append("  awTag: ").Append(AwTag).Append("\n");
            sb.Append("  documentLink: ").Append(DocumentLink).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  publicAwDescription: ").Append(PublicAwDescription).Append("\n");
            sb.Append("  publicAwId: ").Append(PublicAwId).Append("\n");
            sb.Append("  publicAwLibId: ").Append(PublicAwLibId).Append("\n");
            sb.Append("  publicAwLibName: ").Append(PublicAwLibName).Append("\n");
            sb.Append("  publicAwMark: ").Append(PublicAwMark).Append("\n");
            sb.Append("  publicAwName: ").Append(PublicAwName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetPublicLibAndAwsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetPublicLibAndAwsResp input)
        {
            if (input == null) return false;
            if (this.AwTag != input.AwTag || (this.AwTag != null && !this.AwTag.Equals(input.AwTag))) return false;
            if (this.DocumentLink != input.DocumentLink || (this.DocumentLink != null && !this.DocumentLink.Equals(input.DocumentLink))) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;
            if (this.PublicAwDescription != input.PublicAwDescription || (this.PublicAwDescription != null && !this.PublicAwDescription.Equals(input.PublicAwDescription))) return false;
            if (this.PublicAwId != input.PublicAwId || (this.PublicAwId != null && !this.PublicAwId.Equals(input.PublicAwId))) return false;
            if (this.PublicAwLibId != input.PublicAwLibId || (this.PublicAwLibId != null && !this.PublicAwLibId.Equals(input.PublicAwLibId))) return false;
            if (this.PublicAwLibName != input.PublicAwLibName || (this.PublicAwLibName != null && !this.PublicAwLibName.Equals(input.PublicAwLibName))) return false;
            if (this.PublicAwMark != input.PublicAwMark || (this.PublicAwMark != null && !this.PublicAwMark.Equals(input.PublicAwMark))) return false;
            if (this.PublicAwName != input.PublicAwName || (this.PublicAwName != null && !this.PublicAwName.Equals(input.PublicAwName))) return false;

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
                if (this.AwTag != null) hashCode = hashCode * 59 + this.AwTag.GetHashCode();
                if (this.DocumentLink != null) hashCode = hashCode * 59 + this.DocumentLink.GetHashCode();
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.PublicAwDescription != null) hashCode = hashCode * 59 + this.PublicAwDescription.GetHashCode();
                if (this.PublicAwId != null) hashCode = hashCode * 59 + this.PublicAwId.GetHashCode();
                if (this.PublicAwLibId != null) hashCode = hashCode * 59 + this.PublicAwLibId.GetHashCode();
                if (this.PublicAwLibName != null) hashCode = hashCode * 59 + this.PublicAwLibName.GetHashCode();
                if (this.PublicAwMark != null) hashCode = hashCode * 59 + this.PublicAwMark.GetHashCode();
                if (this.PublicAwName != null) hashCode = hashCode * 59 + this.PublicAwName.GetHashCode();
                return hashCode;
            }
        }
    }
}
