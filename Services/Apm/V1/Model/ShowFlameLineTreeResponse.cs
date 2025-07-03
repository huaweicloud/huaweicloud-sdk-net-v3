using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowFlameLineTreeResponse : SdkResponse
    {

        /// <summary>
        /// 火焰图的数据，是个二维数组 data[0][0]: self time，方法自己消耗的cpu毫秒时间，不包括方法内部调用其他方法的时间 data[0][1]: total time, 方法消耗的cpu毫秒时间，包括方法内部调用其他方法的时间 data[0][2]: 方法的index,对应methods中的数组下标 data[0][3]: 行号 data[0][4]: 方法的子节点，就是方法中调用的其他方法
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Data { get; set; }

        /// <summary>
        /// 调用栈上的方法信息，是个二维数组 method[0][0]: 方法的唯一id method[0][1]: 方法的package包名 method[0][2]: 方法的class name 类名 method[0][3]: 方法名 method[0][4]: 方法的参数列表 method[0][5]: 方法是否为用户的方法 method[0][6]: 方法是否为native方法
        /// </summary>
        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Methods { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFlameLineTreeResponse {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  methods: ").Append(Methods).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFlameLineTreeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFlameLineTreeResponse input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;
            if (this.Methods != input.Methods || (this.Methods != null && input.Methods != null && !this.Methods.SequenceEqual(input.Methods))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Methods != null) hashCode = hashCode * 59 + this.Methods.GetHashCode();
                return hashCode;
            }
        }
    }
}
