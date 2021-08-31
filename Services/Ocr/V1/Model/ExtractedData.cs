using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtractedData 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("math_info", NullValueHandling = NullValueHandling.Ignore)]
        public MathInfo MathInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtractedData {\n");
            sb.Append("  mathInfo: ").Append(MathInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtractedData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtractedData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MathInfo == input.MathInfo ||
                    (this.MathInfo != null &&
                    this.MathInfo.Equals(input.MathInfo))
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
                if (this.MathInfo != null)
                    hashCode = hashCode * 59 + this.MathInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
