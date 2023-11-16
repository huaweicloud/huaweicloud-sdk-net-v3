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
    /// Response Object
    /// </summary>
    public class ShowFuncReservedInstanceMetricsResponse : SdkResponse
    {

        /// <summary>
        /// 弹性实例指标
        /// </summary>
        [JsonProperty("instanceNum", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> InstanceNum { get; set; }

        /// <summary>
        /// 预留实例指标
        /// </summary>
        [JsonProperty("reservedInstanceNum", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> ReservedInstanceNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFuncReservedInstanceMetricsResponse {\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  reservedInstanceNum: ").Append(ReservedInstanceNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFuncReservedInstanceMetricsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFuncReservedInstanceMetricsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceNum == input.InstanceNum ||
                    this.InstanceNum != null &&
                    input.InstanceNum != null &&
                    this.InstanceNum.SequenceEqual(input.InstanceNum)
                ) && 
                (
                    this.ReservedInstanceNum == input.ReservedInstanceNum ||
                    this.ReservedInstanceNum != null &&
                    input.ReservedInstanceNum != null &&
                    this.ReservedInstanceNum.SequenceEqual(input.ReservedInstanceNum)
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
                if (this.InstanceNum != null)
                    hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                if (this.ReservedInstanceNum != null)
                    hashCode = hashCode * 59 + this.ReservedInstanceNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
