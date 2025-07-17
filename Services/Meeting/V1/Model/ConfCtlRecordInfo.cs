using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 会控操作信息
    /// </summary>
    public class ConfCtlRecordInfo 
    {

        /// <summary>
        /// 操作时间（UTC时间，单位毫秒）。
        /// </summary>
        [JsonProperty("operateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? OperateTime { get; set; }

        /// <summary>
        /// 操作来源。
        /// </summary>
        [JsonProperty("operateSource", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateSource { get; set; }

        /// <summary>
        /// 操作者。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 操作描述。
        /// </summary>
        [JsonProperty("operateCode", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateCode { get; set; }

        /// <summary>
        /// 被操作对象。
        /// </summary>
        [JsonProperty("operationObject", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationObject { get; set; }

        /// <summary>
        /// 操作结果。
        /// </summary>
        [JsonProperty("operateResult", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateResult { get; set; }

        /// <summary>
        /// 详情。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfCtlRecordInfo {\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("  operateSource: ").Append(OperateSource).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  operateCode: ").Append(OperateCode).Append("\n");
            sb.Append("  operationObject: ").Append(OperationObject).Append("\n");
            sb.Append("  operateResult: ").Append(OperateResult).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfCtlRecordInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfCtlRecordInfo input)
        {
            if (input == null) return false;
            if (this.OperateTime != input.OperateTime || (this.OperateTime != null && !this.OperateTime.Equals(input.OperateTime))) return false;
            if (this.OperateSource != input.OperateSource || (this.OperateSource != null && !this.OperateSource.Equals(input.OperateSource))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.OperateCode != input.OperateCode || (this.OperateCode != null && !this.OperateCode.Equals(input.OperateCode))) return false;
            if (this.OperationObject != input.OperationObject || (this.OperationObject != null && !this.OperationObject.Equals(input.OperationObject))) return false;
            if (this.OperateResult != input.OperateResult || (this.OperateResult != null && !this.OperateResult.Equals(input.OperateResult))) return false;
            if (this.Detail != input.Detail || (this.Detail != null && !this.Detail.Equals(input.Detail))) return false;

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
                if (this.OperateTime != null) hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                if (this.OperateSource != null) hashCode = hashCode * 59 + this.OperateSource.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.OperateCode != null) hashCode = hashCode * 59 + this.OperateCode.GetHashCode();
                if (this.OperationObject != null) hashCode = hashCode * 59 + this.OperationObject.GetHashCode();
                if (this.OperateResult != null) hashCode = hashCode * 59 + this.OperateResult.GetHashCode();
                if (this.Detail != null) hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
