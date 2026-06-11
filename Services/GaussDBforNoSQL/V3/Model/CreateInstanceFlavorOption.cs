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
    /// 实例规格详情。
    /// </summary>
    public class CreateInstanceFlavorOption 
    {

        /// <summary>
        /// **参数解释：** 节点数量。 **约束限制：** 不涉及。 **取值范围：** - GeminiDB Cassandra实例的节点数量可取3~60。 - GeminiDB Mongo 4.0版本副本集实例的节点数量为3。 - GeminiDB Influx集群实例的节点数量可取3~16。 - GeminiDB Influx单节点实例的节点数量可取1。 - GeminiDB Redis实例的节点数量可取3~12。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public string Num { get; set; }

        /// <summary>
        /// **参数解释：** 磁盘类型。 **约束限制：** 不涉及。 **取值范围：** 取值为“ULTRAHIGH”，表示SSD盘。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public string Storage { get; set; }

        /// <summary>
        /// **参数解释：** 磁盘大小。必须为整数，单位为GB。 **约束限制：** GeminiDB Cassandra，GeminiDB Mongo，GeminiDB Influx的最小磁盘容量100GB，最大磁盘容量与实例的性能规格有关。GeminiDB Redis的最大和最小磁盘容量与节点数和实例的性能规格有关。 **取值范围：** - GeminiDB Cassandra请参见数据库实例规格。 - GeminiDB Mongo请参见数据库实例规格。 - GeminiDB Influx请参见数据库实例规格。 - GeminiDB Redis请参见数据库实例规格。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// -| **参数解释：** 资源规格编码。 **约束限制：** 不涉及。 **取值范围：** 获取方法请参见查询数据库规格 - QueryingInstanceSpecifications中响应参数“spec_code”的值。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceFlavorOption {\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceFlavorOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceFlavorOption input)
        {
            if (input == null) return false;
            if (this.Num != input.Num || (this.Num != null && !this.Num.Equals(input.Num))) return false;
            if (this.Storage != input.Storage || (this.Storage != null && !this.Storage.Equals(input.Storage))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;

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
                if (this.Num != null) hashCode = hashCode * 59 + this.Num.GetHashCode();
                if (this.Storage != null) hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
