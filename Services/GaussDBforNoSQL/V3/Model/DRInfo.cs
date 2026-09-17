using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// **参数解释：** 容灾信息。 **约束限制：** 创建容灾实例时必传。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
    /// </summary>
    public class DRInfo 
    {

        /// <summary>
        /// **参数解释：** 容灾源实例ID。可以调用查询实例列表和详情-QueryingInstancesandDetails接口获取。 **约束限制：** - 创建容灾实例时该参数必传，表示为该源实例创建容灾实例。 - 源实例为GeminiDB Cassandra实例。 - 源实例状态为正常。 - 传该参数时，Datastore的type参数的值必须为“cassandra”。 - 一个源实例只能有一个容灾实例。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DRInfo {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DRInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DRInfo input)
        {
            if (input == null) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;

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
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
