using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangingTheDelayThresholdRequestBody 
    {

        /// <summary>
        /// 延时阈值（单位：KB），取值范围为0~10485760。
        /// </summary>
        [JsonProperty("delay_threshold_in_kilobytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayThresholdInKilobytes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangingTheDelayThresholdRequestBody {\n");
            sb.Append("  delayThresholdInKilobytes: ").Append(DelayThresholdInKilobytes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangingTheDelayThresholdRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangingTheDelayThresholdRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DelayThresholdInKilobytes == input.DelayThresholdInKilobytes ||
                    (this.DelayThresholdInKilobytes != null &&
                    this.DelayThresholdInKilobytes.Equals(input.DelayThresholdInKilobytes))
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
                if (this.DelayThresholdInKilobytes != null)
                    hashCode = hashCode * 59 + this.DelayThresholdInKilobytes.GetHashCode();
                return hashCode;
            }
        }
    }
}
