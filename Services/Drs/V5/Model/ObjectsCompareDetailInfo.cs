using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 对象级对比详情信息体。
    /// </summary>
    public class ObjectsCompareDetailInfo 
    {

        /// <summary>
        /// 源库对比值。
        /// </summary>
        [JsonProperty("source_db_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbValue { get; set; }

        /// <summary>
        /// 目标库对比值。
        /// </summary>
        [JsonProperty("target_db_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbValue { get; set; }

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
        /// 失败原因。
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
            sb.Append("  sourceDbValue: ").Append(SourceDbValue).Append("\n");
            sb.Append("  targetDbValue: ").Append(TargetDbValue).Append("\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.SourceDbValue == input.SourceDbValue ||
                    (this.SourceDbValue != null &&
                    this.SourceDbValue.Equals(input.SourceDbValue))
                ) && 
                (
                    this.TargetDbValue == input.TargetDbValue ||
                    (this.TargetDbValue != null &&
                    this.TargetDbValue.Equals(input.TargetDbValue))
                ) && 
                (
                    this.SourceDbName == input.SourceDbName ||
                    (this.SourceDbName != null &&
                    this.SourceDbName.Equals(input.SourceDbName))
                ) && 
                (
                    this.TargetDbName == input.TargetDbName ||
                    (this.TargetDbName != null &&
                    this.TargetDbName.Equals(input.TargetDbName))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.SourceDbValue != null)
                    hashCode = hashCode * 59 + this.SourceDbValue.GetHashCode();
                if (this.TargetDbValue != null)
                    hashCode = hashCode * 59 + this.TargetDbValue.GetHashCode();
                if (this.SourceDbName != null)
                    hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.TargetDbName != null)
                    hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
