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
    /// 回放异常SQL分类数据项
    /// </summary>
    public class ReplayErrorClassification 
    {

        /// <summary>
        /// 目标库标识
        /// </summary>
        [JsonProperty("target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetName { get; set; }

        /// <summary>
        /// 异常SQL分类
        /// </summary>
        [JsonProperty("error_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorType { get; set; }

        /// <summary>
        /// 异常SQL数量
        /// </summary>
        [JsonProperty("error_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCnt { get; set; }

        /// <summary>
        /// 异常SQL模板数量
        /// </summary>
        [JsonProperty("error_template_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorTemplateCnt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayErrorClassification {\n");
            sb.Append("  targetName: ").Append(TargetName).Append("\n");
            sb.Append("  errorType: ").Append(ErrorType).Append("\n");
            sb.Append("  errorCnt: ").Append(ErrorCnt).Append("\n");
            sb.Append("  errorTemplateCnt: ").Append(ErrorTemplateCnt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayErrorClassification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayErrorClassification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
                ) && 
                (
                    this.ErrorType == input.ErrorType ||
                    (this.ErrorType != null &&
                    this.ErrorType.Equals(input.ErrorType))
                ) && 
                (
                    this.ErrorCnt == input.ErrorCnt ||
                    (this.ErrorCnt != null &&
                    this.ErrorCnt.Equals(input.ErrorCnt))
                ) && 
                (
                    this.ErrorTemplateCnt == input.ErrorTemplateCnt ||
                    (this.ErrorTemplateCnt != null &&
                    this.ErrorTemplateCnt.Equals(input.ErrorTemplateCnt))
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
                if (this.TargetName != null)
                    hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.ErrorType != null)
                    hashCode = hashCode * 59 + this.ErrorType.GetHashCode();
                if (this.ErrorCnt != null)
                    hashCode = hashCode * 59 + this.ErrorCnt.GetHashCode();
                if (this.ErrorTemplateCnt != null)
                    hashCode = hashCode * 59 + this.ErrorTemplateCnt.GetHashCode();
                return hashCode;
            }
        }
    }
}
