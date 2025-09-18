using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskCheckParamters 
    {

        /// <summary>
        /// 检查工具ID
        /// </summary>
        [JsonProperty("check_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckId { get; set; }

        /// <summary>
        /// 编译参数名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 检查参数配置信息
        /// </summary>
        [JsonProperty("checker_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckConfigInfo> CheckerConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCheckParamters {\n");
            sb.Append("  checkId: ").Append(CheckId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  checkerConfigs: ").Append(CheckerConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskCheckParamters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskCheckParamters input)
        {
            if (input == null) return false;
            if (this.CheckId != input.CheckId || (this.CheckId != null && !this.CheckId.Equals(input.CheckId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CheckerConfigs != input.CheckerConfigs || (this.CheckerConfigs != null && input.CheckerConfigs != null && !this.CheckerConfigs.SequenceEqual(input.CheckerConfigs))) return false;

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
                if (this.CheckId != null) hashCode = hashCode * 59 + this.CheckId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CheckerConfigs != null) hashCode = hashCode * 59 + this.CheckerConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
