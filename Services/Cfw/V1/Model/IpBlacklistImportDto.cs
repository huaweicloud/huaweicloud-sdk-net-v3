using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 导入IP黑名单的消息body体，包括了导入的方式、生效范围和IP黑名单信息。
    /// </summary>
    public class IpBlacklistImportDto 
    {

        /// <summary>
        /// IP黑名单导入的方式，0表示增量导入，在原来的基础上追加；1表示全量导入，新导入的IP黑名单会覆盖已有的IP黑名单
        /// </summary>
        [JsonProperty("add_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddType { get; set; }

        /// <summary>
        /// IP列表，当前支持不同的IP地址之间使用“,” 、“ ”、“;”、“\\r\\n”、“\\n”、“\\t”等分割符进行分割。
        /// </summary>
        [JsonProperty("ip_blacklist", NullValueHandling = NullValueHandling.Ignore)]
        public string IpBlacklist { get; set; }

        /// <summary>
        /// 生效范围，1表示生效范围为eip, 2表示生效范围为nat, [1 2]表示 生效范围为eip和nat
        /// </summary>
        [JsonProperty("effect_scope", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> EffectScope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpBlacklistImportDto {\n");
            sb.Append("  addType: ").Append(AddType).Append("\n");
            sb.Append("  ipBlacklist: ").Append(IpBlacklist).Append("\n");
            sb.Append("  effectScope: ").Append(EffectScope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpBlacklistImportDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpBlacklistImportDto input)
        {
            if (input == null) return false;
            if (this.AddType != input.AddType || (this.AddType != null && !this.AddType.Equals(input.AddType))) return false;
            if (this.IpBlacklist != input.IpBlacklist || (this.IpBlacklist != null && !this.IpBlacklist.Equals(input.IpBlacklist))) return false;
            if (this.EffectScope != input.EffectScope || (this.EffectScope != null && input.EffectScope != null && !this.EffectScope.SequenceEqual(input.EffectScope))) return false;

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
                if (this.AddType != null) hashCode = hashCode * 59 + this.AddType.GetHashCode();
                if (this.IpBlacklist != null) hashCode = hashCode * 59 + this.IpBlacklist.GetHashCode();
                if (this.EffectScope != null) hashCode = hashCode * 59 + this.EffectScope.GetHashCode();
                return hashCode;
            }
        }
    }
}
