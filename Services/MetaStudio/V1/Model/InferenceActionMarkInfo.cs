using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 分身数字人推理预处理动作标记信息。
    /// </summary>
    public class InferenceActionMarkInfo 
    {

        /// <summary>
        /// 动作列表。
        /// </summary>
        [JsonProperty("action_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionMarkItem> ActionInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InferenceActionMarkInfo {\n");
            sb.Append("  actionInfo: ").Append(ActionInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InferenceActionMarkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InferenceActionMarkInfo input)
        {
            if (input == null) return false;
            if (this.ActionInfo != input.ActionInfo || (this.ActionInfo != null && input.ActionInfo != null && !this.ActionInfo.SequenceEqual(input.ActionInfo))) return false;

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
                if (this.ActionInfo != null) hashCode = hashCode * 59 + this.ActionInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
