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
    public class MysqlProxyNodes 
    {

        /// <summary>
        /// Proxy节点ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Proxy节点状态。  取值范围： - ACTIVE，表示节点正常 - ABNORMAL，表示节点异常 - FAILED，表示节点失败 - DELETED，表示节点已删除
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Proxy节点名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Proxy节点角色：master和slave。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// Proxy节点是否被冻结。  取值范围： - 0-未冻结 - 1-冻结 - 2-冻结删除
        /// </summary>
        [JsonProperty("frozen_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrozenFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlProxyNodes {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  frozenFlag: ").Append(FrozenFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlProxyNodes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlProxyNodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.FrozenFlag == input.FrozenFlag ||
                    (this.FrozenFlag != null &&
                    this.FrozenFlag.Equals(input.FrozenFlag))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.FrozenFlag != null)
                    hashCode = hashCode * 59 + this.FrozenFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
