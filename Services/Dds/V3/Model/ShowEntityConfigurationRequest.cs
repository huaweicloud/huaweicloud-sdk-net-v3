using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowEntityConfigurationRequest 
    {

        /// <summary>
        /// 实例ID，可以调用“查询实例列表和详情-QueryingInstancesandDetails”接口获取。如果未申请实例，可以调用“创建实例-CreatingaDBInstance”接口创建。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// - 实例ID或组ID或节点ID。可以调用“查询实例列表和详情”接口获取。如果未申请实例，可以调用“创建实例”接口创建。 - 当获取的实例类型是集群，如果获取的是shard组或者config组的参数模板，传值为组ID。如果获取的是mongos节点的参数模板，传值为节点ID。 - 当获取的实例类型是副本集或单节点，传值为实例ID。
        /// </summary>
        [SDKProperty("entity_id", IsQuery = true)]
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEntityConfigurationRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEntityConfigurationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEntityConfigurationRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.EntityId != null) hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                return hashCode;
            }
        }
    }
}
