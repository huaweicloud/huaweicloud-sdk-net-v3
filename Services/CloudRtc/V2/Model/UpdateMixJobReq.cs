using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 合流任务参数
    /// </summary>
    public class UpdateMixJobReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mix_param", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateMixParam MixParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMixJobReq {\n");
            sb.Append("  mixParam: ").Append(MixParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMixJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMixJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MixParam == input.MixParam ||
                    (this.MixParam != null &&
                    this.MixParam.Equals(input.MixParam))
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
                if (this.MixParam != null)
                    hashCode = hashCode * 59 + this.MixParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
