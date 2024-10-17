using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProxyConfiguration 
    {

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数数据类型
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// 参数父标签类型
        /// </summary>
        [JsonProperty("elem_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ElemType { get; set; }

        /// <summary>
        /// 取值范围
        /// </summary>
        [JsonProperty("value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueRange { get; set; }

        /// <summary>
        /// 参数默认值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyConfiguration {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("  elemType: ").Append(ElemType).Append("\n");
            sb.Append("  valueRange: ").Append(ValueRange).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyConfiguration input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DataType != input.DataType || (this.DataType != null && !this.DataType.Equals(input.DataType))) return false;
            if (this.ElemType != input.ElemType || (this.ElemType != null && !this.ElemType.Equals(input.ElemType))) return false;
            if (this.ValueRange != input.ValueRange || (this.ValueRange != null && !this.ValueRange.Equals(input.ValueRange))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.DataType != null) hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.ElemType != null) hashCode = hashCode * 59 + this.ElemType.GetHashCode();
                if (this.ValueRange != null) hashCode = hashCode * 59 + this.ValueRange.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
