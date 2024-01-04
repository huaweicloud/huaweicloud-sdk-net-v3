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
    /// 配置风险项来源
    /// </summary>
    public class ConfigurationRisks 
    {

        /// <summary>
        /// 组件名称
        /// </summary>
        [JsonProperty("package", NullValueHandling = NullValueHandling.Ignore)]
        public string Package { get; set; }

        /// <summary>
        /// 涉及文件路径
        /// </summary>
        [JsonProperty("sourceFile", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFile { get; set; }

        /// <summary>
        /// 节点信息
        /// </summary>
        [JsonProperty("nodeMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeMsg { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// 修改操作类型
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 原始值
        /// </summary>
        [JsonProperty("originalValue", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalValue { get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationRisks {\n");
            sb.Append("  package: ").Append(Package).Append("\n");
            sb.Append("  sourceFile: ").Append(SourceFile).Append("\n");
            sb.Append("  nodeMsg: ").Append(NodeMsg).Append("\n");
            sb.Append("  field: ").Append(Field).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  originalValue: ").Append(OriginalValue).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationRisks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationRisks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
                ) && 
                (
                    this.SourceFile == input.SourceFile ||
                    (this.SourceFile != null &&
                    this.SourceFile.Equals(input.SourceFile))
                ) && 
                (
                    this.NodeMsg == input.NodeMsg ||
                    (this.NodeMsg != null &&
                    this.NodeMsg.Equals(input.NodeMsg))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.OriginalValue == input.OriginalValue ||
                    (this.OriginalValue != null &&
                    this.OriginalValue.Equals(input.OriginalValue))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
                if (this.SourceFile != null)
                    hashCode = hashCode * 59 + this.SourceFile.GetHashCode();
                if (this.NodeMsg != null)
                    hashCode = hashCode * 59 + this.NodeMsg.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.OriginalValue != null)
                    hashCode = hashCode * 59 + this.OriginalValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
