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
    /// 容灾实例信息。
    /// </summary>
    public class InstanceDrRelation 
    {

        /// <summary>
        /// 当前区域实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("master_instance", NullValueHandling = NullValueHandling.Ignore)]
        public MasterInstance MasterInstance { get; set; }

        /// <summary>
        /// 容灾实例信息列表。
        /// </summary>
        [JsonProperty("slave_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaveInstance> SlaveInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDrRelation {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  masterInstance: ").Append(MasterInstance).Append("\n");
            sb.Append("  slaveInstances: ").Append(SlaveInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDrRelation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDrRelation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.MasterInstance == input.MasterInstance ||
                    (this.MasterInstance != null &&
                    this.MasterInstance.Equals(input.MasterInstance))
                ) && 
                (
                    this.SlaveInstances == input.SlaveInstances ||
                    this.SlaveInstances != null &&
                    input.SlaveInstances != null &&
                    this.SlaveInstances.SequenceEqual(input.SlaveInstances)
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.MasterInstance != null)
                    hashCode = hashCode * 59 + this.MasterInstance.GetHashCode();
                if (this.SlaveInstances != null)
                    hashCode = hashCode * 59 + this.SlaveInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
