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
        /// 输入URL必须带有“http://”或“https://”，多个URL用逗号分隔，目前不支持对目录的预热，单个url的长度限制为4096字符,单次最多输入1000个url。
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
            if (input == null)
                return false;

            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
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
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                return hashCode;
            }
        }
    }
}
