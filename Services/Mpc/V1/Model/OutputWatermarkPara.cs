using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OutputWatermarkPara 
    {

        /// <summary>
        /// 水印时长 
        /// </summary>
        [JsonProperty("time_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputWatermarkPara {\n");
            sb.Append("  timeDuration: ").Append(TimeDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputWatermarkPara);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputWatermarkPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeDuration == input.TimeDuration ||
                    (this.TimeDuration != null &&
                    this.TimeDuration.Equals(input.TimeDuration))
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
                if (this.TimeDuration != null)
                    hashCode = hashCode * 59 + this.TimeDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
