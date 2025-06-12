using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 任务请求
    /// </summary>
    public class PictureModelingByUrlReq 
    {

        /// <summary>
        /// 图片URL
        /// </summary>
        [JsonProperty("picture_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 风格ID
        /// </summary>
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 照片建模任务结束的回调地址。
        /// </summary>
        [JsonProperty("notify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PictureModelingByUrlReq {\n");
            sb.Append("  pictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  notifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PictureModelingByUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PictureModelingByUrlReq input)
        {
            if (input == null) return false;
            if (this.PictureUrl != input.PictureUrl || (this.PictureUrl != null && !this.PictureUrl.Equals(input.PictureUrl))) return false;
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NotifyUrl != input.NotifyUrl || (this.NotifyUrl != null && !this.NotifyUrl.Equals(input.NotifyUrl))) return false;

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
                if (this.PictureUrl != null) hashCode = hashCode * 59 + this.PictureUrl.GetHashCode();
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NotifyUrl != null) hashCode = hashCode * 59 + this.NotifyUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
