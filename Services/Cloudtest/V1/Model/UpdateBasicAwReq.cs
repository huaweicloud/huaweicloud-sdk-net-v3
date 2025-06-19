using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateBasicAwReq 
    {

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 默认检查点List
        /// </summary>
        [JsonProperty("dft_check_point_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckPoint> DftCheckPointList { get; set; }

        /// <summary>
        /// AW参数类list
        /// </summary>
        [JsonProperty("dft_custom_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> DftCustomHeader { get; set; }

        /// <summary>
        /// 重试间隔时间 (ms) 为空表示不等待(目前内部使用)
        /// </summary>
        [JsonProperty("dft_retry_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string DftRetryInterval { get; set; }

        /// <summary>
        /// 重试次数(目前内部使用)
        /// </summary>
        [JsonProperty("dft_retry_times", NullValueHandling = NullValueHandling.Ignore)]
        public string DftRetryTimes { get; set; }

        /// <summary>
        /// 定义的变量信息
        /// </summary>
        [JsonProperty("dft_variable_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> DftVariableList { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数类型和参数默认值对应List
        /// </summary>
        [JsonProperty("param_type_and_dft_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> ParamTypeAndDftValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBasicAwReq {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dftCheckPointList: ").Append(DftCheckPointList).Append("\n");
            sb.Append("  dftCustomHeader: ").Append(DftCustomHeader).Append("\n");
            sb.Append("  dftRetryInterval: ").Append(DftRetryInterval).Append("\n");
            sb.Append("  dftRetryTimes: ").Append(DftRetryTimes).Append("\n");
            sb.Append("  dftVariableList: ").Append(DftVariableList).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  paramTypeAndDftValue: ").Append(ParamTypeAndDftValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBasicAwReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBasicAwReq input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DftCheckPointList != input.DftCheckPointList || (this.DftCheckPointList != null && input.DftCheckPointList != null && !this.DftCheckPointList.SequenceEqual(input.DftCheckPointList))) return false;
            if (this.DftCustomHeader != input.DftCustomHeader || (this.DftCustomHeader != null && input.DftCustomHeader != null && !this.DftCustomHeader.SequenceEqual(input.DftCustomHeader))) return false;
            if (this.DftRetryInterval != input.DftRetryInterval || (this.DftRetryInterval != null && !this.DftRetryInterval.Equals(input.DftRetryInterval))) return false;
            if (this.DftRetryTimes != input.DftRetryTimes || (this.DftRetryTimes != null && !this.DftRetryTimes.Equals(input.DftRetryTimes))) return false;
            if (this.DftVariableList != input.DftVariableList || (this.DftVariableList != null && input.DftVariableList != null && !this.DftVariableList.SequenceEqual(input.DftVariableList))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParamTypeAndDftValue != input.ParamTypeAndDftValue || (this.ParamTypeAndDftValue != null && input.ParamTypeAndDftValue != null && !this.ParamTypeAndDftValue.SequenceEqual(input.ParamTypeAndDftValue))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DftCheckPointList != null) hashCode = hashCode * 59 + this.DftCheckPointList.GetHashCode();
                if (this.DftCustomHeader != null) hashCode = hashCode * 59 + this.DftCustomHeader.GetHashCode();
                if (this.DftRetryInterval != null) hashCode = hashCode * 59 + this.DftRetryInterval.GetHashCode();
                if (this.DftRetryTimes != null) hashCode = hashCode * 59 + this.DftRetryTimes.GetHashCode();
                if (this.DftVariableList != null) hashCode = hashCode * 59 + this.DftVariableList.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParamTypeAndDftValue != null) hashCode = hashCode * 59 + this.ParamTypeAndDftValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
