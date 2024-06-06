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
    public class MysqlUpdateInstanceNameRequest 
    {

        /// <summary>
        /// 实例名称。  用于表示实例的名称，同一租户下，同类型的实例名可重名。取值范围：最小为4个字符，最大为64个字符且不超过64个字节（注意：一个中文字符占用3个字节），必须以字母或中文开头，区分大小写，可以包含字母、数字、中划线、下划线或中文，不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否同步修改节点名称，取值：true或false, 默认值为true。
        /// </summary>
        [JsonProperty("is_modify_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IsModifyNodeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlUpdateInstanceNameRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isModifyNodeName: ").Append(IsModifyNodeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlUpdateInstanceNameRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlUpdateInstanceNameRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsModifyNodeName == input.IsModifyNodeName ||
                    (this.IsModifyNodeName != null &&
                    this.IsModifyNodeName.Equals(input.IsModifyNodeName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsModifyNodeName != null)
                    hashCode = hashCode * 59 + this.IsModifyNodeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
