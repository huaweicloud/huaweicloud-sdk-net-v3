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
    /// 
    /// </summary>
    public class ObjectCompareResult 
    {

        /// <summary>
        /// 对象级对比任务的id。
        /// </summary>
        [JsonProperty("compare_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareTaskId { get; set; }

        /// <summary>
        /// 对象对比结果概览。
        /// </summary>
        [JsonProperty("object_compare_overview", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectCompareResultOverview> ObjectCompareOverview { get; set; }

        /// <summary>
        /// 对象对比结果详情。KEY值为对象对比结果概览中的对象类型。
        /// </summary>
        [JsonProperty("object_compare_details", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<ObjectCompareResultDetails>> ObjectCompareDetails { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectCompareResult {\n");
            sb.Append("  compareTaskId: ").Append(CompareTaskId).Append("\n");
            sb.Append("  objectCompareOverview: ").Append(ObjectCompareOverview).Append("\n");
            sb.Append("  objectCompareDetails: ").Append(ObjectCompareDetails).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectCompareResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectCompareResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompareTaskId == input.CompareTaskId ||
                    (this.CompareTaskId != null &&
                    this.CompareTaskId.Equals(input.CompareTaskId))
                ) && 
                (
                    this.ObjectCompareOverview == input.ObjectCompareOverview ||
                    this.ObjectCompareOverview != null &&
                    input.ObjectCompareOverview != null &&
                    this.ObjectCompareOverview.SequenceEqual(input.ObjectCompareOverview)
                ) && 
                (
                    this.ObjectCompareDetails == input.ObjectCompareDetails ||
                    this.ObjectCompareDetails != null &&
                    input.ObjectCompareDetails != null &&
                    this.ObjectCompareDetails.SequenceEqual(input.ObjectCompareDetails)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.CompareTaskId != null)
                    hashCode = hashCode * 59 + this.CompareTaskId.GetHashCode();
                if (this.ObjectCompareOverview != null)
                    hashCode = hashCode * 59 + this.ObjectCompareOverview.GetHashCode();
                if (this.ObjectCompareDetails != null)
                    hashCode = hashCode * 59 + this.ObjectCompareDetails.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
