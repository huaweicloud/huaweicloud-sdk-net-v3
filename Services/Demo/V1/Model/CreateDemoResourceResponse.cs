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
    /// Response Object
    /// </summary>
    public class CreateDemoResourceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultValue { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDemoResourceResponse {\n");
            sb.Append("  resultValue: ").Append(ResultValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDemoResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDemoResourceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultValue == input.ResultValue ||
                    (this.ResultValue != null &&
                    this.ResultValue.Equals(input.ResultValue))
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
                if (this.ResultValue != null)
                    hashCode = hashCode * 59 + this.ResultValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
