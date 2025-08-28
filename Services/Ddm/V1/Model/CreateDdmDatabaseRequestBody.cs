using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// databases参数说明
    /// </summary>
    public class CreateDdmDatabaseRequestBody 
    {

        /// <summary>
        /// 逻辑库名称，需要满足以下条件：  - 长度为2-48个字符。 - 必须以小写字母开头。 - 可以包含小写字母、数字、下划线，不能包含大写字母和其它特殊字符。 - 禁用关键字：  \&quot;information_schema\&quot;、\&quot;mysql\&quot;、\&quot;performance_schema\&quot;、\&quot;sys\&quot;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 逻辑库的拆分模式。 - cluster表示逻辑库是拆分模式。 - single表示逻辑库是非拆分模式。
        /// </summary>
        [JsonProperty("shard_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardMode { get; set; }

        /// <summary>
        /// 同一种工作模式下逻辑库分片的数量。 - shard_unit不为空， shard_unit与关联DN数量的乘积 - shard_unit为空，大于关联的DN数量，小于等于关联DN数量*64。
        /// </summary>
        [JsonProperty("shard_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardNumber { get; set; }

        /// <summary>
        /// 逻辑库关联的DN信息,最大个数为256。
        /// </summary>
        [JsonProperty("dn_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseDnInstances> DnInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDdmDatabaseRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shardMode: ").Append(ShardMode).Append("\n");
            sb.Append("  shardNumber: ").Append(ShardNumber).Append("\n");
            sb.Append("  dnInstances: ").Append(DnInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDdmDatabaseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDdmDatabaseRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ShardMode != input.ShardMode || (this.ShardMode != null && !this.ShardMode.Equals(input.ShardMode))) return false;
            if (this.ShardNumber != input.ShardNumber || (this.ShardNumber != null && !this.ShardNumber.Equals(input.ShardNumber))) return false;
            if (this.DnInstances != input.DnInstances || (this.DnInstances != null && input.DnInstances != null && !this.DnInstances.SequenceEqual(input.DnInstances))) return false;

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
                if (this.ShardMode != null) hashCode = hashCode * 59 + this.ShardMode.GetHashCode();
                if (this.ShardNumber != null) hashCode = hashCode * 59 + this.ShardNumber.GetHashCode();
                if (this.DnInstances != null) hashCode = hashCode * 59 + this.DnInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
