using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Http/Https协议可以指定多个K/V对，在发送Http/Https协议消息时会携带这些K/V对作为请求header。extension字段允许为空，header字段允许为空。
    /// </summary>
    public class HttpDetectRequestBodyExtension 
    {

        /// <summary>
        /// header应满足如下要求： 1. key值限定为：包含英文字母([A-Za-z])、数字([0-9])、中划线(-)hyphens，中划线不得作为结尾，不得连续出现。 2. K/V不得超过10个 3. key需要以\&quot;x-\&quot;开头，不能以\&quot;x-smn\&quot;开头，正确示例：x-abc-cba,  x-abc 4. 所有K/V长度总和不得超过1024个字符 5. key不区分大小写 6. key值不可重复 7. value值限定为ASCII码，不支持中文或其他Unicode，支持空格
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Header { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpDetectRequestBodyExtension {\n");
            sb.Append("  header: ").Append(Header).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpDetectRequestBodyExtension);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpDetectRequestBodyExtension input)
        {
            if (input == null) return false;
            if (this.Header != input.Header || (this.Header != null && input.Header != null && !this.Header.SequenceEqual(input.Header))) return false;

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
                if (this.Header != null) hashCode = hashCode * 59 + this.Header.GetHashCode();
                return hashCode;
            }
        }
    }
}
