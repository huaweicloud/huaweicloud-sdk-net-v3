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
    /// 数据加工规则
    /// </summary>
    public class AddDataTransformationReq 
    {

        /// <summary>
        /// 对象信息。
        /// </summary>
        [JsonProperty("object_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateDataCompareDatabaseObject> ObjectInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transformation_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDataCompareTransformationInfo TransformationInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataTransformationReq {\n");
            sb.Append("  objectInfo: ").Append(ObjectInfo).Append("\n");
            sb.Append("  transformationInfo: ").Append(TransformationInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDataTransformationReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDataTransformationReq input)
        {
            if (input == null) return false;
            if (this.ObjectInfo != input.ObjectInfo || (this.ObjectInfo != null && input.ObjectInfo != null && !this.ObjectInfo.SequenceEqual(input.ObjectInfo))) return false;
            if (this.TransformationInfo != input.TransformationInfo || (this.TransformationInfo != null && !this.TransformationInfo.Equals(input.TransformationInfo))) return false;

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
                if (this.ObjectInfo != null) hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                if (this.TransformationInfo != null) hashCode = hashCode * 59 + this.TransformationInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
