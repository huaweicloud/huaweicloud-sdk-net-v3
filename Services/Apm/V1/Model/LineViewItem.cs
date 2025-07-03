using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 连接线视图函数详情。
    /// </summary>
    public class LineViewItem 
    {

        /// <summary>
        /// 表达式。
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// 作为。
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineViewItem {\n");
            sb.Append("  function: ").Append(Function).Append("\n");
            sb.Append("  As: ").Append(As).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LineViewItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LineViewItem input)
        {
            if (input == null) return false;
            if (this.Function != input.Function || (this.Function != null && !this.Function.Equals(input.Function))) return false;
            if (this.As != input.As || (this.As != null && !this.As.Equals(input.As))) return false;

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
                if (this.Function != null) hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.As != null) hashCode = hashCode * 59 + this.As.GetHashCode();
                return hashCode;
            }
        }
    }
}
