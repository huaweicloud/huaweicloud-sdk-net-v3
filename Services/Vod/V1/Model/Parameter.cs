using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 需要提取音频的参数信息。
    /// </summary>
    public class Parameter 
    {

        /// <summary>
        /// 封装格式。  取值如下： - MP3 - AAC
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parameter {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Parameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Parameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }
    }
}
