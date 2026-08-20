using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 执行步骤
    /// </summary>
    public class ExtensionExecutionStep 
    {

        /// <summary>
        /// DSL方法名，如 preOperationsNpm/sh/releasemanArtifactsUploader
        /// </summary>
        [JsonProperty("dslMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string DslMethod { get; set; }

        /// <summary>
        /// 步骤显示名
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 执行模式，如 serial
        /// </summary>
        [JsonProperty("executionMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// 步骤参数，键值对，值多为 $${...} 变量引用语法。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionExecutionStep {\n");
            sb.Append("  dslMethod: ").Append(DslMethod).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  executionMode: ").Append(ExecutionMode).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionExecutionStep);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionExecutionStep input)
        {
            if (input == null) return false;
            if (this.DslMethod != input.DslMethod || (this.DslMethod != null && !this.DslMethod.Equals(input.DslMethod))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.ExecutionMode != input.ExecutionMode || (this.ExecutionMode != null && !this.ExecutionMode.Equals(input.ExecutionMode))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.DslMethod != null) hashCode = hashCode * 59 + this.DslMethod.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ExecutionMode != null) hashCode = hashCode * 59 + this.ExecutionMode.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
