using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 对象级对比详情信息体。
    /// </summary>
    public class ObjectsCompareDetailInfo 
    {

        /// <summary>
        /// 源库名称。
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 目标库名称。
        /// </summary>
        [JsonProperty("target_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbName { get; set; }

        /// <summary>
        /// 在源库的值。
        /// </summary>
        [JsonProperty("source_db_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbValue { get; set; }

        /// <summary>
        /// 在目标库的值。
        /// </summary>
        [JsonProperty("target_db_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbValue { get; set; }

        /// <summary>
        /// 对比结果，0为不一致，2为一致，3为未完成。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectsCompareDetailInfo {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  sourceDbValue: ").Append(SourceDbValue).Append("\n");
            sb.Append("  targetDbValue: ").Append(TargetDbValue).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectsCompareDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectsCompareDetailInfo input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.TargetDbName != input.TargetDbName || (this.TargetDbName != null && !this.TargetDbName.Equals(input.TargetDbName))) return false;
            if (this.SourceDbValue != input.SourceDbValue || (this.SourceDbValue != null && !this.SourceDbValue.Equals(input.SourceDbValue))) return false;
            if (this.TargetDbValue != input.TargetDbValue || (this.TargetDbValue != null && !this.TargetDbValue.Equals(input.TargetDbValue))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
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
                if (this.SourceDbName != null) hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.TargetDbName != null) hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                if (this.SourceDbValue != null) hashCode = hashCode * 59 + this.SourceDbValue.GetHashCode();
                if (this.TargetDbValue != null) hashCode = hashCode * 59 + this.TargetDbValue.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
