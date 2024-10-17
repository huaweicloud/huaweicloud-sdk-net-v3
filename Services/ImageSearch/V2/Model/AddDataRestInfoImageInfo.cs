using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 添加图像数据的相关信息，不同服务类型返回信息不同，具体可参见服务类型说明。
    /// </summary>
    public class AddDataRestInfoImageInfo 
    {

        /// <summary>
        /// 添加的主体列表。
        /// </summary>
        [JsonProperty("objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddDataRestInfoImageInfoObjects> Objects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataRestInfoImageInfo {\n");
            sb.Append("  objects: ").Append(Objects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDataRestInfoImageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDataRestInfoImageInfo input)
        {
            if (input == null) return false;
            if (this.Objects != input.Objects || (this.Objects != null && input.Objects != null && !this.Objects.SequenceEqual(input.Objects))) return false;

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
                if (this.Objects != null) hashCode = hashCode * 59 + this.Objects.GetHashCode();
                return hashCode;
            }
        }
    }
}
