using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPrivateipsResponse : SdkResponse
    {

        /// <summary>
        /// 私有IP列表对象
        /// </summary>
        [JsonProperty("privateips", NullValueHandling = NullValueHandling.Ignore)]
        public List<Privateip> Privateips { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateipsResponse {\n");
            sb.Append("  privateips: ").Append(Privateips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateipsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateipsResponse input)
        {
            if (input == null) return false;
            if (this.Privateips != input.Privateips || (this.Privateips != null && input.Privateips != null && !this.Privateips.SequenceEqual(input.Privateips))) return false;

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
                if (this.Privateips != null) hashCode = hashCode * 59 + this.Privateips.GetHashCode();
                return hashCode;
            }
        }
    }
}
