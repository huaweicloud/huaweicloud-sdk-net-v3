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
    public class CreateBasicAwReq 
    {

        /// <summary>
        /// body请求体的类型：text(包含JSON，参数内部区分)、form
        /// </summary>
        [JsonProperty("body_param_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyParamType { get; set; }

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
        /// 默认请求头参数对象
        /// </summary>
        [JsonProperty("dft_custom_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> DftCustomHeader { get; set; }

        /// <summary>
        /// 定义的变量信息
        /// </summary>
        [JsonProperty("dft_variable_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> DftVariableList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 组名
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

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
            sb.Append("class CreateBasicAwReq {\n");
            sb.Append("  bodyParamType: ").Append(BodyParamType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dftCheckPointList: ").Append(DftCheckPointList).Append("\n");
            sb.Append("  dftCustomHeader: ").Append(DftCustomHeader).Append("\n");
            sb.Append("  dftVariableList: ").Append(DftVariableList).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
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
            return this.Equals(input as CreateBasicAwReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBasicAwReq input)
        {
            if (input == null) return false;
            if (this.BodyParamType != input.BodyParamType || (this.BodyParamType != null && !this.BodyParamType.Equals(input.BodyParamType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DftCheckPointList != input.DftCheckPointList || (this.DftCheckPointList != null && input.DftCheckPointList != null && !this.DftCheckPointList.SequenceEqual(input.DftCheckPointList))) return false;
            if (this.DftCustomHeader != input.DftCustomHeader || (this.DftCustomHeader != null && input.DftCustomHeader != null && !this.DftCustomHeader.SequenceEqual(input.DftCustomHeader))) return false;
            if (this.DftVariableList != input.DftVariableList || (this.DftVariableList != null && input.DftVariableList != null && !this.DftVariableList.SequenceEqual(input.DftVariableList))) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
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
                if (this.BodyParamType != null) hashCode = hashCode * 59 + this.BodyParamType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DftCheckPointList != null) hashCode = hashCode * 59 + this.DftCheckPointList.GetHashCode();
                if (this.DftCustomHeader != null) hashCode = hashCode * 59 + this.DftCustomHeader.GetHashCode();
                if (this.DftVariableList != null) hashCode = hashCode * 59 + this.DftVariableList.GetHashCode();
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParamTypeAndDftValue != null) hashCode = hashCode * 59 + this.ParamTypeAndDftValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
