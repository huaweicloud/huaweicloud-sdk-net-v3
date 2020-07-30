using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Demo.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDemoResourceRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("only_one_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlyOneValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("two_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TwoValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("three_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeValue { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDemoResourceRequestBody {\n");
            sb.Append("  onlyOneValue: ").Append(OnlyOneValue).Append("\n");
            sb.Append("  twoValue: ").Append(TwoValue).Append("\n");
            sb.Append("  threeValue: ").Append(ThreeValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDemoResourceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDemoResourceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnlyOneValue == input.OnlyOneValue ||
                    (this.OnlyOneValue != null &&
                    this.OnlyOneValue.Equals(input.OnlyOneValue))
                ) && 
                (
                    this.TwoValue == input.TwoValue ||
                    (this.TwoValue != null &&
                    this.TwoValue.Equals(input.TwoValue))
                ) && 
                (
                    this.ThreeValue == input.ThreeValue ||
                    (this.ThreeValue != null &&
                    this.ThreeValue.Equals(input.ThreeValue))
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
                if (this.OnlyOneValue != null)
                    hashCode = hashCode * 59 + this.OnlyOneValue.GetHashCode();
                if (this.TwoValue != null)
                    hashCode = hashCode * 59 + this.TwoValue.GetHashCode();
                if (this.ThreeValue != null)
                    hashCode = hashCode * 59 + this.ThreeValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
