using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// **参数解释**： 资源分组中的资源信息统计。
    /// </summary>
    public class InstanceStatistics 
    {

        /// <summary>
        /// **参数解释**： 该资源分组中当前处在告警状态的资源个数。  **取值范围**： 在[0,2147483647]区间内。
        /// </summary>
        [JsonProperty("unhealth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unhealth { get; set; }

        /// <summary>
        /// **参数解释**： 该资源分组中资源的总个数。  **取值范围**： 在[0,2147483647]区间内。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 该资源分组中选择的资源类型个数，如资源分组添加了弹性云服务、弹性公网IP和带宽则值为2。 **取值范围**： 在[0,2147483647]区间内。
        /// </summary>
        [JsonProperty("type_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public int? TypeStatistics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceStatistics {\n");
            sb.Append("  unhealth: ").Append(Unhealth).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  typeStatistics: ").Append(TypeStatistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceStatistics input)
        {
            if (input == null) return false;
            if (this.Unhealth != input.Unhealth || (this.Unhealth != null && !this.Unhealth.Equals(input.Unhealth))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.TypeStatistics != input.TypeStatistics || (this.TypeStatistics != null && !this.TypeStatistics.Equals(input.TypeStatistics))) return false;

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
                if (this.Unhealth != null) hashCode = hashCode * 59 + this.Unhealth.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TypeStatistics != null) hashCode = hashCode * 59 + this.TypeStatistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
