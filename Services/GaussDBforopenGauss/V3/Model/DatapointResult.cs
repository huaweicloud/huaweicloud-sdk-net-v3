using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DatapointResult 
    {

        /// <summary>
        /// 指标项名，实例指标用实例ID、节点指标用节点名称、组件指标用组件名称。
        /// </summary>
        [JsonProperty("datapoint_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatapointName { get; set; }

        /// <summary>
        /// 指标值集合。
        /// </summary>
        [JsonProperty("datapoint_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatapointValues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatapointResult {\n");
            sb.Append("  datapointName: ").Append(DatapointName).Append("\n");
            sb.Append("  datapointValues: ").Append(DatapointValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatapointResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatapointResult input)
        {
            if (input == null) return false;
            if (this.DatapointName != input.DatapointName || (this.DatapointName != null && !this.DatapointName.Equals(input.DatapointName))) return false;
            if (this.DatapointValues != input.DatapointValues || (this.DatapointValues != null && input.DatapointValues != null && !this.DatapointValues.SequenceEqual(input.DatapointValues))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.DatapointName != null) hashCode = hashCode * 59 + this.DatapointName.GetHashCode();
                if (this.DatapointValues != null) hashCode = hashCode * 59 + this.DatapointValues.GetHashCode();
                return hashCode;
            }
        }
    }
}
