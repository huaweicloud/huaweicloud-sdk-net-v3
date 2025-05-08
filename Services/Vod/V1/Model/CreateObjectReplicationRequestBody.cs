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
    /// obs桶复制请求消息
    /// </summary>
    public class CreateObjectReplicationRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("src_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo SrcInfo { get; set; }

        /// <summary>
        /// 源文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dest_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo DestInfo { get; set; }

        /// <summary>
        /// 媒资分类id
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public Object CategoryId { get; set; }

        /// <summary>
        /// 回调地址，为空则不回调
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 自定义上下文，回调时会回调给用户，透传信息
        /// </summary>
        [JsonProperty("session_context", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateObjectReplicationRequestBody {\n");
            sb.Append("  srcInfo: ").Append(SrcInfo).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  destInfo: ").Append(DestInfo).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  sessionContext: ").Append(SessionContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateObjectReplicationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateObjectReplicationRequestBody input)
        {
            if (input == null) return false;
            if (this.SrcInfo != input.SrcInfo || (this.SrcInfo != null && !this.SrcInfo.Equals(input.SrcInfo))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.DestInfo != input.DestInfo || (this.DestInfo != null && !this.DestInfo.Equals(input.DestInfo))) return false;
            if (this.CategoryId != input.CategoryId || (this.CategoryId != null && !this.CategoryId.Equals(input.CategoryId))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.SessionContext != input.SessionContext || (this.SessionContext != null && !this.SessionContext.Equals(input.SessionContext))) return false;

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
                if (this.SrcInfo != null) hashCode = hashCode * 59 + this.SrcInfo.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.DestInfo != null) hashCode = hashCode * 59 + this.DestInfo.GetHashCode();
                if (this.CategoryId != null) hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SessionContext != null) hashCode = hashCode * 59 + this.SessionContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
