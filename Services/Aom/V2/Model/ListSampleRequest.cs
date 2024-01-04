using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSampleRequest 
    {

        /// <summary>
        /// 用于对查询到的时序数据进行断点插值，默认值为-1。-1：断点处使用-1进行表示。0 ：断点处使用0进行表示。null：断点处使用null进行表示。average：断点处使用前后邻近的有效数据的平均值进行表示，如果不存在有效数据则使用null进行表示。
        /// </summary>
        [SDKProperty("fill_value", IsQuery = true)]
        [JsonProperty("fill_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FillValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public QuerySampleParam Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSampleRequest {\n");
            sb.Append("  fillValue: ").Append(FillValue).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSampleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSampleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FillValue == input.FillValue ||
                    (this.FillValue != null &&
                    this.FillValue.Equals(input.FillValue))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.FillValue != null)
                    hashCode = hashCode * 59 + this.FillValue.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
