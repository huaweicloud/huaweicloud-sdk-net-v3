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
    /// 添加数据的可选参数，其中每个参数仅对部分服务类型生效，具体可参见服务类型说明。
    /// </summary>
    public class AddDataOptionalParam 
    {

        /// <summary>
        /// 是否进行目标检测，默认为true。
        /// </summary>
        [JsonProperty("do_det", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoDet { get; set; }

        /// <summary>
        /// 目标矩形框坐标，如给定则不进行目标检测，直接使用该box作为目标。格式为“x1,y1,x2,y2”（无空格），x1/y1为目标左上角坐标，x2/y2为目标右下角坐标，具体要求如下： - 0 &lt;&#x3D; x1 &lt; x2 &lt;&#x3D; width，默认要求x2-x1 &gt;&#x3D; 15，具体可参考服务类型说明。 - 0 &lt;&#x3D; y1 &lt; y2 &lt;&#x3D; height，默认要求y2-y1 &gt;&#x3D; 15，具体可参考服务类型说明。
        /// </summary>
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public string Box { get; set; }

        /// <summary>
        /// 是否进行对象分类，默认为true。
        /// </summary>
        [JsonProperty("do_cls", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoCls { get; set; }

        /// <summary>
        /// 对象类目，如给定则不进行对象分类，直接使用该category作为类目。具体类目信息可参见对应的服务类型说明。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public int? Category { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataOptionalParam {\n");
            sb.Append("  doDet: ").Append(DoDet).Append("\n");
            sb.Append("  box: ").Append(Box).Append("\n");
            sb.Append("  doCls: ").Append(DoCls).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDataOptionalParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDataOptionalParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DoDet == input.DoDet ||
                    (this.DoDet != null &&
                    this.DoDet.Equals(input.DoDet))
                ) && 
                (
                    this.Box == input.Box ||
                    (this.Box != null &&
                    this.Box.Equals(input.Box))
                ) && 
                (
                    this.DoCls == input.DoCls ||
                    (this.DoCls != null &&
                    this.DoCls.Equals(input.DoCls))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
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
                if (this.DoDet != null)
                    hashCode = hashCode * 59 + this.DoDet.GetHashCode();
                if (this.Box != null)
                    hashCode = hashCode * 59 + this.Box.GetHashCode();
                if (this.DoCls != null)
                    hashCode = hashCode * 59 + this.DoCls.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
