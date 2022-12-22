using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SwitchToMasterDisasterRecoveryBody 
    {

        /// <summary>
        /// 是否强制备实例升主。 若为True，则强制备实例升主，用于在主实例异常的状态下，快速恢复服务的场景：允许备实例强制升为特殊主实例，独立提供读写服务。 默认为False，用于正常状态下备实例平缓升主。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchToMasterDisasterRecoveryBody {\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchToMasterDisasterRecoveryBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchToMasterDisasterRecoveryBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
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
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                return hashCode;
            }
        }
    }
}
