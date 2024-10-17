using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PreheatingTaskRequestBody 
    {

        /// <summary>
        /// 是否对url中的中文字符进行编码后预热，false代表不开启，true代表开启，开启后仅预热转码后的URL。
        /// </summary>
        [JsonProperty("zh_url_encode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZhUrlEncode { get; set; }

        /// <summary>
        /// 需要预热的URL必须带有“http://”或“https://”，多个URL用逗号分隔，目前不支持对目录的预热，单个url的长度限制为4096字符,单次最多输入1000个url。
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreheatingTaskRequestBody {\n");
            sb.Append("  zhUrlEncode: ").Append(ZhUrlEncode).Append("\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreheatingTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreheatingTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.ZhUrlEncode != input.ZhUrlEncode || (this.ZhUrlEncode != null && !this.ZhUrlEncode.Equals(input.ZhUrlEncode))) return false;
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
                if (this.ZhUrlEncode != null) hashCode = hashCode * 59 + this.ZhUrlEncode.GetHashCode();
                if (this.Urls != null) hashCode = hashCode * 59 + this.Urls.GetHashCode();
                return hashCode;
            }
        }
    }
}
