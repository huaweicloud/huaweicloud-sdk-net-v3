using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DataDiskCleanUpOption 
    {

        /// <summary>
        /// **参数解释：** 该参数用于控制腾挪节点时，是否擦除节点的除系统盘外的数据盘。 **约束限制：** 不涉及 **取值范围：** - false：腾挪节点时，不擦除节点的除系统盘外的数据盘。           - true：腾挪节点时，擦除节点的除系统盘外的数据盘。  **默认取值：** false
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// **参数解释：** 该参数用于控制腾挪节点时，擦除节点的数据盘失败时的处理策略。 **约束限制：** 不涉及 **取值范围：** - ignore：表示清理数据盘失败时忽略错误，继续执行。 - abort：表示清理数据盘失败时立即停止，并向上报错。  **默认取值：** ignore
        /// </summary>
        [JsonProperty("onFailure", NullValueHandling = NullValueHandling.Ignore)]
        public string OnFailure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataDiskCleanUpOption {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  onFailure: ").Append(OnFailure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataDiskCleanUpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataDiskCleanUpOption input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.OnFailure != input.OnFailure || (this.OnFailure != null && !this.OnFailure.Equals(input.OnFailure))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.OnFailure != null) hashCode = hashCode * 59 + this.OnFailure.GetHashCode();
                return hashCode;
            }
        }
    }
}
