using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 参数服务对象。
    /// </summary>
    public class ServiceCommandPara 
    {

        /// <summary>
        /// 参数的名称。
        /// </summary>
        [JsonProperty("para_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParaName { get; set; }

        /// <summary>
        /// 参数是否必选。默认为false。
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// 参数的数据类型。取值范围：int，long，decimal，string，DateTime，jsonObject，enum，boolean，string list。
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// 参数的枚举值列表。
        /// </summary>
        [JsonProperty("enum_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnumList { get; set; }

        /// <summary>
        /// 参数的最小值。
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public string Min { get; set; }

        /// <summary>
        /// 参数的最大值。
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public string Max { get; set; }

        /// <summary>
        /// 参数的最大长度。
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// 参数的步长。
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// 参数的单位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 参数的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCommandPara {\n");
            sb.Append("  paraName: ").Append(ParaName).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("  enumList: ").Append(EnumList).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  step: ").Append(Step).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceCommandPara);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceCommandPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParaName == input.ParaName ||
                    (this.ParaName != null &&
                    this.ParaName.Equals(input.ParaName))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.EnumList == input.EnumList ||
                    this.EnumList != null &&
                    input.EnumList != null &&
                    this.EnumList.SequenceEqual(input.EnumList)
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ParaName != null)
                    hashCode = hashCode * 59 + this.ParaName.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.EnumList != null)
                    hashCode = hashCode * 59 + this.EnumList.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.Step != null)
                    hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
