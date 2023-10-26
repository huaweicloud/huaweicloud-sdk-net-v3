using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 指标查询参数详情。
    /// </summary>
    public class MetricAPIQueryItemParam 
    {

        /// <summary>
        /// 资源编号,格式为resType_resId。其中resType部分的枚举值为：host, application, instance, container, process, network, storage, volume。当URI参数中的type取值为“inventory”时，通过该参数查询关联的指标，不再使用metricItems数组中的信息。
        /// </summary>
        [JsonProperty("inventoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string InventoryId { get; set; }

        /// <summary>
        /// 当URI参数中的type取值不为“inventory”时，就通过该数组传递的参数信息进行指标查询。
        /// </summary>
        [JsonProperty("metricItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryMetricItemOptionParam> MetricItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricAPIQueryItemParam {\n");
            sb.Append("  inventoryId: ").Append(InventoryId).Append("\n");
            sb.Append("  metricItems: ").Append(MetricItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricAPIQueryItemParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricAPIQueryItemParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InventoryId == input.InventoryId ||
                    (this.InventoryId != null &&
                    this.InventoryId.Equals(input.InventoryId))
                ) && 
                (
                    this.MetricItems == input.MetricItems ||
                    this.MetricItems != null &&
                    input.MetricItems != null &&
                    this.MetricItems.SequenceEqual(input.MetricItems)
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
                if (this.InventoryId != null)
                    hashCode = hashCode * 59 + this.InventoryId.GetHashCode();
                if (this.MetricItems != null)
                    hashCode = hashCode * 59 + this.MetricItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
