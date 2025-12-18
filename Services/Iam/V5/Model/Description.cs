using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 描述信息。
    /// </summary>
    public class Description 
    {

        /// <summary>
        /// 英文描述。
        /// </summary>
        [JsonProperty("en_US", NullValueHandling = NullValueHandling.Ignore)]
        public string EnUS { get; set; }

        /// <summary>
        /// 中文描述。
        /// </summary>
        [JsonProperty("zh_CN", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhCN { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Description {\n");
            sb.Append("  enUS: ").Append(EnUS).Append("\n");
            sb.Append("  zhCN: ").Append(ZhCN).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Description);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Description input)
        {
            if (input == null) return false;
            if (this.EnUS != input.EnUS || (this.EnUS != null && !this.EnUS.Equals(input.EnUS))) return false;
            if (this.ZhCN != input.ZhCN || (this.ZhCN != null && !this.ZhCN.Equals(input.ZhCN))) return false;

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
                if (this.EnUS != null) hashCode = hashCode * 59 + this.EnUS.GetHashCode();
                if (this.ZhCN != null) hashCode = hashCode * 59 + this.ZhCN.GetHashCode();
                return hashCode;
            }
        }
    }
}
