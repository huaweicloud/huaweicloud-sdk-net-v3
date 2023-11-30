using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtLimitPojo 
    {

        /// <summary>
        /// - 最小入云限速
        /// </summary>
        [JsonProperty("min_ingress_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinIngressSize { get; set; }

        /// <summary>
        /// - 最大入云限速
        /// </summary>
        [JsonProperty("max_ingress_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIngressSize { get; set; }

        /// <summary>
        /// 95计费保底率
        /// </summary>
        [JsonProperty("ratio_95peak", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ratio95peak { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtLimitPojo {\n");
            sb.Append("  minIngressSize: ").Append(MinIngressSize).Append("\n");
            sb.Append("  maxIngressSize: ").Append(MaxIngressSize).Append("\n");
            sb.Append("  ratio95peak: ").Append(Ratio95peak).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtLimitPojo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtLimitPojo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinIngressSize == input.MinIngressSize ||
                    (this.MinIngressSize != null &&
                    this.MinIngressSize.Equals(input.MinIngressSize))
                ) && 
                (
                    this.MaxIngressSize == input.MaxIngressSize ||
                    (this.MaxIngressSize != null &&
                    this.MaxIngressSize.Equals(input.MaxIngressSize))
                ) && 
                (
                    this.Ratio95peak == input.Ratio95peak ||
                    (this.Ratio95peak != null &&
                    this.Ratio95peak.Equals(input.Ratio95peak))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MinIngressSize != null)
                    hashCode = hashCode * 59 + this.MinIngressSize.GetHashCode();
                if (this.MaxIngressSize != null)
                    hashCode = hashCode * 59 + this.MaxIngressSize.GetHashCode();
                if (this.Ratio95peak != null)
                    hashCode = hashCode * 59 + this.Ratio95peak.GetHashCode();
                return hashCode;
            }
        }
    }
}
