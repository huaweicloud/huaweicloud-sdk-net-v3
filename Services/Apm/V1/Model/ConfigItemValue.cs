using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 采集参数配置列表
    /// </summary>
    public class ConfigItemValue 
    {

        /// <summary>
        /// 配置项名字
        /// </summary>
        [JsonProperty("config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [JsonProperty("config_data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigDataType { get; set; }

        /// <summary>
        /// 最大长度
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        [JsonProperty("min_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinValue { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        [JsonProperty("max_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// 可选值
        /// </summary>
        [JsonProperty("option_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionValue> OptionValues { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 开始版本
        /// </summary>
        [JsonProperty("since_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SinceVersion { get; set; }

        /// <summary>
        /// 截至版本
        /// </summary>
        [JsonProperty("dead_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DeadVersion { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 对象数组
        /// </summary>
        [JsonProperty("object_array_patterns", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectArrayPatterns> ObjectArrayPatterns { get; set; }

        /// <summary>
        /// 实际生效值
        /// </summary>
        [JsonProperty("override_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigItemOverride> OverrideList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigItemValue {\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  configDataType: ").Append(ConfigDataType).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  minValue: ").Append(MinValue).Append("\n");
            sb.Append("  maxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  optionValues: ").Append(OptionValues).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  sinceVersion: ").Append(SinceVersion).Append("\n");
            sb.Append("  deadVersion: ").Append(DeadVersion).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  objectArrayPatterns: ").Append(ObjectArrayPatterns).Append("\n");
            sb.Append("  overrideList: ").Append(OverrideList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigItemValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigItemValue input)
        {
            if (input == null) return false;
            if (this.ConfigName != input.ConfigName || (this.ConfigName != null && !this.ConfigName.Equals(input.ConfigName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.ConfigDataType != input.ConfigDataType || (this.ConfigDataType != null && !this.ConfigDataType.Equals(input.ConfigDataType))) return false;
            if (this.MaxLength != input.MaxLength || (this.MaxLength != null && !this.MaxLength.Equals(input.MaxLength))) return false;
            if (this.MinValue != input.MinValue || (this.MinValue != null && !this.MinValue.Equals(input.MinValue))) return false;
            if (this.MaxValue != input.MaxValue || (this.MaxValue != null && !this.MaxValue.Equals(input.MaxValue))) return false;
            if (this.OptionValues != input.OptionValues || (this.OptionValues != null && input.OptionValues != null && !this.OptionValues.SequenceEqual(input.OptionValues))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.SinceVersion != input.SinceVersion || (this.SinceVersion != null && !this.SinceVersion.Equals(input.SinceVersion))) return false;
            if (this.DeadVersion != input.DeadVersion || (this.DeadVersion != null && !this.DeadVersion.Equals(input.DeadVersion))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.ObjectArrayPatterns != input.ObjectArrayPatterns || (this.ObjectArrayPatterns != null && input.ObjectArrayPatterns != null && !this.ObjectArrayPatterns.SequenceEqual(input.ObjectArrayPatterns))) return false;
            if (this.OverrideList != input.OverrideList || (this.OverrideList != null && input.OverrideList != null && !this.OverrideList.SequenceEqual(input.OverrideList))) return false;

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
                if (this.ConfigName != null) hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ConfigDataType != null) hashCode = hashCode * 59 + this.ConfigDataType.GetHashCode();
                if (this.MaxLength != null) hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.MinValue != null) hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                if (this.MaxValue != null) hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                if (this.OptionValues != null) hashCode = hashCode * 59 + this.OptionValues.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.SinceVersion != null) hashCode = hashCode * 59 + this.SinceVersion.GetHashCode();
                if (this.DeadVersion != null) hashCode = hashCode * 59 + this.DeadVersion.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ObjectArrayPatterns != null) hashCode = hashCode * 59 + this.ObjectArrayPatterns.GetHashCode();
                if (this.OverrideList != null) hashCode = hashCode * 59 + this.OverrideList.GetHashCode();
                return hashCode;
            }
        }
    }
}
