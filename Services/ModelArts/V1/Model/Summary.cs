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
    /// 可视化日志summary。
    /// </summary>
    public class Summary 
    {

        /// <summary>
        /// **参数解释**：训练作业可视化日志类型，配置后训练作业可作为可视化作业数据源。 **约束限制**：不涉及。 **取值范围**： - tensorboard：输出TensorBoard可视化工具类型的日志 - mindstudio-insight：输出mindstudio-insight可视化工具类型的日志  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_dir", NullValueHandling = NullValueHandling.Ignore)]
        public LogDir LogDir { get; set; }

        /// <summary>
        /// **参数解释**：可视化作业或训练作业调试模式的可视化日志输入。 **约束限制**：训练作业高级功能开启\&quot;tensorboard/enable\&quot;: \&quot;true\&quot;或\&quot;mindstudio-insight/enable\&quot;: \&quot;true\&quot;时必填。
        /// </summary>
        [JsonProperty("data_sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataSource> DataSources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Summary {\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  logDir: ").Append(LogDir).Append("\n");
            sb.Append("  dataSources: ").Append(DataSources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Summary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Summary input)
        {
            if (input == null) return false;
            if (this.LogType != input.LogType || (this.LogType != null && !this.LogType.Equals(input.LogType))) return false;
            if (this.LogDir != input.LogDir || (this.LogDir != null && !this.LogDir.Equals(input.LogDir))) return false;
            if (this.DataSources != input.DataSources || (this.DataSources != null && input.DataSources != null && !this.DataSources.SequenceEqual(input.DataSources))) return false;

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
                if (this.LogType != null) hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LogDir != null) hashCode = hashCode * 59 + this.LogDir.GetHashCode();
                if (this.DataSources != null) hashCode = hashCode * 59 + this.DataSources.GetHashCode();
                return hashCode;
            }
        }
    }
}
