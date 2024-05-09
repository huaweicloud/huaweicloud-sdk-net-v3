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
    /// 修改对比策略请求体。
    /// </summary>
    public class ModifyComparePolicyReq 
    {

        /// <summary>
        /// 对比策略开关-open|close。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 对比策略周期。 - 每周对比：格式示例：“* * 1,3,5” ，其中“1,3,5”对应星期一、星期三、星期五，根据实际填写。 - 每天对比：固定填写“* * 1,2,3,4,5,6,7”。 - 按小时对比：固定填写“* * 1,2,3,4,5,6,7”。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 对比策略生效开始时间，UTC时间，24小时制，时间格式HH:mm:ss，例如：00:00:00，表示UTC时间的00:00:00，北京时间（UTC+08:00）的08:00:00。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 对比策略生效结束时间，UTC时间，24小时制，时间格式HH:mm:ss，例如：04:00:00，表示UTC时间的04:00:00，北京时间（UTC+08:00）的12:00:00。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 对比类型列表： - object_comparison：对象对比。 - lines：行对比。 - account：用户对比。
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CompareType { get; set; }

        /// <summary>
        /// 对比策略： - normal：普通对比。 - manyToOne：多对一对比。
        /// </summary>
        [JsonProperty("compare_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparePolicy { get; set; }

        /// <summary>
        /// 间隔时间，按小时对比时填写，表示每隔多久执行一次对比，单位是小时。
        /// </summary>
        [JsonProperty("interval_hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntervalHour { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyComparePolicyReq {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  comparePolicy: ").Append(ComparePolicy).Append("\n");
            sb.Append("  intervalHour: ").Append(IntervalHour).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyComparePolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyComparePolicyReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CompareType == input.CompareType ||
                    this.CompareType != null &&
                    input.CompareType != null &&
                    this.CompareType.SequenceEqual(input.CompareType)
                ) && 
                (
                    this.ComparePolicy == input.ComparePolicy ||
                    (this.ComparePolicy != null &&
                    this.ComparePolicy.Equals(input.ComparePolicy))
                ) && 
                (
                    this.IntervalHour == input.IntervalHour ||
                    (this.IntervalHour != null &&
                    this.IntervalHour.Equals(input.IntervalHour))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CompareType != null)
                    hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.ComparePolicy != null)
                    hashCode = hashCode * 59 + this.ComparePolicy.GetHashCode();
                if (this.IntervalHour != null)
                    hashCode = hashCode * 59 + this.IntervalHour.GetHashCode();
                return hashCode;
            }
        }
    }
}
