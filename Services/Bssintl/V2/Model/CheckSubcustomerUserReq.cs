using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckSubcustomerUserReq 
    {

        /// <summary>
        /// 该字段内容可填为：“email”、“mobile”或“name”。
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }

        /// <summary>
        /// 手机号、邮箱或登录名称。 手机号需符合正则表达式 ^\\d{4}-\\d+$；包括国家码，以00开头，格式：00XX-XXXXXXXX。邮箱需为含有@的正确格式的完整邮箱地址。name：符合正则表达式^\\(\\[a-zA-Z-\\]\\(\\[a-zA-Z0-9_-\\]\\)\\{4,31\\}\\)$，长度5-32；不能以“op_”或“shadow_”开头且不能全为数字，且只能以字母（不区分大小写）或者-开头。
        /// </summary>
        [JsonProperty("search_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckSubcustomerUserReq {\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("  searchValue: ").Append(SearchValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckSubcustomerUserReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckSubcustomerUserReq input)
        {
            if (input == null) return false;
            if (this.SearchType != input.SearchType || (this.SearchType != null && !this.SearchType.Equals(input.SearchType))) return false;
            if (this.SearchValue != input.SearchValue || (this.SearchValue != null && !this.SearchValue.Equals(input.SearchValue))) return false;

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
                if (this.SearchType != null) hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.SearchValue != null) hashCode = hashCode * 59 + this.SearchValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
