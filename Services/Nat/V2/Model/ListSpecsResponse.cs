using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSpecsResponse : SdkResponse
    {

        /// <summary>
        /// 查询项目支持网关规格列表的响应体。
        /// </summary>
        [JsonProperty("specs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Spec> Specs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSpecsResponse {\n");
            sb.Append("  specs: ").Append(Specs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSpecsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSpecsResponse input)
        {
            if (input == null) return false;
            if (this.Specs != input.Specs || (this.Specs != null && input.Specs != null && !this.Specs.SequenceEqual(input.Specs))) return false;

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
                if (this.Specs != null) hashCode = hashCode * 59 + this.Specs.GetHashCode();
                return hashCode;
            }
        }
    }
}
