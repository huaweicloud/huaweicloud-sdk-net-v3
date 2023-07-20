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
    public class ModifyProxyWeightRequest 
    {

        /// <summary>
        /// 主实例权重，取值范围为0~1000。
        /// </summary>
        [JsonProperty("master_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterWeight { get; set; }

        /// <summary>
        /// 只读实例信息。
        /// </summary>
        [JsonProperty("readonly_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyReadonlyInstances> ReadonlyInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyProxyWeightRequest {\n");
            sb.Append("  masterWeight: ").Append(MasterWeight).Append("\n");
            sb.Append("  readonlyInstances: ").Append(ReadonlyInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyProxyWeightRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyProxyWeightRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MasterWeight == input.MasterWeight ||
                    (this.MasterWeight != null &&
                    this.MasterWeight.Equals(input.MasterWeight))
                ) && 
                (
                    this.ReadonlyInstances == input.ReadonlyInstances ||
                    this.ReadonlyInstances != null &&
                    input.ReadonlyInstances != null &&
                    this.ReadonlyInstances.SequenceEqual(input.ReadonlyInstances)
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
                if (this.MasterWeight != null)
                    hashCode = hashCode * 59 + this.MasterWeight.GetHashCode();
                if (this.ReadonlyInstances != null)
                    hashCode = hashCode * 59 + this.ReadonlyInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
