using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 一条IP黑名单的导入信息，包括文件名称、生效范围、导入状态、导入时间和导入失败的错误信息。
    /// </summary>
    public class IpBlacklistVO 
    {

        /// <summary>
        /// IP黑名单的文件名，对应导出时的文件名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// IP黑名单的生效范围，1表示EIP，2表示NAT
        /// </summary>
        [JsonProperty("effect_scope", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> EffectScope { get; set; }

        /// <summary>
        /// IP黑名单的导入状态，有三种状态：2：生成中、1：成功、0：失败。
        /// </summary>
        [JsonProperty("import_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportStatus { get; set; }

        /// <summary>
        /// IP黑名单的导入时间
        /// </summary>
        [JsonProperty("import_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ImportTime { get; set; }

        /// <summary>
        /// 导入失败的错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpBlacklistVO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  effectScope: ").Append(EffectScope).Append("\n");
            sb.Append("  importStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  importTime: ").Append(ImportTime).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpBlacklistVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpBlacklistVO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EffectScope != input.EffectScope || (this.EffectScope != null && input.EffectScope != null && !this.EffectScope.SequenceEqual(input.EffectScope))) return false;
            if (this.ImportStatus != input.ImportStatus || (this.ImportStatus != null && !this.ImportStatus.Equals(input.ImportStatus))) return false;
            if (this.ImportTime != input.ImportTime || (this.ImportTime != null && !this.ImportTime.Equals(input.ImportTime))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EffectScope != null) hashCode = hashCode * 59 + this.EffectScope.GetHashCode();
                if (this.ImportStatus != null) hashCode = hashCode * 59 + this.ImportStatus.GetHashCode();
                if (this.ImportTime != null) hashCode = hashCode * 59 + this.ImportTime.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
