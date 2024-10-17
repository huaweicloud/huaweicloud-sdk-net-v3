using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 批量操作的目标集合
    /// </summary>
    public class BatchTargets 
    {

        /// <summary>
        /// 执行批量任务的目标集合，最多支持100个目标，当task_type为firmwareUpgrade，softwareUpgrade时，此处填写device_id
        /// </summary>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Targets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchTargets {\n");
            sb.Append("  targets: ").Append(Targets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchTargets);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchTargets input)
        {
            if (input == null) return false;
            if (this.Targets != input.Targets || (this.Targets != null && input.Targets != null && !this.Targets.SequenceEqual(input.Targets))) return false;

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
                if (this.Targets != null) hashCode = hashCode * 59 + this.Targets.GetHashCode();
                return hashCode;
            }
        }
    }
}
