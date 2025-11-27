using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 用于定义 Kubernetes Pod对Taint(污点)的容忍规则
    /// </summary>
    public class Toleration 
    {

        /// <summary>
        /// 表示要容忍的污点键名
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 定义Key与Value之间的关系，可选值为Exists或Equal，默认为Equal
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 表示要匹配的污点值，当Operator为Exists时，Value应为空
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 指定要匹配的污点效果，可选值为 NoSchedule、PreferNoSchedule或NoExecute，如果为空，表示匹配所有效果
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }

        /// <summary>
        /// 仅对NoExecute效果有效，表示Pod能容忍污点的时间
        /// </summary>
        [JsonProperty("tolerationSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? TolerationSeconds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Toleration {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  tolerationSeconds: ").Append(TolerationSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Toleration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Toleration input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;
            if (this.TolerationSeconds != input.TolerationSeconds || (this.TolerationSeconds != null && !this.TolerationSeconds.Equals(input.TolerationSeconds))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.TolerationSeconds != null) hashCode = hashCode * 59 + this.TolerationSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
