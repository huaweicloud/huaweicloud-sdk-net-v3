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
    /// 合流任务参数，转推和录制至少选一个
    /// </summary>
    public class MixJobReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mix_param", NullValueHandling = NullValueHandling.Ignore)]
        public MixParam MixParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("record_param", NullValueHandling = NullValueHandling.Ignore)]
        public RecordParam RecordParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixJobReq {\n");
            sb.Append("  mixParam: ").Append(MixParam).Append("\n");
            sb.Append("  recordParam: ").Append(RecordParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MixParam == input.MixParam ||
                    (this.MixParam != null &&
                    this.MixParam.Equals(input.MixParam))
                ) && 
                (
                    this.RecordParam == input.RecordParam ||
                    (this.RecordParam != null &&
                    this.RecordParam.Equals(input.RecordParam))
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
                if (this.RecordParam != null)
                    hashCode = hashCode * 59 + this.RecordParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
