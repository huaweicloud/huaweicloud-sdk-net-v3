using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConstructDisasterRecoveryBody 
    {

        /// <summary>
        /// 容灾ID。 对容灾角色为主的实例下发搭建容灾接口时不传该参数，接口成功响应后返回生成的容灾ID。 对容灾角色为备的实例下发建容灾接口时必传该参数，且必须与上述生成的容灾ID保持一致。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 搭建容灾关系的别名。
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 建立容灾关系所需要的容灾密码，搭建同一容灾关系的两次调用容灾密码必须保持一致。 容灾密码为容灾集群内部数据通信所用，不能用于客户端连接使用。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 指定当前实例的容灾角色。取值为master或slave，表示在容灾关系中角色为主或备。
        /// </summary>
        [JsonProperty("instance_role", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disaster_recovery_instance", NullValueHandling = NullValueHandling.Ignore)]
        public ConstructDisasterRecoveryInstance DisasterRecoveryInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructDisasterRecoveryBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  instanceRole: ").Append(InstanceRole).Append("\n");
            sb.Append("  disasterRecoveryInstance: ").Append(DisasterRecoveryInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConstructDisasterRecoveryBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConstructDisasterRecoveryBody input)
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
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.InstanceRole == input.InstanceRole ||
                    (this.InstanceRole != null &&
                    this.InstanceRole.Equals(input.InstanceRole))
                ) && 
                (
                    this.DisasterRecoveryInstance == input.DisasterRecoveryInstance ||
                    (this.DisasterRecoveryInstance != null &&
                    this.DisasterRecoveryInstance.Equals(input.DisasterRecoveryInstance))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.InstanceRole != null)
                    hashCode = hashCode * 59 + this.InstanceRole.GetHashCode();
                if (this.DisasterRecoveryInstance != null)
                    hashCode = hashCode * 59 + this.DisasterRecoveryInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
