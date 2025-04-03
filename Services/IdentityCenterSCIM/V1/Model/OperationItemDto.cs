using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationItemDto 
    {

        /// <summary>
        /// 要执行的修改操作类型。 add：添加属性，replace：替换属性，remove：删除属性
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public string Op { get; set; }

        /// <summary>
        /// 要修改的属性路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 要修改的属性值。执行删除操作时不填写
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Object Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationItemDto {\n");
            sb.Append("  op: ").Append(Op).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationItemDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationItemDto input)
        {
            if (input == null) return false;
            if (this.Op != input.Op || (this.Op != null && !this.Op.Equals(input.Op))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Op != null) hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
