using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CorsConfig 
    {

        /// <summary>
        /// 是否支持跨域
        /// </summary>
        [JsonProperty("is_cors", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorsConfig {\n");
            sb.Append("  isCors: ").Append(IsCors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CorsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CorsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCors == input.IsCors ||
                    (this.IsCors != null &&
                    this.IsCors.Equals(input.IsCors))
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
                if (this.IsCors != null)
                    hashCode = hashCode * 59 + this.IsCors.GetHashCode();
                return hashCode;
            }
        }
    }
}
