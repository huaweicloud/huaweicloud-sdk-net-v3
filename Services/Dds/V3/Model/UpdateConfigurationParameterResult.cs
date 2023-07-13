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
    /// 
    /// </summary>
    public class UpdateConfigurationParameterResult 
    {

        /// <summary>
        /// 实例ID或组ID或节点ID。可以调用“查询实例列表和详情”接口获取。如果未申请实例，可以调用“创建实例”接口创建。 - 当变更的实例类型是集群，如果变更的是shard组或者config组的参数模板，传值为组ID。如果变更的是mongos节点的参数模板，传值为节点ID。 - 当变更的实例类型是副本集或单节点，传值为实例ID。
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }

        /// <summary>
        /// 参数名和参数值映射关系。用户可以基于默认参数模板的参数，自定义的参数值。
        /// </summary>
        [JsonProperty("parameter_values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ParameterValues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateConfigurationParameterResult {\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("  parameterValues: ").Append(ParameterValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateConfigurationParameterResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateConfigurationParameterResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.ParameterValues == input.ParameterValues ||
                    this.ParameterValues != null &&
                    input.ParameterValues != null &&
                    this.ParameterValues.SequenceEqual(input.ParameterValues)
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.ParameterValues != null)
                    hashCode = hashCode * 59 + this.ParameterValues.GetHashCode();
                return hashCode;
            }
        }
    }
}
