using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 精调训练环境变量信息
    /// </summary>
    public class EnvVar 
    {

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("des", NullValueHandling = NullValueHandling.Ignore)]
        public string Des { get; set; }

        /// <summary>
        /// 环境变量名称
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 环境变量类型
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvType { get; set; }

        /// <summary>
        /// 环境变量值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 环境变量是否可修改
        /// </summary>
        [JsonProperty("modifiable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Modifiable { get; set; }

        /// <summary>
        /// 环境变量是否展示
        /// </summary>
        [JsonProperty("displayable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Displayable { get; set; }

        /// <summary>
        /// 环境变量使用阶段
        /// </summary>
        [JsonProperty("used_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UsedSteps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvVar {\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  des: ").Append(Des).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  modifiable: ").Append(Modifiable).Append("\n");
            sb.Append("  displayable: ").Append(Displayable).Append("\n");
            sb.Append("  usedSteps: ").Append(UsedSteps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvVar);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvVar input)
        {
            if (input == null) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Des != input.Des || (this.Des != null && !this.Des.Equals(input.Des))) return false;
            if (this.EnvName != input.EnvName || (this.EnvName != null && !this.EnvName.Equals(input.EnvName))) return false;
            if (this.EnvType != input.EnvType || (this.EnvType != null && !this.EnvType.Equals(input.EnvType))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Modifiable != input.Modifiable || (this.Modifiable != null && !this.Modifiable.Equals(input.Modifiable))) return false;
            if (this.Displayable != input.Displayable || (this.Displayable != null && !this.Displayable.Equals(input.Displayable))) return false;
            if (this.UsedSteps != input.UsedSteps || (this.UsedSteps != null && input.UsedSteps != null && !this.UsedSteps.SequenceEqual(input.UsedSteps))) return false;

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
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Des != null) hashCode = hashCode * 59 + this.Des.GetHashCode();
                if (this.EnvName != null) hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.EnvType != null) hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Modifiable != null) hashCode = hashCode * 59 + this.Modifiable.GetHashCode();
                if (this.Displayable != null) hashCode = hashCode * 59 + this.Displayable.GetHashCode();
                if (this.UsedSteps != null) hashCode = hashCode * 59 + this.UsedSteps.GetHashCode();
                return hashCode;
            }
        }
    }
}
