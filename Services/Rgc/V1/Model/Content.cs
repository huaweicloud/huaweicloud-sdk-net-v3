using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 控制策略内容。
    /// </summary>
    public class Content 
    {

        /// <summary>
        /// 英文策略内容。
        /// </summary>
        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }

        /// <summary>
        /// 中文策略内容。
        /// </summary>
        [JsonProperty("ch", NullValueHandling = NullValueHandling.Ignore)]
        public string Ch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Content {\n");
            sb.Append("  en: ").Append(En).Append("\n");
            sb.Append("  ch: ").Append(Ch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Content);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Content input)
        {
            if (input == null) return false;
            if (this.En != input.En || (this.En != null && !this.En.Equals(input.En))) return false;
            if (this.Ch != input.Ch || (this.Ch != null && !this.Ch.Equals(input.Ch))) return false;

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
                if (this.En != null) hashCode = hashCode * 59 + this.En.GetHashCode();
                if (this.Ch != null) hashCode = hashCode * 59 + this.Ch.GetHashCode();
                return hashCode;
            }
        }
    }
}
