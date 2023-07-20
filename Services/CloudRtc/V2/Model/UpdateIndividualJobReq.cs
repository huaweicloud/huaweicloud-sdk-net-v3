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
    /// 更新单流任务请求，转推和录制至少选一个
    /// </summary>
    public class UpdateIndividualJobReq 
    {

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
            sb.Append("class UpdateIndividualJobReq {\n");
            sb.Append("  recordParam: ").Append(RecordParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateIndividualJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateIndividualJobReq input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.RecordParam != null)
                    hashCode = hashCode * 59 + this.RecordParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
