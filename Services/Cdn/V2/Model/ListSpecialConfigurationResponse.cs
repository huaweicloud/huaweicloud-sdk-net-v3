using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSpecialConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 总条数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 域名特殊配置信息。
        /// </summary>
        [JsonProperty("specialConfigurations", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpeicialConfiguration> SpecialConfigurations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSpecialConfigurationResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  specialConfigurations: ").Append(SpecialConfigurations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSpecialConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSpecialConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SpecialConfigurations != input.SpecialConfigurations || (this.SpecialConfigurations != null && input.SpecialConfigurations != null && !this.SpecialConfigurations.SequenceEqual(input.SpecialConfigurations))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.SpecialConfigurations != null) hashCode = hashCode * 59 + this.SpecialConfigurations.GetHashCode();
                return hashCode;
            }
        }
    }
}
