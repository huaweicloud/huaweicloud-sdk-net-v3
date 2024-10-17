using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CountPublicIpResponse : SdkResponse
    {

        /// <summary>
        /// 弹性公网数量
        /// </summary>
        [JsonProperty("elasticip_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElasticipSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountPublicIpResponse {\n");
            sb.Append("  elasticipSize: ").Append(ElasticipSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountPublicIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountPublicIpResponse input)
        {
            if (input == null) return false;
            if (this.ElasticipSize != input.ElasticipSize || (this.ElasticipSize != null && !this.ElasticipSize.Equals(input.ElasticipSize))) return false;

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
                if (this.ElasticipSize != null) hashCode = hashCode * 59 + this.ElasticipSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
