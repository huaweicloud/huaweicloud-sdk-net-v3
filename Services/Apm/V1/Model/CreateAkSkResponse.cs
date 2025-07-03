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
    /// Response Object
    /// </summary>
    public class CreateAkSkResponse : SdkResponse
    {

        /// <summary>
        /// 创建/删除的ak信息。
        /// </summary>
        [JsonProperty("ak", NullValueHandling = NullValueHandling.Ignore)]
        public string Ak { get; set; }

        /// <summary>
        /// 创建/删除的sk信息。
        /// </summary>
        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAkSkResponse {\n");
            sb.Append("  ak: ").Append(Ak).Append("\n");
            sb.Append("  sk: ").Append(Sk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAkSkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAkSkResponse input)
        {
            if (input == null) return false;
            if (this.Ak != input.Ak || (this.Ak != null && !this.Ak.Equals(input.Ak))) return false;
            if (this.Sk != input.Sk || (this.Sk != null && !this.Sk.Equals(input.Sk))) return false;

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
                if (this.Ak != null) hashCode = hashCode * 59 + this.Ak.GetHashCode();
                if (this.Sk != null) hashCode = hashCode * 59 + this.Sk.GetHashCode();
                return hashCode;
            }
        }
    }
}
