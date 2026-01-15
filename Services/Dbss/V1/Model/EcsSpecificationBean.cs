using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EcsSpecificationBean 
    {

        /// <summary>
        /// ECS规格所在的可用区集合
        /// </summary>
        [JsonProperty("azs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Azs { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 规格等级，支持的等级以局点配置为准。 - entry：入门版 - low：基础版 - medium：专业版 - high：高级版
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规格可添加的数据库数量
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Proxy { get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        /// <summary>
        /// CPU
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// 可用区类型 - DEDICATED：大网 - DEC：边缘小站 - EDGE：专属
        /// </summary>
        [JsonProperty("az_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AzType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcsSpecificationBean {\n");
            sb.Append("  azs: ").Append(Azs).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  proxy: ").Append(Proxy).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  azType: ").Append(AzType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EcsSpecificationBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EcsSpecificationBean input)
        {
            if (input == null) return false;
            if (this.Azs != input.Azs || (this.Azs != null && input.Azs != null && !this.Azs.SequenceEqual(input.Azs))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Proxy != input.Proxy || (this.Proxy != null && !this.Proxy.Equals(input.Proxy))) return false;
            if (this.Ram != input.Ram || (this.Ram != null && !this.Ram.Equals(input.Ram))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.AzType != input.AzType || (this.AzType != null && !this.AzType.Equals(input.AzType))) return false;

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
                if (this.Azs != null) hashCode = hashCode * 59 + this.Azs.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Proxy != null) hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Ram != null) hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.AzType != null) hashCode = hashCode * 59 + this.AzType.GetHashCode();
                return hashCode;
            }
        }
    }
}
